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

		private MyDataBaseClass _pgDB;
		private PhotosHandler _PhotosHandler;
		private LocaleData _locationWeather;

		

			
		    
		public Form1()
		{
	
			InitializeComponent();

				_PhotosHandler = new PhotosHandler();
				_locationWeather = new LocaleData();




				_pgDB = new MyDataBaseClass();
				_pgDB.OnUpdateStatus += new MyDataBaseClass.StatusUpdateHandler(UpdateData);
				_pgDB.connectToDB();
			
			//funnyQueryPanel.BackColor = Color.FromArgb(144, 69, 69, 98);

		}

     
        private void UpdateData(object sender, ProgressEventArgs e)
        {
			listView1.Clear();
			
			for (int i = 0; i < _pgDB.PhotosInfoList.Count; i++)
            {
				listView1.Items.Add("", i);
			}
			listView1.LargeImageList = _PhotosHandler.GetImageList(_pgDB.PhotosInfoList);
			if (this.listView1.Items.Count > 0)
			{
				this.listView1.Items[0].Selected = true;
				pictureBox1.BackColor = _PhotosHandler.getPicturesAvrColor(0);
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

        private void extractAllPhotos_Click(object sender, EventArgs e)
        {
			
			

			this.queryDatabase(PhotoAttribute.all);
		}

		private void extractFunnyPhotos_Click(object sender, EventArgs e)
		{
			this.queryDatabase(PhotoAttribute.funny);

		}

		private void queryDatabase(PhotoAttribute attr)
		{
			

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

			_pgDB.extractDataFromDB(attr);
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			List<int> indexes = listView1.SelectedIndices.Cast<int>().ToList();
			if (indexes.Count > 0)
            {
				pictureBox1.Load(_pgDB.PhotosInfoList[indexes[0]].URL);
				pictureBox1.BackColor = _PhotosHandler.getPicturesAvrColor(indexes[0]);
				
				if (_pgDB.PhotosInfoList[indexes[0]].IsFunny){
					radioButtonYes.Checked = true;
                }
                else {
					radioButtonNo.Checked = true;
				}

			}

		}
        private void buttonsStats_Click(object sender, EventArgs e)
        {

			_locationWeather.FillWeatherProperties();
			UpdateUi();

			ipPanel.Visible = true;
            infoPane.Visible = true;
			pictureBox1.Visible = false;
			listView1.Visible = false;
			funnyPanel.Visible = false;

			

		}

		private void ipTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			
			ipTextBox.ForeColor = Color.Black;
			if (e.KeyCode == Keys.Enter)
			{
					TextBox objTextBox = (TextBox)sender;
					string userIp = objTextBox.Text.Trim();
				if (IPAddress.TryParse(userIp, out _))
                {
					_locationWeather.FillWeatherProperties(userIp);
					UpdateUi();
				}
				else
				{
					ipTextBox.Text = "Not Valid IP!";
					ipTextBox.ForeColor = Color.Red;
				}
			}
            
			}

        private void timer1_Tick(object sender, EventArgs e)
        {

			localTimeLabelVal.Text = _locationWeather.getLocalTime();

		}
		private void UpdateUi()
		{
			
			gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(_locationWeather._Lat), double.Parse(_locationWeather._Lon));
		
			gMapControl1.Update();
			gMapControl1.CanDragMap = true;

			countryDisplayNameLabel.Text = _locationWeather._CountryDisplayName;

			ipLabelVal.Text = _locationWeather._IP;
			countryLabelVal.Text = _locationWeather._Country;
			cityLabelVal.Text = _locationWeather._City;
			currencyLabelVal.Text = _locationWeather._Currency;
			currencySymbolLabelVal.Text = _locationWeather._CurrencySymbol;
			longLabelVal.Text = _locationWeather._Lon;
			latLabelVal.Text = _locationWeather._Lat;

			weatherDesciptionLabelVal.Text = _locationWeather._WeatherDescription.FirstCharToUpper();
			tempLabelVal.Text = _locationWeather._Temp + "°";
			feelsLikeLabelVal.Text = _locationWeather._TempFeelsLike + "°";
			maxTempLabelVal.Text = _locationWeather._TempMax + "°";
			minTempLabelVal.Text = _locationWeather._TempMin + "°";
			humidityLabelVal.Text = _locationWeather._Humidity + "%";

			flagPictureBox.Load(_locationWeather._flagIconUrl);

			localClockTimer.Start();
		}
		private void gMapControl1_Load(object sender, EventArgs e)
        {
			gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
			gMapControl1.Zoom = gMapControl1.MaxZoom / 2;
			gMapControl1.MouseWheelZoomEnabled = true;
		}
        private void zoomInBtn_Click(object sender, EventArgs e)
        {
			if (gMapControl1.Zoom < gMapControl1.MaxZoom)
			{
				gMapControl1.Zoom++;
				gMapControl1.Update();
			}
		}

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
			if (gMapControl1.Zoom > gMapControl1.MinZoom)
			{
				gMapControl1.Zoom--;
				gMapControl1.Update();

			}
		}

		private void radioButtons_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			List<int> indexes = listView1.SelectedIndices.Cast<int>().ToList();
			int photoId = _pgDB.PhotosInfoList[indexes[0]].ID;
			if (radioButtonYes.Checked)
			{
				_pgDB.AlterDB(photoId, true);
				_pgDB.PhotosInfoList[indexes[0]].IsFunny = true;
			}
			else if (radioButtonNo.Checked)
			{
				_pgDB.AlterDB(photoId, false);
				_pgDB.PhotosInfoList[indexes[0]].IsFunny = false;

			}
		}

        private void getMyIpBtn_Click(object sender, EventArgs e)
        {
			_locationWeather.FillWeatherProperties();
			ipTextBox.Text = _locationWeather._IP;
			UpdateUi();
		}

    }
}
