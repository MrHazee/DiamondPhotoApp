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
			databaseHandler.OnDatabasIsReady += new DataBaseHandler.StatusUpdateHandler(UpdateAndShowPhotoPanels);

		}

     
        private void UpdateAndShowPhotoPanels(object sender, ProgressEventArgs e)
        {
			listView1.Clear();
			
			for (int i = 0; i < databaseHandler.PhotosInfoList.Count; i++)
            {
				listView1.Items.Add("", i);
			}
			listView1.LargeImageList = photoControl.GetImageListFromURLs(databaseHandler.PhotosInfoList);

			if (this.listView1.Items.Count > 0)
			{
				this.listView1.Items[0].Selected = true;
				pictureBox1.BackColor = photoControl.GetPicturesAvrColor(0);
			}
            else
            {
				pictureBox1.Image = null;
				radioButtonNo.Checked = false;
				radioButtonYes.Checked = false;

			}
				;

			pictureBox1.Visible = true;
			listView1.Visible = true;
			funnyPanel.Visible = true;
			infoPane.Visible = false;
			ipPanel.Visible = false;

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
				UpdateLocationInfo();

				ipPanel.Visible = true;
				infoPane.Visible = true;
				pictureBox1.Visible = false;
				listView1.Visible = false;
				funnyPanel.Visible = false;
				this.Cursor = System.Windows.Forms.Cursors.Default;

			}


		}
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			List<int> indexes = listView1.SelectedIndices.Cast<int>().ToList();
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
				bool success = (IPAddress.TryParse(userIp, out _));
                
				if (success)
                {
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					success = locationWeather.FillWeatherProperties(userIp);

					if (success) UpdateLocationInfo();
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
		private void UpdateLocationInfo()
		{
			
			gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(locationWeather._Lat), double.Parse(locationWeather._Lon));
		
			gMapControl1.Update();
			gMapControl1.CanDragMap = true;

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

			flagPictureBox.Load(locationWeather._flagIconUrl);

			localClockTimer.Start();
		}
		private void GMapControl1_Load(object sender, EventArgs e)
        {
			gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
			gMapControl1.Zoom = gMapControl1.MaxZoom / 2;
			gMapControl1.MouseWheelZoomEnabled = true;
		}
        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
			if (gMapControl1.Zoom < gMapControl1.MaxZoom)
			{
				gMapControl1.Zoom++;
				gMapControl1.Update();
			}
		}

        private void ZoomOutBtn_Click(object sender, EventArgs e)
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
			List<int> indexes = listView1.SelectedIndices.Cast<int>().ToList();
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
			locationWeather.FillWeatherProperties();
			ipTextBox.Text = locationWeather._IP;
			ipTextBox.ForeColor = Color.Black;
			UpdateLocationInfo();
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
