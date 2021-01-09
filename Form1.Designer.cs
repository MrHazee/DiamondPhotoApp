
using System.Drawing;

namespace MonitorPhotoApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.locationInfoBtn = new System.Windows.Forms.Button();
            this.funnyPicsBtn = new System.Windows.Forms.Button();
            this.allPhotosBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.m = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ipPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.getMyIpBtn = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.pnlPicViewer = new System.Windows.Forms.Panel();
            this.funnyPanel = new System.Windows.Forms.Panel();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelFunny = new System.Windows.Forms.Label();
            this.infoPane = new System.Windows.Forms.Panel();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.flagPictureBox = new System.Windows.Forms.PictureBox();
            this.latLabel = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.weatherDesciptionLabel = new System.Windows.Forms.Label();
            this.longLabel = new System.Windows.Forms.Label();
            this.currencySymbolLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.localTimeLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.WeatherPanelVal = new System.Windows.Forms.Panel();
            this.weatherDesciptionLabelVal = new System.Windows.Forms.Label();
            this.humidityLabelVal = new System.Windows.Forms.Label();
            this.minTempLabelVal = new System.Windows.Forms.Label();
            this.maxTempLabelVal = new System.Windows.Forms.Label();
            this.localTimeLabelVal = new System.Windows.Forms.Label();
            this.tempLabelVal = new System.Windows.Forms.Label();
            this.feelsLikeLabelVal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.countryDisplayNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.latLabelVal = new System.Windows.Forms.Label();
            this.longLabelVal = new System.Windows.Forms.Label();
            this.ipLabelVal = new System.Windows.Forms.Label();
            this.countryLabelVal = new System.Windows.Forms.Label();
            this.cityLabelVal = new System.Windows.Forms.Label();
            this.currencySymbolLabelVal = new System.Windows.Forms.Label();
            this.currencyLabelVal = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.localClockTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.m.SuspendLayout();
            this.ipPanel.SuspendLayout();
            this.pnlPicViewer.SuspendLayout();
            this.funnyPanel.SuspendLayout();
            this.infoPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).BeginInit();
            this.WeatherPanelVal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select A Picture";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.panelSide.Controls.Add(this.panel2);
            this.panelSide.Controls.Add(this.locationInfoBtn);
            this.panelSide.Controls.Add(this.funnyPicsBtn);
            this.panelSide.Controls.Add(this.allPhotosBtn);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 574);
            this.panelSide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 314);
            this.panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(88)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 314);
            this.textBox1.TabIndex = 0;
            // 
            // locationInfoBtn
            // 
            this.locationInfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationInfoBtn.FlatAppearance.BorderSize = 0;
            this.locationInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationInfoBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.locationInfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("locationInfoBtn.Image")));
            this.locationInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationInfoBtn.Location = new System.Drawing.Point(0, 200);
            this.locationInfoBtn.Name = "locationInfoBtn";
            this.locationInfoBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.locationInfoBtn.Size = new System.Drawing.Size(200, 60);
            this.locationInfoBtn.TabIndex = 4;
            this.locationInfoBtn.Text = "Location Info";
            this.locationInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.locationInfoBtn.UseVisualStyleBackColor = true;
            this.locationInfoBtn.Click += new System.EventHandler(this.MenuBtn_Clicked);
            // 
            // funnyPicsBtn
            // 
            this.funnyPicsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.funnyPicsBtn.FlatAppearance.BorderSize = 0;
            this.funnyPicsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.funnyPicsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.funnyPicsBtn.Image = ((System.Drawing.Image)(resources.GetObject("funnyPicsBtn.Image")));
            this.funnyPicsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funnyPicsBtn.Location = new System.Drawing.Point(0, 140);
            this.funnyPicsBtn.Name = "funnyPicsBtn";
            this.funnyPicsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.funnyPicsBtn.Size = new System.Drawing.Size(200, 60);
            this.funnyPicsBtn.TabIndex = 3;
            this.funnyPicsBtn.Tag = "FunnyPics";
            this.funnyPicsBtn.Text = "  Extract Funny Pics";
            this.funnyPicsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.funnyPicsBtn.UseMnemonic = false;
            this.funnyPicsBtn.UseVisualStyleBackColor = true;
            this.funnyPicsBtn.Click += new System.EventHandler(this.MenuBtn_Clicked);
            // 
            // allPhotosBtn
            // 
            this.allPhotosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allPhotosBtn.FlatAppearance.BorderSize = 0;
            this.allPhotosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allPhotosBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.allPhotosBtn.Image = ((System.Drawing.Image)(resources.GetObject("allPhotosBtn.Image")));
            this.allPhotosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allPhotosBtn.Location = new System.Drawing.Point(0, 80);
            this.allPhotosBtn.Name = "allPhotosBtn";
            this.allPhotosBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.allPhotosBtn.Size = new System.Drawing.Size(200, 60);
            this.allPhotosBtn.TabIndex = 1;
            this.allPhotosBtn.Tag = "AllPics";
            this.allPhotosBtn.Text = "  Extract All Pics";
            this.allPhotosBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allPhotosBtn.UseMnemonic = false;
            this.allPhotosBtn.UseVisualStyleBackColor = true;
            this.allPhotosBtn.Click += new System.EventHandler(this.MenuBtn_Clicked);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // m
            // 
            this.m.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.m.Controls.Add(this.listView1);
            this.m.Controls.Add(this.ipPanel);
            this.m.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m.Location = new System.Drawing.Point(200, 463);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(834, 111);
            this.m.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 102);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ipPanel
            // 
            this.ipPanel.Controls.Add(this.label2);
            this.ipPanel.Controls.Add(this.getMyIpBtn);
            this.ipPanel.Controls.Add(this.richTextBox2);
            this.ipPanel.Controls.Add(this.richTextBox4);
            this.ipPanel.Controls.Add(this.richTextBox1);
            this.ipPanel.Controls.Add(this.richTextBox3);
            this.ipPanel.Controls.Add(this.label1);
            this.ipPanel.Controls.Add(this.ipTextBox);
            this.ipPanel.Location = new System.Drawing.Point(9, 6);
            this.ipPanel.Name = "ipPanel";
            this.ipPanel.Size = new System.Drawing.Size(815, 100);
            this.ipPanel.TabIndex = 5;
            this.ipPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(385, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "or";
            // 
            // getMyIpBtn
            // 
            this.getMyIpBtn.Location = new System.Drawing.Point(357, 81);
            this.getMyIpBtn.Name = "getMyIpBtn";
            this.getMyIpBtn.Size = new System.Drawing.Size(75, 23);
            this.getMyIpBtn.TabIndex = 6;
            this.getMyIpBtn.Text = "Get My IP";
            this.getMyIpBtn.UseVisualStyleBackColor = true;
            this.getMyIpBtn.Click += new System.EventHandler(this.GetMyIpBtn_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox2.Location = new System.Drawing.Point(690, 9);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(122, 88);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "196.200.184.31\n111.93.163.56\n72.30.2.43\n8.8.8.8";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox4.Location = new System.Drawing.Point(129, 9);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(115, 88);
            this.richTextBox4.TabIndex = 5;
            this.richTextBox4.Text = "88.208.245.221\n223.31.121.171\n109.228.14.251\n5.202.100.101";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(8, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(115, 88);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "88.213.251.98\n195.98.79.117\n91.121.143.182\n66.220.149.25";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox3.Location = new System.Drawing.Point(545, 9);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(139, 88);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "209.85.231.104 \n207.46.170.123\n213.171.217.148\n46.228.199.116";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(359, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Any IP";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.Location = new System.Drawing.Point(302, 30);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(187, 32);
            this.ipTextBox.TabIndex = 3;
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IpTextBox_KeyDown);
            // 
            // pnlPicViewer
            // 
            this.pnlPicViewer.Controls.Add(this.funnyPanel);
            this.pnlPicViewer.Controls.Add(this.infoPane);
            this.pnlPicViewer.Controls.Add(this.pictureBox1);
            this.pnlPicViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPicViewer.Location = new System.Drawing.Point(200, 0);
            this.pnlPicViewer.Name = "pnlPicViewer";
            this.pnlPicViewer.Size = new System.Drawing.Size(834, 463);
            this.pnlPicViewer.TabIndex = 4;
            // 
            // funnyPanel
            // 
            this.funnyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.funnyPanel.Controls.Add(this.radioButtonNo);
            this.funnyPanel.Controls.Add(this.radioButtonYes);
            this.funnyPanel.Controls.Add(this.labelFunny);
            this.funnyPanel.Location = new System.Drawing.Point(0, 422);
            this.funnyPanel.Name = "funnyPanel";
            this.funnyPanel.Size = new System.Drawing.Size(834, 41);
            this.funnyPanel.TabIndex = 2;
            this.funnyPanel.Visible = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButtonNo.Location = new System.Drawing.Point(504, 5);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 24);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButtonYes.Location = new System.Drawing.Point(258, 5);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(55, 24);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButtons_CheckedChanged);
            // 
            // labelFunny
            // 
            this.labelFunny.AutoSize = true;
            this.labelFunny.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunny.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFunny.Location = new System.Drawing.Point(319, -1);
            this.labelFunny.Name = "labelFunny";
            this.labelFunny.Size = new System.Drawing.Size(179, 33);
            this.labelFunny.TabIndex = 1;
            this.labelFunny.Text = "Funny picture?";
            // 
            // infoPane
            // 
            this.infoPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.infoPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPane.Controls.Add(this.zoomOutBtn);
            this.infoPane.Controls.Add(this.zoomInBtn);
            this.infoPane.Controls.Add(this.flagPictureBox);
            this.infoPane.Controls.Add(this.latLabel);
            this.infoPane.Controls.Add(this.gMapControl1);
            this.infoPane.Controls.Add(this.feelsLikeLabel);
            this.infoPane.Controls.Add(this.weatherDesciptionLabel);
            this.infoPane.Controls.Add(this.longLabel);
            this.infoPane.Controls.Add(this.currencySymbolLabel);
            this.infoPane.Controls.Add(this.currencyLabel);
            this.infoPane.Controls.Add(this.localTimeLabel);
            this.infoPane.Controls.Add(this.humidityLabel);
            this.infoPane.Controls.Add(this.WeatherPanelVal);
            this.infoPane.Controls.Add(this.panel4);
            this.infoPane.Controls.Add(this.panel3);
            this.infoPane.Controls.Add(this.ipLabel);
            this.infoPane.Controls.Add(this.minTempLabel);
            this.infoPane.Controls.Add(this.maxTempLabel);
            this.infoPane.Controls.Add(this.tempLabel);
            this.infoPane.Controls.Add(this.cityLabel);
            this.infoPane.Controls.Add(this.countryLabel);
            this.infoPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPane.Location = new System.Drawing.Point(0, 0);
            this.infoPane.Name = "infoPane";
            this.infoPane.Size = new System.Drawing.Size(834, 463);
            this.infoPane.TabIndex = 1;
            this.infoPane.Visible = false;
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Location = new System.Drawing.Point(699, 237);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(75, 23);
            this.zoomOutBtn.TabIndex = 31;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(609, 237);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(75, 23);
            this.zoomInBtn.TabIndex = 30;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // flagPictureBox
            // 
            this.flagPictureBox.Location = new System.Drawing.Point(340, 323);
            this.flagPictureBox.Name = "flagPictureBox";
            this.flagPictureBox.Size = new System.Drawing.Size(137, 80);
            this.flagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagPictureBox.TabIndex = 17;
            this.flagPictureBox.TabStop = false;
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.BackColor = System.Drawing.Color.Transparent;
            this.latLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.latLabel.Location = new System.Drawing.Point(45, 422);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(71, 20);
            this.latLabel.TabIndex = 27;
            this.latLabel.Text = "Latitude:";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(6, 55);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 1;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(834, 221);
            this.gMapControl1.TabIndex = 28;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.GMapControl1_Load);
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.AutoSize = true;
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.feelsLikeLabel.Location = new System.Drawing.Point(532, 343);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(85, 20);
            this.feelsLikeLabel.TabIndex = 26;
            this.feelsLikeLabel.Text = "Feels Like:";
            // 
            // weatherDesciptionLabel
            // 
            this.weatherDesciptionLabel.AutoSize = true;
            this.weatherDesciptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherDesciptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherDesciptionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.weatherDesciptionLabel.Location = new System.Drawing.Point(532, 303);
            this.weatherDesciptionLabel.Name = "weatherDesciptionLabel";
            this.weatherDesciptionLabel.Size = new System.Drawing.Size(74, 20);
            this.weatherDesciptionLabel.TabIndex = 25;
            this.weatherDesciptionLabel.Text = "Weather:";
            // 
            // longLabel
            // 
            this.longLabel.AutoSize = true;
            this.longLabel.BackColor = System.Drawing.Color.Transparent;
            this.longLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.longLabel.Location = new System.Drawing.Point(44, 403);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(75, 20);
            this.longLabel.TabIndex = 24;
            this.longLabel.Text = "Longitud:";
            // 
            // currencySymbolLabel
            // 
            this.currencySymbolLabel.AutoSize = true;
            this.currencySymbolLabel.BackColor = System.Drawing.Color.Transparent;
            this.currencySymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySymbolLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currencySymbolLabel.Location = new System.Drawing.Point(44, 383);
            this.currencySymbolLabel.Name = "currencySymbolLabel";
            this.currencySymbolLabel.Size = new System.Drawing.Size(132, 20);
            this.currencySymbolLabel.TabIndex = 23;
            this.currencySymbolLabel.Text = "Currency Symbol:";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.BackColor = System.Drawing.Color.Transparent;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currencyLabel.Location = new System.Drawing.Point(44, 363);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(76, 20);
            this.currencyLabel.TabIndex = 22;
            this.currencyLabel.Text = "Currency:";
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.AutoSize = true;
            this.localTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.localTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.localTimeLabel.Location = new System.Drawing.Point(532, 423);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.localTimeLabel.TabIndex = 21;
            this.localTimeLabel.Text = "Date/Time:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.humidityLabel.Location = new System.Drawing.Point(532, 403);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(74, 20);
            this.humidityLabel.TabIndex = 20;
            this.humidityLabel.Text = "Humidity:";
            // 
            // WeatherPanelVal
            // 
            this.WeatherPanelVal.BackColor = System.Drawing.Color.Transparent;
            this.WeatherPanelVal.Controls.Add(this.weatherDesciptionLabelVal);
            this.WeatherPanelVal.Controls.Add(this.humidityLabelVal);
            this.WeatherPanelVal.Controls.Add(this.minTempLabelVal);
            this.WeatherPanelVal.Controls.Add(this.maxTempLabelVal);
            this.WeatherPanelVal.Controls.Add(this.localTimeLabelVal);
            this.WeatherPanelVal.Controls.Add(this.tempLabelVal);
            this.WeatherPanelVal.Controls.Add(this.feelsLikeLabelVal);
            this.WeatherPanelVal.Location = new System.Drawing.Point(650, 303);
            this.WeatherPanelVal.Name = "WeatherPanelVal";
            this.WeatherPanelVal.Size = new System.Drawing.Size(162, 144);
            this.WeatherPanelVal.TabIndex = 17;
            // 
            // weatherDesciptionLabelVal
            // 
            this.weatherDesciptionLabelVal.AutoSize = true;
            this.weatherDesciptionLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherDesciptionLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.weatherDesciptionLabelVal.Location = new System.Drawing.Point(3, -1);
            this.weatherDesciptionLabelVal.Name = "weatherDesciptionLabelVal";
            this.weatherDesciptionLabelVal.Size = new System.Drawing.Size(31, 20);
            this.weatherDesciptionLabelVal.TabIndex = 15;
            this.weatherDesciptionLabelVal.Text = "n/a";
            this.weatherDesciptionLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // humidityLabelVal
            // 
            this.humidityLabelVal.AutoSize = true;
            this.humidityLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.humidityLabelVal.Location = new System.Drawing.Point(3, 99);
            this.humidityLabelVal.Name = "humidityLabelVal";
            this.humidityLabelVal.Size = new System.Drawing.Size(31, 20);
            this.humidityLabelVal.TabIndex = 10;
            this.humidityLabelVal.Text = "n/a";
            this.humidityLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minTempLabelVal
            // 
            this.minTempLabelVal.AutoSize = true;
            this.minTempLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.minTempLabelVal.Location = new System.Drawing.Point(3, 79);
            this.minTempLabelVal.Name = "minTempLabelVal";
            this.minTempLabelVal.Size = new System.Drawing.Size(31, 20);
            this.minTempLabelVal.TabIndex = 14;
            this.minTempLabelVal.Text = "n/a";
            this.minTempLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxTempLabelVal
            // 
            this.maxTempLabelVal.AutoSize = true;
            this.maxTempLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.maxTempLabelVal.Location = new System.Drawing.Point(3, 59);
            this.maxTempLabelVal.Name = "maxTempLabelVal";
            this.maxTempLabelVal.Size = new System.Drawing.Size(31, 20);
            this.maxTempLabelVal.TabIndex = 14;
            this.maxTempLabelVal.Text = "n/a";
            this.maxTempLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // localTimeLabelVal
            // 
            this.localTimeLabelVal.AutoSize = true;
            this.localTimeLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTimeLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.localTimeLabelVal.Location = new System.Drawing.Point(3, 119);
            this.localTimeLabelVal.Name = "localTimeLabelVal";
            this.localTimeLabelVal.Size = new System.Drawing.Size(31, 20);
            this.localTimeLabelVal.TabIndex = 11;
            this.localTimeLabelVal.Text = "n/a";
            this.localTimeLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempLabelVal
            // 
            this.tempLabelVal.AutoSize = true;
            this.tempLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.tempLabelVal.Location = new System.Drawing.Point(3, 20);
            this.tempLabelVal.Name = "tempLabelVal";
            this.tempLabelVal.Size = new System.Drawing.Size(31, 20);
            this.tempLabelVal.TabIndex = 12;
            this.tempLabelVal.Text = "n/a";
            this.tempLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feelsLikeLabelVal
            // 
            this.feelsLikeLabelVal.AutoSize = true;
            this.feelsLikeLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.feelsLikeLabelVal.Location = new System.Drawing.Point(3, 40);
            this.feelsLikeLabelVal.Name = "feelsLikeLabelVal";
            this.feelsLikeLabelVal.Size = new System.Drawing.Size(31, 20);
            this.feelsLikeLabelVal.TabIndex = 13;
            this.feelsLikeLabelVal.Text = "n/a";
            this.feelsLikeLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.countryDisplayNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 49);
            this.panel4.TabIndex = 19;
            // 
            // countryDisplayNameLabel
            // 
            this.countryDisplayNameLabel.AllowDrop = true;
            this.countryDisplayNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryDisplayNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.countryDisplayNameLabel.Location = new System.Drawing.Point(0, 0);
            this.countryDisplayNameLabel.Name = "countryDisplayNameLabel";
            this.countryDisplayNameLabel.Size = new System.Drawing.Size(834, 49);
            this.countryDisplayNameLabel.TabIndex = 18;
            this.countryDisplayNameLabel.Text = "n/a";
            this.countryDisplayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.latLabelVal);
            this.panel3.Controls.Add(this.longLabelVal);
            this.panel3.Controls.Add(this.ipLabelVal);
            this.panel3.Controls.Add(this.countryLabelVal);
            this.panel3.Controls.Add(this.cityLabelVal);
            this.panel3.Controls.Add(this.currencySymbolLabelVal);
            this.panel3.Controls.Add(this.currencyLabelVal);
            this.panel3.Location = new System.Drawing.Point(178, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 144);
            this.panel3.TabIndex = 16;
            // 
            // latLabelVal
            // 
            this.latLabelVal.AutoSize = true;
            this.latLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.latLabelVal.Location = new System.Drawing.Point(3, 119);
            this.latLabelVal.Name = "latLabelVal";
            this.latLabelVal.Size = new System.Drawing.Size(31, 20);
            this.latLabelVal.TabIndex = 17;
            this.latLabelVal.Text = "n/a";
            this.latLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // longLabelVal
            // 
            this.longLabelVal.AutoSize = true;
            this.longLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.longLabelVal.Location = new System.Drawing.Point(3, 100);
            this.longLabelVal.Name = "longLabelVal";
            this.longLabelVal.Size = new System.Drawing.Size(31, 20);
            this.longLabelVal.TabIndex = 16;
            this.longLabelVal.Text = "n/a";
            this.longLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipLabelVal
            // 
            this.ipLabelVal.AutoSize = true;
            this.ipLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.ipLabelVal.Location = new System.Drawing.Point(3, -1);
            this.ipLabelVal.Name = "ipLabelVal";
            this.ipLabelVal.Size = new System.Drawing.Size(31, 20);
            this.ipLabelVal.TabIndex = 15;
            this.ipLabelVal.Text = "n/a";
            this.ipLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countryLabelVal
            // 
            this.countryLabelVal.AutoSize = true;
            this.countryLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.countryLabelVal.Location = new System.Drawing.Point(3, 19);
            this.countryLabelVal.Name = "countryLabelVal";
            this.countryLabelVal.Size = new System.Drawing.Size(31, 20);
            this.countryLabelVal.TabIndex = 10;
            this.countryLabelVal.Text = "n/a";
            this.countryLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityLabelVal
            // 
            this.cityLabelVal.AutoSize = true;
            this.cityLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.cityLabelVal.Location = new System.Drawing.Point(3, 39);
            this.cityLabelVal.Name = "cityLabelVal";
            this.cityLabelVal.Size = new System.Drawing.Size(31, 20);
            this.cityLabelVal.TabIndex = 11;
            this.cityLabelVal.Text = "n/a";
            this.cityLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currencySymbolLabelVal
            // 
            this.currencySymbolLabelVal.AutoSize = true;
            this.currencySymbolLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySymbolLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.currencySymbolLabelVal.Location = new System.Drawing.Point(3, 80);
            this.currencySymbolLabelVal.Name = "currencySymbolLabelVal";
            this.currencySymbolLabelVal.Size = new System.Drawing.Size(31, 20);
            this.currencySymbolLabelVal.TabIndex = 13;
            this.currencySymbolLabelVal.Text = "n/a";
            this.currencySymbolLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currencyLabelVal
            // 
            this.currencyLabelVal.AutoSize = true;
            this.currencyLabelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabelVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.currencyLabelVal.Location = new System.Drawing.Point(3, 60);
            this.currencyLabelVal.Name = "currencyLabelVal";
            this.currencyLabelVal.Size = new System.Drawing.Size(31, 20);
            this.currencyLabelVal.TabIndex = 12;
            this.currencyLabelVal.Text = "n/a";
            this.currencyLabelVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ipLabel.Location = new System.Drawing.Point(44, 303);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(74, 20);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "Public IP:";
            // 
            // minTempLabel
            // 
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.minTempLabel.Location = new System.Drawing.Point(532, 383);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(78, 20);
            this.minTempLabel.TabIndex = 8;
            this.minTempLabel.Text = "Min temp:";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.maxTempLabel.Location = new System.Drawing.Point(532, 362);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(82, 20);
            this.maxTempLabel.TabIndex = 7;
            this.maxTempLabel.Text = "Max temp:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tempLabel.Location = new System.Drawing.Point(532, 323);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(53, 20);
            this.tempLabel.TabIndex = 6;
            this.tempLabel.Text = "Temp:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.cityLabel.Location = new System.Drawing.Point(44, 343);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 20);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.countryLabel.Location = new System.Drawing.Point(44, 323);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(110, 20);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country Code:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // localClockTimer
            // 
            this.localClockTimer.Interval = 1000;
            this.localClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 574);
            this.Controls.Add(this.pnlPicViewer);
            this.Controls.Add(this.m);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Photo Shower";
            this.TransparencyKey = System.Drawing.Color.MediumBlue;
            this.panelSide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.m.ResumeLayout(false);
            this.ipPanel.ResumeLayout(false);
            this.ipPanel.PerformLayout();
            this.pnlPicViewer.ResumeLayout(false);
            this.funnyPanel.ResumeLayout(false);
            this.funnyPanel.PerformLayout();
            this.infoPane.ResumeLayout(false);
            this.infoPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).EndInit();
            this.WeatherPanelVal.ResumeLayout(false);
            this.WeatherPanelVal.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button allPhotosBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel m;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button locationInfoBtn;
        private System.Windows.Forms.Button funnyPicsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPicViewer;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer localClockTimer;
        private System.Windows.Forms.Panel infoPane;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label weatherDesciptionLabel;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label currencySymbolLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label localTimeLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Panel WeatherPanelVal;
        private System.Windows.Forms.Label weatherDesciptionLabelVal;
        private System.Windows.Forms.Label humidityLabelVal;
        private System.Windows.Forms.Label minTempLabelVal;
        private System.Windows.Forms.Label maxTempLabelVal;
        private System.Windows.Forms.Label localTimeLabelVal;
        private System.Windows.Forms.Label tempLabelVal;
        private System.Windows.Forms.Label feelsLikeLabelVal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label countryDisplayNameLabel;
        private System.Windows.Forms.PictureBox flagPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label latLabelVal;
        private System.Windows.Forms.Label longLabelVal;
        private System.Windows.Forms.Label ipLabelVal;
        private System.Windows.Forms.Label countryLabelVal;
        private System.Windows.Forms.Label cityLabelVal;
        private System.Windows.Forms.Label currencySymbolLabelVal;
        private System.Windows.Forms.Label currencyLabelVal;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel ipPanel;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Panel funnyPanel;
        private System.Windows.Forms.Label labelFunny;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Button getMyIpBtn;
        private System.Windows.Forms.Label label2;
    }
}

