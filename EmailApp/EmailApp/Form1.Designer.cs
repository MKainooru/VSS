namespace EmailApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bodyBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mailService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.themeBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.Bold = new System.Windows.Forms.Button();
            this.Italic = new System.Windows.Forms.Button();
            this.UnderLine = new System.Windows.Forms.Button();
            this.StrikeLine = new System.Windows.Forms.Button();
            this.LeftAlign = new System.Windows.Forms.Button();
            this.CenterAlign = new System.Windows.Forms.Button();
            this.RightAlign = new System.Windows.Forms.Button();
            this.FontColor = new System.Windows.Forms.Button();
            this.InsertImage = new System.Windows.Forms.Button();
            this.inputFile = new System.Windows.Forms.Button();
            this.insertTable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bodyBox);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 598);
            this.panel2.TabIndex = 1;
            // 
            // bodyBox
            // 
            this.bodyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bodyBox.Location = new System.Drawing.Point(0, 0);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(1488, 598);
            this.bodyBox.TabIndex = 0;
            this.bodyBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mailService);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.passwordBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sendBox);
            this.panel3.Location = new System.Drawing.Point(12, 765);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 50);
            this.panel3.TabIndex = 2;
            // 
            // mailService
            // 
            this.mailService.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mailService.FormattingEnabled = true;
            this.mailService.Items.AddRange(new object[] {
            "QQ邮箱",
            "网易邮箱",
            "谷歌邮箱"});
            this.mailService.Location = new System.Drawing.Point(851, 7);
            this.mailService.Name = "mailService";
            this.mailService.Size = new System.Drawing.Size(121, 32);
            this.mailService.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(788, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "服务:";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordBox.Location = new System.Drawing.Point(486, 3);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(287, 44);
            this.passwordBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "发件人:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(436, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码:";
            // 
            // sendBox
            // 
            this.sendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendBox.Location = new System.Drawing.Point(85, 3);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(345, 44);
            this.sendBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendButton.Location = new System.Drawing.Point(1399, 805);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 51);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "发送";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.receiveBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 3;
            // 
            // receiveBox
            // 
            this.receiveBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiveBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receiveBox.Location = new System.Drawing.Point(85, 3);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.Size = new System.Drawing.Size(688, 44);
            this.receiveBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.themeBox);
            this.panel4.Location = new System.Drawing.Point(97, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1403, 41);
            this.panel4.TabIndex = 4;
            // 
            // themeBox
            // 
            this.themeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.themeBox.Location = new System.Drawing.Point(0, 0);
            this.themeBox.Multiline = true;
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(1403, 41);
            this.themeBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 821);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 35);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "添加附件";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // filePath
            // 
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Location = new System.Drawing.Point(97, 821);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(395, 35);
            this.filePath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "主题:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FontSize);
            this.flowLayoutPanel1.Controls.Add(this.Bold);
            this.flowLayoutPanel1.Controls.Add(this.Italic);
            this.flowLayoutPanel1.Controls.Add(this.UnderLine);
            this.flowLayoutPanel1.Controls.Add(this.StrikeLine);
            this.flowLayoutPanel1.Controls.Add(this.LeftAlign);
            this.flowLayoutPanel1.Controls.Add(this.CenterAlign);
            this.flowLayoutPanel1.Controls.Add(this.RightAlign);
            this.flowLayoutPanel1.Controls.Add(this.FontColor);
            this.flowLayoutPanel1.Controls.Add(this.InsertImage);
            this.flowLayoutPanel1.Controls.Add(this.inputFile);
            this.flowLayoutPanel1.Controls.Add(this.insertTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1488, 40);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // FontSize
            // 
            this.FontSize.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.FontSize.Location = new System.Drawing.Point(3, 3);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(80, 32);
            this.FontSize.TabIndex = 0;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // Bold
            // 
            this.Bold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Bold.AutoSize = true;
            this.Bold.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bold.Location = new System.Drawing.Point(89, 3);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(51, 34);
            this.Bold.TabIndex = 1;
            this.Bold.Text = "B";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // Italic
            // 
            this.Italic.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Italic.Location = new System.Drawing.Point(146, 3);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(51, 34);
            this.Italic.TabIndex = 2;
            this.Italic.Text = "I";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // UnderLine
            // 
            this.UnderLine.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UnderLine.Location = new System.Drawing.Point(203, 3);
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(51, 34);
            this.UnderLine.TabIndex = 3;
            this.UnderLine.Text = "U";
            this.UnderLine.UseVisualStyleBackColor = true;
            this.UnderLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // StrikeLine
            // 
            this.StrikeLine.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StrikeLine.Location = new System.Drawing.Point(260, 3);
            this.StrikeLine.Name = "StrikeLine";
            this.StrikeLine.Size = new System.Drawing.Size(51, 34);
            this.StrikeLine.TabIndex = 4;
            this.StrikeLine.Text = "ABC";
            this.StrikeLine.UseVisualStyleBackColor = true;
            this.StrikeLine.Click += new System.EventHandler(this.strikeLine_Click);
            // 
            // LeftAlign
            // 
            this.LeftAlign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftAlign.BackgroundImage")));
            this.LeftAlign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftAlign.Location = new System.Drawing.Point(317, 3);
            this.LeftAlign.Name = "LeftAlign";
            this.LeftAlign.Size = new System.Drawing.Size(51, 34);
            this.LeftAlign.TabIndex = 5;
            this.LeftAlign.UseVisualStyleBackColor = true;
            this.LeftAlign.Click += new System.EventHandler(this.LeftAlign_Click);
            // 
            // CenterAlign
            // 
            this.CenterAlign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenterAlign.BackgroundImage")));
            this.CenterAlign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CenterAlign.Location = new System.Drawing.Point(374, 3);
            this.CenterAlign.Name = "CenterAlign";
            this.CenterAlign.Size = new System.Drawing.Size(51, 34);
            this.CenterAlign.TabIndex = 6;
            this.CenterAlign.UseVisualStyleBackColor = true;
            this.CenterAlign.Click += new System.EventHandler(this.CenterAlign_Click);
            // 
            // RightAlign
            // 
            this.RightAlign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightAlign.BackgroundImage")));
            this.RightAlign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightAlign.Location = new System.Drawing.Point(431, 3);
            this.RightAlign.Name = "RightAlign";
            this.RightAlign.Size = new System.Drawing.Size(51, 34);
            this.RightAlign.TabIndex = 7;
            this.RightAlign.UseVisualStyleBackColor = true;
            this.RightAlign.Click += new System.EventHandler(this.RightAlign_Click);
            // 
            // FontColor
            // 
            this.FontColor.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FontColor.ForeColor = System.Drawing.Color.Red;
            this.FontColor.Location = new System.Drawing.Point(488, 3);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(51, 34);
            this.FontColor.TabIndex = 8;
            this.FontColor.Text = "A";
            this.FontColor.UseVisualStyleBackColor = true;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // InsertImage
            // 
            this.InsertImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertImage.BackgroundImage")));
            this.InsertImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertImage.Location = new System.Drawing.Point(545, 3);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(51, 34);
            this.InsertImage.TabIndex = 9;
            this.InsertImage.UseVisualStyleBackColor = true;
            this.InsertImage.Click += new System.EventHandler(this.InsertImage_Click);
            // 
            // inputFile
            // 
            this.inputFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputFile.BackgroundImage")));
            this.inputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inputFile.Location = new System.Drawing.Point(602, 3);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(51, 34);
            this.inputFile.TabIndex = 10;
            this.inputFile.UseVisualStyleBackColor = true;
            this.inputFile.Click += new System.EventHandler(this.inputFile_Click);
            // 
            // insertTable
            // 
            this.insertTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insertTable.BackgroundImage")));
            this.insertTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.insertTable.Location = new System.Drawing.Point(659, 3);
            this.insertTable.Name = "insertTable";
            this.insertTable.Size = new System.Drawing.Size(51, 34);
            this.insertTable.TabIndex = 11;
            this.insertTable.UseVisualStyleBackColor = true;
            this.insertTable.Click += new System.EventHandler(this.insertTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 868);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "邮箱";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox themeBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox bodyBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.Button Bold;
        private System.Windows.Forms.Button Italic;
        private System.Windows.Forms.Button UnderLine;
        private System.Windows.Forms.Button StrikeLine;
        private System.Windows.Forms.Button LeftAlign;
        private System.Windows.Forms.Button CenterAlign;
        private System.Windows.Forms.Button RightAlign;
        private System.Windows.Forms.Button FontColor;
        private System.Windows.Forms.Button InsertImage;
        private System.Windows.Forms.Button inputFile;
        private System.Windows.Forms.Button insertTable;
        private System.Windows.Forms.ComboBox mailService;
        private System.Windows.Forms.Label label5;
    }
}

