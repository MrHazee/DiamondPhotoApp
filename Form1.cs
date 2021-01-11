using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using ExtensionMethods;

namespace MonitorPhotoApp
{
	public partial class Form1 : Form
	{
		
		private DataBaseHandler databaseHandler;
		private PhotosHandler photoControl;
		private LocaleData locationWeather;

		public Form1()
		{
	
			InitializeComponent();
			Log.InitLogger(loggerRichTextBox);

			Log.AddToLog("Initializing objects");
		
			photoControl = new PhotosHandler();
			locationWeather = new LocaleData();

			databaseHandler = new DataBaseHandler();
			// Not necessary to use delegate here
			databaseHandler.OnDatabasIsReady += new DataBaseHandler.StatusUpdateHandler(UpdateAndShowPhotoPanels);

		}

     
        private void UpdateAndShowPhotoPanels(object sender, ProgressEventArgs e)
        {

			Log.AddToLog($"We recieved photo attribute \"{e.Attr}\" from databse class. Proof of delegate concept.");
			// Clear list before filling it up
			photosListView.Clear();
			

			for (int i = 0; i < databaseHandler.PhotosInfoList.Count; i++)
            {
				photosListView.Items.Add("", i);
			}
			photosListView.LargeImageList = photoControl.GetImageListFromURLs(databaseHandler.PhotosInfoList);

			if (this.photosListView.Items.Count > 0)
			{
				// Select item one in photoListView
				this.photosListView.Items[0].Selected = true;
				// Set inte one in photoListView as picture in pictureBox 
				pictureBox1.BackColor = photoControl.GetPicturesAvrColor(0);
			}
            else
            {
				// If Image list is empty, remove pic from pictureBox
				pictureBox1.Image = null;
				radioButtonNo.Checked = false;
				radioButtonYes.Checked = false;
			}
			
			// Show relevant panes, should break this out or solve in better way
			pictureBox1.Visible = true;
			photosListView.Visible = true;
			funnyPanel.Visible = true;
			infoPane.Visible = false;
			ipPanel.Visible = false;

			// Return cursor to normal icon
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		private void MenuBtn_Clicked(object sender, EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			Button btn = sender as Button;

			if (btn == allPhotosBtn)
			{
				databaseHandler.ExtractDataFromDB(PhotoAttribute.all);
			}
			else if (btn == funnyPicsBtn)
			{
				databaseHandler.ExtractDataFromDB(PhotoAttribute.funny);
			}
			else if (btn == notFunnyPicsBtn)
			{
				databaseHandler.ExtractDataFromDB(PhotoAttribute.notFunny);
			}
			else if (btn == locationInfoBtn) {

				locationWeather.FillWeatherProperties();
				UpdateLocationUI();

				// Show relevant panes, should break this out or solve in better way
				ipPanel.Visible = true;
				infoPane.Visible = true;
				pictureBox1.Visible = false;
				photosListView.Visible = false;
				funnyPanel.Visible = false;
				this.Cursor = System.Windows.Forms.Cursors.Default;

			}


		}
		private void PhotoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

			// PhotoListView clicked, load corresponding picture into pictureBox
			List<int> indexes = photosListView.SelectedIndices.Cast<int>().ToList();
			if (indexes.Count > 0)
            {
				pictureBox1.Load(databaseHandler.PhotosInfoList[indexes[0]].URL);
				pictureBox1.BackColor = photoControl.GetPicturesAvrColor(indexes[0]);
				
				if (databaseHandler.PhotosInfoList[indexes[0]].IsFunny){
					radioButtonYes.Checked = true;
                }
                else {
					radioButtonNo.Checked = true;
				}

			}

		}
		private void IpTextBox_KeyDown(object sender, KeyEventArgs e)
		{
		
			if (ipTextBox.ForeColor == Color.Red)
			{
				ipTextBox.Clear();
				ipTextBox.ForeColor = Color.Black;
			}

			if (e.KeyCode == Keys.Enter)
			{
				
				TextBox objTextBox = (TextBox)sender;
				string userIp = objTextBox.Text.Trim();
				string errMsg = "Not Valid IP!";
				// Check if string is formatted as a valid IP-address
				bool success = (IPAddress.TryParse(userIp, out _));
                
				if (success)
                {
					// Loading Cursor
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					success = locationWeather.FillWeatherProperties(userIp);

					// If all succeeded, update gui
					if (success) UpdateLocationUI();
					else errMsg = "Only public IP!";
				}

                if (!success) {
					ipTextBox.Text = errMsg;
					ipTextBox.ForeColor = Color.Red;
				}
					
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
            
			}

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
			localTimeLabelVal.Text = locationWeather.getLocalTime();

		}
		private void UpdateLocationUI()
		{
			
			// Update map
			gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(locationWeather._Lat), double.Parse(locationWeather._Lon));
			gMapControl1.Update();
			gMapControl1.CanDragMap = true;

			//Update labels
			countryDisplayNameLabel.Text = locationWeather._CountryDisplayName;

			ipLabelVal.Text = locationWeather._IP;
			countryLabelVal.Text = locationWeather._Country;
			cityLabelVal.Text = locationWeather._City;
			currencyLabelVal.Text = locationWeather._Currency;
			currencySymbolLabelVal.Text = locationWeather._CurrencySymbol;
			longLabelVal.Text = locationWeather._Lon;
			latLabelVal.Text = locationWeather._Lat;

			weatherDesciptionLabelVal.Text = locationWeather._WeatherDescription.FirstCharToUpper();
			tempLabelVal.Text = locationWeather._Temp + "°";
			feelsLikeLabelVal.Text = locationWeather._TempFeelsLike + "°";
			maxTempLabelVal.Text = locationWeather._TempMax + "°";
			minTempLabelVal.Text = locationWeather._TempMin + "°";
			humidityLabelVal.Text = locationWeather._Humidity + "%";

			// Update flag picture box
			flagPictureBox.Load(locationWeather._flagIconUrl);

			// Start timer for local clock
			localClockTimer.Start();
		}
		private void GMapControl1_Load(object sender, EventArgs e)
        {
			gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
			gMapControl1.Zoom = gMapControl1.MaxZoom / 2;
			gMapControl1.MouseWheelZoomEnabled = true;
		}
        private void MapZoomInBtn_Click(object sender, EventArgs e)
        {
			if (gMapControl1.Zoom < gMapControl1.MaxZoom)
			{
				gMapControl1.Zoom++;
				gMapControl1.Update();
			}
		}

        private void MapZoomOutBtn_Click(object sender, EventArgs e)
        {
			if (gMapControl1.Zoom > gMapControl1.MinZoom)
			{
				gMapControl1.Zoom--;
				gMapControl1.Update();

			}
		}

		private void RadioButtons_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			List<int> indexes = photosListView.SelectedIndices.Cast<int>().ToList();
			int photoId = databaseHandler.PhotosInfoList[indexes[0]].ID;
			if (radioButtonYes.Checked)
			{
				databaseHandler.AlterDB(photoId, true);
				databaseHandler.PhotosInfoList[indexes[0]].IsFunny = true;
			}
			else if (radioButtonNo.Checked)
			{
				databaseHandler.AlterDB(photoId, false);
				databaseHandler.PhotosInfoList[indexes[0]].IsFunny = false;

			}
		}

        private void GetMyIpBtn_Click(object sender, EventArgs e)
        {
			// Retrieve public IP of this computer
			locationWeather.FillWeatherProperties();
			ipTextBox.Text = locationWeather._IP;
			ipTextBox.ForeColor = Color.Black;
			// Update UI
			UpdateLocationUI();
		}

        private void loggerRichTextBox_TextChanged(object sender, EventArgs e)
        {
			// set the current caret position to the end
			loggerRichTextBox.SelectionStart = loggerRichTextBox.Text.Length;
			// scroll it automatically
			loggerRichTextBox.ScrollToCaret();
			}
	}
}
