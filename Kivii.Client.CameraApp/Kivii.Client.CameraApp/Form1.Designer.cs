namespace Kivii.Client.CameraApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.palInformationDisplay = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxServiceUrl = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.lblSpecificationsShow = new System.Windows.Forms.Label();
            this.lblEntrustedUnitShow = new System.Windows.Forms.Label();
            this.lblSampleNameShow = new System.Windows.Forms.Label();
            this.lblSpecifications = new System.Windows.Forms.Label();
            this.lblEntrustedUnit = new System.Windows.Forms.Label();
            this.lblSampleName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxSampleCode = new System.Windows.Forms.TextBox();
            this.lblSampleCode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblCameraNameShow = new System.Windows.Forms.Label();
            this.lblCameraName = new System.Windows.Forms.Label();
            this.vspPreview = new Kivii.Client.CameraApp.Controls.VideoSourcePlayer();
            this.palPhotosDisplay = new System.Windows.Forms.Panel();
            this.lblPhotosTaken = new System.Windows.Forms.Label();
            this.palUpload = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.flpPhotosTaken = new System.Windows.Forms.FlowLayoutPanel();
            this.palPhotoDisplay = new System.Windows.Forms.Panel();
            this.ptbPhotoDisplay = new System.Windows.Forms.PictureBox();
            this.palTack = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.palInformationDisplay.SuspendLayout();
            this.palPhotosDisplay.SuspendLayout();
            this.palUpload.SuspendLayout();
            this.palPhotoDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhotoDisplay)).BeginInit();
            this.palTack.SuspendLayout();
            this.SuspendLayout();
            // 
            // palInformationDisplay
            // 
            this.palInformationDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.palInformationDisplay.Controls.Add(this.btnLogout);
            this.palInformationDisplay.Controls.Add(this.btnLogin);
            this.palInformationDisplay.Controls.Add(this.tbxPassword);
            this.palInformationDisplay.Controls.Add(this.tbxUserName);
            this.palInformationDisplay.Controls.Add(this.tbxServiceUrl);
            this.palInformationDisplay.Controls.Add(this.lblPassword);
            this.palInformationDisplay.Controls.Add(this.lblUser);
            this.palInformationDisplay.Controls.Add(this.lblUrl);
            this.palInformationDisplay.Controls.Add(this.lblResolution);
            this.palInformationDisplay.Controls.Add(this.cmbResolution);
            this.palInformationDisplay.Controls.Add(this.lblSpecificationsShow);
            this.palInformationDisplay.Controls.Add(this.lblEntrustedUnitShow);
            this.palInformationDisplay.Controls.Add(this.lblSampleNameShow);
            this.palInformationDisplay.Controls.Add(this.lblSpecifications);
            this.palInformationDisplay.Controls.Add(this.lblEntrustedUnit);
            this.palInformationDisplay.Controls.Add(this.lblSampleName);
            this.palInformationDisplay.Controls.Add(this.btnConfirm);
            this.palInformationDisplay.Controls.Add(this.tbxSampleCode);
            this.palInformationDisplay.Controls.Add(this.lblSampleCode);
            this.palInformationDisplay.Controls.Add(this.btnClose);
            this.palInformationDisplay.Controls.Add(this.btnSwitch);
            this.palInformationDisplay.Controls.Add(this.lblCameraNameShow);
            this.palInformationDisplay.Controls.Add(this.lblCameraName);
            this.palInformationDisplay.Controls.Add(this.vspPreview);
            this.palInformationDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.palInformationDisplay.Location = new System.Drawing.Point(0, 0);
            this.palInformationDisplay.Name = "palInformationDisplay";
            this.palInformationDisplay.Size = new System.Drawing.Size(271, 781);
            this.palInformationDisplay.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogout.Location = new System.Drawing.Point(159, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 50);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "退出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(7, 631);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 50);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxPassword.Location = new System.Drawing.Point(82, 595);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(177, 30);
            this.tbxPassword.TabIndex = 22;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxUserName.Location = new System.Drawing.Point(82, 559);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(177, 30);
            this.tbxUserName.TabIndex = 21;
            // 
            // tbxServiceUrl
            // 
            this.tbxServiceUrl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxServiceUrl.Location = new System.Drawing.Point(82, 523);
            this.tbxServiceUrl.Name = "tbxServiceUrl";
            this.tbxServiceUrl.Size = new System.Drawing.Size(177, 30);
            this.tbxServiceUrl.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.Location = new System.Drawing.Point(3, 598);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPassword.Size = new System.Drawing.Size(79, 25);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "密  码:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Location = new System.Drawing.Point(3, 562);
            this.lblUser.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUser.Size = new System.Drawing.Size(79, 25);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "用户名:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUrl.Location = new System.Drawing.Point(3, 526);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUrl.Size = new System.Drawing.Size(79, 25);
            this.lblUrl.TabIndex = 17;
            this.lblUrl.Text = "服务器:";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResolution.Location = new System.Drawing.Point(4, 328);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(95, 16);
            this.lblResolution.TabIndex = 16;
            this.lblResolution.Text = "相机分辨率:";
            // 
            // cmbResolution
            // 
            this.cmbResolution.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(7, 347);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(255, 28);
            this.cmbResolution.TabIndex = 15;
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // lblSpecificationsShow
            // 
            this.lblSpecificationsShow.AutoSize = true;
            this.lblSpecificationsShow.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpecificationsShow.Location = new System.Drawing.Point(105, 504);
            this.lblSpecificationsShow.Name = "lblSpecificationsShow";
            this.lblSpecificationsShow.Size = new System.Drawing.Size(154, 14);
            this.lblSpecificationsShow.TabIndex = 14;
            this.lblSpecificationsShow.Text = "_____________________";
            // 
            // lblEntrustedUnitShow
            // 
            this.lblEntrustedUnitShow.AutoSize = true;
            this.lblEntrustedUnitShow.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEntrustedUnitShow.Location = new System.Drawing.Point(105, 474);
            this.lblEntrustedUnitShow.Name = "lblEntrustedUnitShow";
            this.lblEntrustedUnitShow.Size = new System.Drawing.Size(154, 14);
            this.lblEntrustedUnitShow.TabIndex = 13;
            this.lblEntrustedUnitShow.Text = "_____________________";
            // 
            // lblSampleNameShow
            // 
            this.lblSampleNameShow.AutoSize = true;
            this.lblSampleNameShow.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSampleNameShow.Location = new System.Drawing.Point(105, 444);
            this.lblSampleNameShow.Name = "lblSampleNameShow";
            this.lblSampleNameShow.Size = new System.Drawing.Size(154, 14);
            this.lblSampleNameShow.TabIndex = 12;
            this.lblSampleNameShow.Text = "_____________________";
            // 
            // lblSpecifications
            // 
            this.lblSpecifications.AutoSize = true;
            this.lblSpecifications.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpecifications.Location = new System.Drawing.Point(3, 493);
            this.lblSpecifications.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblSpecifications.Name = "lblSpecifications";
            this.lblSpecifications.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSpecifications.Size = new System.Drawing.Size(99, 25);
            this.lblSpecifications.TabIndex = 10;
            this.lblSpecifications.Text = "规格型号:";
            // 
            // lblEntrustedUnit
            // 
            this.lblEntrustedUnit.AutoSize = true;
            this.lblEntrustedUnit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEntrustedUnit.Location = new System.Drawing.Point(3, 463);
            this.lblEntrustedUnit.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblEntrustedUnit.Name = "lblEntrustedUnit";
            this.lblEntrustedUnit.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblEntrustedUnit.Size = new System.Drawing.Size(99, 25);
            this.lblEntrustedUnit.TabIndex = 9;
            this.lblEntrustedUnit.Text = "委托单位:";
            // 
            // lblSampleName
            // 
            this.lblSampleName.AutoSize = true;
            this.lblSampleName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSampleName.Location = new System.Drawing.Point(3, 433);
            this.lblSampleName.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblSampleName.Name = "lblSampleName";
            this.lblSampleName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblSampleName.Size = new System.Drawing.Size(99, 25);
            this.lblSampleName.TabIndex = 8;
            this.lblSampleName.Text = "样品名称:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(201, 397);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(61, 35);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // tbxSampleCode
            // 
            this.tbxSampleCode.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSampleCode.Location = new System.Drawing.Point(7, 397);
            this.tbxSampleCode.Multiline = true;
            this.tbxSampleCode.Name = "tbxSampleCode";
            this.tbxSampleCode.Size = new System.Drawing.Size(188, 35);
            this.tbxSampleCode.TabIndex = 6;
            // 
            // lblSampleCode
            // 
            this.lblSampleCode.AutoSize = true;
            this.lblSampleCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSampleCode.Location = new System.Drawing.Point(4, 378);
            this.lblSampleCode.Name = "lblSampleCode";
            this.lblSampleCode.Size = new System.Drawing.Size(79, 16);
            this.lblSampleCode.TabIndex = 5;
            this.lblSampleCode.Text = "样品编码:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(162, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwitch.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.Location = new System.Drawing.Point(7, 272);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(100, 50);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "切换";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.butSwitch_Click);
            // 
            // lblCameraNameShow
            // 
            this.lblCameraNameShow.AutoSize = true;
            this.lblCameraNameShow.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCameraNameShow.Location = new System.Drawing.Point(108, 246);
            this.lblCameraNameShow.Name = "lblCameraNameShow";
            this.lblCameraNameShow.Size = new System.Drawing.Size(154, 14);
            this.lblCameraNameShow.TabIndex = 2;
            this.lblCameraNameShow.Text = "_____________________";
            // 
            // lblCameraName
            // 
            this.lblCameraName.AutoSize = true;
            this.lblCameraName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCameraName.Location = new System.Drawing.Point(3, 240);
            this.lblCameraName.Name = "lblCameraName";
            this.lblCameraName.Size = new System.Drawing.Size(99, 20);
            this.lblCameraName.TabIndex = 1;
            this.lblCameraName.Text = "当前相机:";
            // 
            // vspPreview
            // 
            this.vspPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vspPreview.Location = new System.Drawing.Point(5, 0);
            this.vspPreview.Name = "vspPreview";
            this.vspPreview.Size = new System.Drawing.Size(260, 232);
            this.vspPreview.TabIndex = 0;
            this.vspPreview.Text = "videoSourcePlayer1";
            this.vspPreview.VideoSource = null;
            // 
            // palPhotosDisplay
            // 
            this.palPhotosDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.palPhotosDisplay.Controls.Add(this.lblPhotosTaken);
            this.palPhotosDisplay.Controls.Add(this.palUpload);
            this.palPhotosDisplay.Controls.Add(this.flpPhotosTaken);
            this.palPhotosDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.palPhotosDisplay.Location = new System.Drawing.Point(957, 0);
            this.palPhotosDisplay.Name = "palPhotosDisplay";
            this.palPhotosDisplay.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.palPhotosDisplay.Size = new System.Drawing.Size(249, 781);
            this.palPhotosDisplay.TabIndex = 1;
            // 
            // lblPhotosTaken
            // 
            this.lblPhotosTaken.AutoSize = true;
            this.lblPhotosTaken.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhotosTaken.Location = new System.Drawing.Point(9, 4);
            this.lblPhotosTaken.Name = "lblPhotosTaken";
            this.lblPhotosTaken.Size = new System.Drawing.Size(79, 16);
            this.lblPhotosTaken.TabIndex = 2;
            this.lblPhotosTaken.Text = "已拍照片:";
            // 
            // palUpload
            // 
            this.palUpload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.palUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palUpload.Controls.Add(this.btnUpload);
            this.palUpload.Controls.Add(this.chkCompress);
            this.palUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palUpload.Location = new System.Drawing.Point(5, 664);
            this.palUpload.Name = "palUpload";
            this.palUpload.Size = new System.Drawing.Size(239, 112);
            this.palUpload.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpload.Location = new System.Drawing.Point(67, 37);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 49);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkCompress.Location = new System.Drawing.Point(57, 3);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCompress.Size = new System.Drawing.Size(125, 28);
            this.chkCompress.TabIndex = 0;
            this.chkCompress.Text = "图片压缩";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // flpPhotosTaken
            // 
            this.flpPhotosTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPhotosTaken.AutoScroll = true;
            this.flpPhotosTaken.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpPhotosTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPhotosTaken.Location = new System.Drawing.Point(5, 23);
            this.flpPhotosTaken.Margin = new System.Windows.Forms.Padding(0);
            this.flpPhotosTaken.Name = "flpPhotosTaken";
            this.flpPhotosTaken.Size = new System.Drawing.Size(238, 636);
            this.flpPhotosTaken.TabIndex = 0;
            // 
            // palPhotoDisplay
            // 
            this.palPhotoDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.palPhotoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palPhotoDisplay.Controls.Add(this.ptbPhotoDisplay);
            this.palPhotoDisplay.Controls.Add(this.palTack);
            this.palPhotoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palPhotoDisplay.Location = new System.Drawing.Point(271, 0);
            this.palPhotoDisplay.Name = "palPhotoDisplay";
            this.palPhotoDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.palPhotoDisplay.Size = new System.Drawing.Size(686, 781);
            this.palPhotoDisplay.TabIndex = 2;
            // 
            // ptbPhotoDisplay
            // 
            this.ptbPhotoDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbPhotoDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbPhotoDisplay.Location = new System.Drawing.Point(-1, -1);
            this.ptbPhotoDisplay.Name = "ptbPhotoDisplay";
            this.ptbPhotoDisplay.Size = new System.Drawing.Size(686, 659);
            this.ptbPhotoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPhotoDisplay.TabIndex = 1;
            this.ptbPhotoDisplay.TabStop = false;
            // 
            // palTack
            // 
            this.palTack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.palTack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palTack.Controls.Add(this.btnDelete);
            this.palTack.Controls.Add(this.btnTake);
            this.palTack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palTack.Location = new System.Drawing.Point(5, 663);
            this.palTack.Margin = new System.Windows.Forms.Padding(0);
            this.palTack.Name = "palTack";
            this.palTack.Size = new System.Drawing.Size(674, 111);
            this.palTack.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(490, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 61);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTake.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTake.Location = new System.Drawing.Point(45, 32);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(138, 65);
            this.btnTake.TabIndex = 0;
            this.btnTake.Text = "拍照";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.butTake_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1206, 781);
            this.Controls.Add(this.palPhotoDisplay);
            this.Controls.Add(this.palPhotosDisplay);
            this.Controls.Add(this.palInformationDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "MainForm";
            this.Text = "样品拍照客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.palInformationDisplay.ResumeLayout(false);
            this.palInformationDisplay.PerformLayout();
            this.palPhotosDisplay.ResumeLayout(false);
            this.palPhotosDisplay.PerformLayout();
            this.palUpload.ResumeLayout(false);
            this.palUpload.PerformLayout();
            this.palPhotoDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhotoDisplay)).EndInit();
            this.palTack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palInformationDisplay;
        private System.Windows.Forms.Panel palPhotosDisplay;
        private System.Windows.Forms.Panel palPhotoDisplay;
        private System.Windows.Forms.Panel palTack;
        private System.Windows.Forms.Panel palUpload;
        private System.Windows.Forms.FlowLayoutPanel flpPhotosTaken;
        private System.Windows.Forms.PictureBox ptbPhotoDisplay;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.CheckBox chkCompress;
        private System.Windows.Forms.Button btnDelete;
        private Controls.VideoSourcePlayer vspPreview;
        private System.Windows.Forms.Label lblCameraName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblCameraNameShow;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxSampleCode;
        private System.Windows.Forms.Label lblSampleCode;
        private System.Windows.Forms.Label lblSpecificationsShow;
        private System.Windows.Forms.Label lblEntrustedUnitShow;
        private System.Windows.Forms.Label lblSampleNameShow;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblEntrustedUnit;
        private System.Windows.Forms.Label lblSampleName;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblPhotosTaken;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxServiceUrl;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
    }
}

