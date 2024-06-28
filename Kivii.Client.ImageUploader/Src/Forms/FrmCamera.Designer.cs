namespace Kivii.Imaging.Uploader.Forms
{
    partial class FrmCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCamera));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSnap = new System.Windows.Forms.Button();
            this.groupbox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStopRecord = new System.Windows.Forms.Button();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.nudAutoShootTime = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chbOpenCameraCompoundShoot = new System.Windows.Forms.CheckBox();
            this.ChbAutoShoot = new System.Windows.Forms.CheckBox();
            this.chbOpenCameraAutoShootTimer = new System.Windows.Forms.CheckBox();
            this.ChbRectify = new System.Windows.Forms.CheckBox();
            this.chbRemoveGround = new System.Windows.Forms.CheckBox();
            this.chbBarcodeCheck = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnCamearTurnLeft = new System.Windows.Forms.Button();
            this.btnCamearExchangeLeftRight = new System.Windows.Forms.Button();
            this.btnCamearTurnRight = new System.Windows.Forms.Button();
            this.btnCamearExchangeUpDown = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.btnCloseCamera = new System.Windows.Forms.Button();
            this.btnCameraProperty = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSnapResolutions = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbxCameraResolutions = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlImages = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.videoSourcePlayer = new Kivii.Imaging.Uploader.Controls.VideoSourcePlayer();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox7.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoShootTime)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupbox7);
            this.panel1.Controls.Add(this.groupBox15);
            this.panel1.Controls.Add(this.groupBox14);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(687, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel1.Size = new System.Drawing.Size(212, 689);
            this.panel1.TabIndex = 54;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUpload);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(0, 488);
            this.groupBox6.MinimumSize = new System.Drawing.Size(0, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(197, 201);
            this.groupBox6.TabIndex = 108;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "数据上传";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpload.Location = new System.Drawing.Point(5, 19);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(187, 177);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "上传图片";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSnap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 51);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "拍照";
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(10, 16);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(178, 31);
            this.btnSnap.TabIndex = 4;
            this.btnSnap.Text = "拍摄";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // groupbox7
            // 
            this.groupbox7.Controls.Add(this.label1);
            this.groupbox7.Controls.Add(this.btStopRecord);
            this.groupbox7.Controls.Add(this.btnStartRecord);
            this.groupbox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox7.Enabled = false;
            this.groupbox7.Location = new System.Drawing.Point(0, 391);
            this.groupbox7.Name = "groupbox7";
            this.groupbox7.Size = new System.Drawing.Size(197, 46);
            this.groupbox7.TabIndex = 106;
            this.groupbox7.TabStop = false;
            this.groupbox7.Text = "录像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 48;
            // 
            // btStopRecord
            // 
            this.btStopRecord.Location = new System.Drawing.Point(107, 18);
            this.btStopRecord.Name = "btStopRecord";
            this.btStopRecord.Size = new System.Drawing.Size(81, 22);
            this.btStopRecord.TabIndex = 47;
            this.btStopRecord.Text = "停止录像";
            this.btStopRecord.UseVisualStyleBackColor = true;
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(10, 18);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(86, 22);
            this.btnStartRecord.TabIndex = 47;
            this.btnStartRecord.Text = "开始录像";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.nudAutoShootTime);
            this.groupBox15.Controls.Add(this.textBox2);
            this.groupBox15.Controls.Add(this.chbOpenCameraCompoundShoot);
            this.groupBox15.Controls.Add(this.ChbAutoShoot);
            this.groupBox15.Controls.Add(this.chbOpenCameraAutoShootTimer);
            this.groupBox15.Controls.Add(this.ChbRectify);
            this.groupBox15.Controls.Add(this.chbRemoveGround);
            this.groupBox15.Controls.Add(this.chbBarcodeCheck);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(0, 287);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(197, 104);
            this.groupBox15.TabIndex = 105;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "拍摄选项";
            // 
            // nudAutoShootTime
            // 
            this.nudAutoShootTime.Location = new System.Drawing.Point(104, 75);
            this.nudAutoShootTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAutoShootTime.Name = "nudAutoShootTime";
            this.nudAutoShootTime.Size = new System.Drawing.Size(36, 21);
            this.nudAutoShootTime.TabIndex = 28;
            this.nudAutoShootTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(144, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(28, 14);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "秒";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbOpenCameraCompoundShoot
            // 
            this.chbOpenCameraCompoundShoot.AutoSize = true;
            this.chbOpenCameraCompoundShoot.Enabled = false;
            this.chbOpenCameraCompoundShoot.Location = new System.Drawing.Point(107, 36);
            this.chbOpenCameraCompoundShoot.Name = "chbOpenCameraCompoundShoot";
            this.chbOpenCameraCompoundShoot.Size = new System.Drawing.Size(72, 16);
            this.chbOpenCameraCompoundShoot.TabIndex = 20;
            this.chbOpenCameraCompoundShoot.Text = "智能合并";
            this.chbOpenCameraCompoundShoot.UseVisualStyleBackColor = true;
            // 
            // ChbAutoShoot
            // 
            this.ChbAutoShoot.AutoSize = true;
            this.ChbAutoShoot.Enabled = false;
            this.ChbAutoShoot.Location = new System.Drawing.Point(10, 55);
            this.ChbAutoShoot.Name = "ChbAutoShoot";
            this.ChbAutoShoot.Size = new System.Drawing.Size(156, 16);
            this.ChbAutoShoot.TabIndex = 34;
            this.ChbAutoShoot.Text = "检测到图片变化自动拍照";
            this.ChbAutoShoot.UseVisualStyleBackColor = true;
            // 
            // chbOpenCameraAutoShootTimer
            // 
            this.chbOpenCameraAutoShootTimer.AutoSize = true;
            this.chbOpenCameraAutoShootTimer.Enabled = false;
            this.chbOpenCameraAutoShootTimer.Location = new System.Drawing.Point(10, 79);
            this.chbOpenCameraAutoShootTimer.Name = "chbOpenCameraAutoShootTimer";
            this.chbOpenCameraAutoShootTimer.Size = new System.Drawing.Size(72, 16);
            this.chbOpenCameraAutoShootTimer.TabIndex = 17;
            this.chbOpenCameraAutoShootTimer.Text = "定时拍照";
            this.chbOpenCameraAutoShootTimer.UseVisualStyleBackColor = true;
            // 
            // ChbRectify
            // 
            this.ChbRectify.AutoSize = true;
            this.ChbRectify.Location = new System.Drawing.Point(10, 36);
            this.ChbRectify.Name = "ChbRectify";
            this.ChbRectify.Size = new System.Drawing.Size(72, 16);
            this.ChbRectify.TabIndex = 16;
            this.ChbRectify.Text = "纠偏裁边";
            this.ChbRectify.UseVisualStyleBackColor = true;
            this.ChbRectify.CheckedChanged += new System.EventHandler(this.ChbRectify_CheckedChanged);
            // 
            // chbRemoveGround
            // 
            this.chbRemoveGround.AutoSize = true;
            this.chbRemoveGround.Enabled = false;
            this.chbRemoveGround.Location = new System.Drawing.Point(107, 16);
            this.chbRemoveGround.Name = "chbRemoveGround";
            this.chbRemoveGround.Size = new System.Drawing.Size(72, 16);
            this.chbRemoveGround.TabIndex = 16;
            this.chbRemoveGround.Text = "消除底色";
            this.chbRemoveGround.UseVisualStyleBackColor = true;
            // 
            // chbBarcodeCheck
            // 
            this.chbBarcodeCheck.AutoSize = true;
            this.chbBarcodeCheck.Enabled = false;
            this.chbBarcodeCheck.Location = new System.Drawing.Point(10, 16);
            this.chbBarcodeCheck.Name = "chbBarcodeCheck";
            this.chbBarcodeCheck.Size = new System.Drawing.Size(72, 16);
            this.chbBarcodeCheck.TabIndex = 16;
            this.chbBarcodeCheck.Text = "条码识别";
            this.chbBarcodeCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnCamearTurnLeft);
            this.groupBox14.Controls.Add(this.btnCamearExchangeLeftRight);
            this.groupBox14.Controls.Add(this.btnCamearTurnRight);
            this.groupBox14.Controls.Add(this.btnCamearExchangeUpDown);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.Enabled = false;
            this.groupBox14.Location = new System.Drawing.Point(0, 218);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(197, 69);
            this.groupBox14.TabIndex = 103;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "方向调整";
            // 
            // btnCamearTurnLeft
            // 
            this.btnCamearTurnLeft.Location = new System.Drawing.Point(8, 15);
            this.btnCamearTurnLeft.Name = "btnCamearTurnLeft";
            this.btnCamearTurnLeft.Size = new System.Drawing.Size(88, 22);
            this.btnCamearTurnLeft.TabIndex = 30;
            this.btnCamearTurnLeft.Text = "左转";
            this.btnCamearTurnLeft.UseVisualStyleBackColor = true;
            // 
            // btnCamearExchangeLeftRight
            // 
            this.btnCamearExchangeLeftRight.Location = new System.Drawing.Point(8, 39);
            this.btnCamearExchangeLeftRight.Name = "btnCamearExchangeLeftRight";
            this.btnCamearExchangeLeftRight.Size = new System.Drawing.Size(88, 22);
            this.btnCamearExchangeLeftRight.TabIndex = 31;
            this.btnCamearExchangeLeftRight.Text = "左右";
            this.btnCamearExchangeLeftRight.UseVisualStyleBackColor = true;
            // 
            // btnCamearTurnRight
            // 
            this.btnCamearTurnRight.Location = new System.Drawing.Point(107, 14);
            this.btnCamearTurnRight.Name = "btnCamearTurnRight";
            this.btnCamearTurnRight.Size = new System.Drawing.Size(81, 22);
            this.btnCamearTurnRight.TabIndex = 32;
            this.btnCamearTurnRight.Text = "右转";
            this.btnCamearTurnRight.UseVisualStyleBackColor = true;
            // 
            // btnCamearExchangeUpDown
            // 
            this.btnCamearExchangeUpDown.Location = new System.Drawing.Point(107, 40);
            this.btnCamearExchangeUpDown.Name = "btnCamearExchangeUpDown";
            this.btnCamearExchangeUpDown.Size = new System.Drawing.Size(81, 22);
            this.btnCamearExchangeUpDown.TabIndex = 33;
            this.btnCamearExchangeUpDown.Text = "上下";
            this.btnCamearExchangeUpDown.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOpenCamera);
            this.groupBox4.Controls.Add(this.btnCloseCamera);
            this.groupBox4.Controls.Add(this.btnCameraProperty);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 74);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "高拍仪操作";
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(8, 16);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(130, 22);
            this.btnOpenCamera.TabIndex = 0;
            this.btnOpenCamera.Text = "打开视频";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // btnCloseCamera
            // 
            this.btnCloseCamera.Location = new System.Drawing.Point(8, 43);
            this.btnCloseCamera.Name = "btnCloseCamera";
            this.btnCloseCamera.Size = new System.Drawing.Size(130, 22);
            this.btnCloseCamera.TabIndex = 1;
            this.btnCloseCamera.Text = "关闭视频";
            this.btnCloseCamera.UseVisualStyleBackColor = true;
            this.btnCloseCamera.Click += new System.EventHandler(this.btnCloseCamera_Click);
            // 
            // btnCameraProperty
            // 
            this.btnCameraProperty.Location = new System.Drawing.Point(143, 16);
            this.btnCameraProperty.Name = "btnCameraProperty";
            this.btnCameraProperty.Size = new System.Drawing.Size(45, 50);
            this.btnCameraProperty.TabIndex = 5;
            this.btnCameraProperty.Text = "属性";
            this.btnCameraProperty.UseVisualStyleBackColor = true;
            this.btnCameraProperty.Click += new System.EventHandler(this.btnCameraProperty_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSnapResolutions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 48);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采集分辨率：";
            this.groupBox1.Visible = false;
            // 
            // cbxSnapResolutions
            // 
            this.cbxSnapResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSnapResolutions.FormattingEnabled = true;
            this.cbxSnapResolutions.Location = new System.Drawing.Point(8, 20);
            this.cbxSnapResolutions.Name = "cbxSnapResolutions";
            this.cbxSnapResolutions.Size = new System.Drawing.Size(180, 20);
            this.cbxSnapResolutions.TabIndex = 10;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbxCameraResolutions);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Location = new System.Drawing.Point(0, 48);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(197, 48);
            this.groupBox12.TabIndex = 99;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "预览分辨率：";
            // 
            // cbxCameraResolutions
            // 
            this.cbxCameraResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameraResolutions.FormattingEnabled = true;
            this.cbxCameraResolutions.Location = new System.Drawing.Point(8, 20);
            this.cbxCameraResolutions.Name = "cbxCameraResolutions";
            this.cbxCameraResolutions.Size = new System.Drawing.Size(180, 20);
            this.cbxCameraResolutions.TabIndex = 10;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbxCameras);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(197, 48);
            this.groupBox11.TabIndex = 100;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "设备列表：";
            // 
            // cbxCameras
            // 
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(8, 20);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(180, 20);
            this.cbxCameras.TabIndex = 10;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlImages);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 235);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图片上传列表";
            // 
            // pnlImages
            // 
            this.pnlImages.AutoScroll = true;
            this.pnlImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImages.Location = new System.Drawing.Point(3, 17);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Padding = new System.Windows.Forms.Padding(5);
            this.pnlImages.Size = new System.Drawing.Size(681, 215);
            this.pnlImages.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.videoSourcePlayer);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(687, 454);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "视频预览窗口";
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.videoSourcePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.KeepAspectRatio = true;
            this.videoSourcePlayer.Location = new System.Drawing.Point(3, 17);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(681, 434);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // FrmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 699);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmCamera";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "高拍仪图像采集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupbox7.ResumeLayout(false);
            this.groupbox7.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoShootTime)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.GroupBox groupbox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStopRecord;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.NumericUpDown nudAutoShootTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chbOpenCameraCompoundShoot;
        private System.Windows.Forms.CheckBox ChbAutoShoot;
        private System.Windows.Forms.CheckBox chbOpenCameraAutoShootTimer;
        private System.Windows.Forms.CheckBox ChbRectify;
        private System.Windows.Forms.CheckBox chbRemoveGround;
        private System.Windows.Forms.CheckBox chbBarcodeCheck;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btnCamearTurnLeft;
        private System.Windows.Forms.Button btnCamearExchangeLeftRight;
        private System.Windows.Forms.Button btnCamearTurnRight;
        private System.Windows.Forms.Button btnCamearExchangeUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnCloseCamera;
        private System.Windows.Forms.Button btnCameraProperty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCameraResolutions;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox cbxSnapResolutions;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Panel pnlImages;
    }
}