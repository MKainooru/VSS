namespace Kivii.Imaging.Uploader.Controls
{
    partial class PictureBoxEx
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureBoxEx));
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.toolMenuEdit = new System.Windows.Forms.ToolStripButton();
            this.toolMenuTurnLeft = new System.Windows.Forms.ToolStripButton();
            this.toolMenuTurnRight = new System.Windows.Forms.ToolStripButton();
            this.toolMenuDelete = new System.Windows.Forms.ToolStripButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // toolMenu
            // 
            this.toolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolMenu.AutoSize = false;
            this.toolMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuTurnLeft,
            this.toolMenuTurnRight,
            this.toolMenuDelete,
            this.toolMenuEdit});
            this.toolMenu.Location = new System.Drawing.Point(11, 178);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(132, 25);
            this.toolMenu.TabIndex = 0;
            this.toolMenu.Text = "toolStrip1";
            this.toolMenu.Visible = false;
            // 
            // toolMenuEdit
            // 
            this.toolMenuEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMenuEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMenuEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuEdit.Image")));
            this.toolMenuEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMenuEdit.Name = "toolMenuEdit";
            this.toolMenuEdit.Size = new System.Drawing.Size(23, 22);
            this.toolMenuEdit.Text = "编辑当前图片";
            this.toolMenuEdit.Click += new System.EventHandler(this.toolMenuEdit_Click);
            // 
            // toolMenuTurnLeft
            // 
            this.toolMenuTurnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolMenuTurnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMenuTurnLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuTurnLeft.Image")));
            this.toolMenuTurnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMenuTurnLeft.Name = "toolMenuTurnLeft";
            this.toolMenuTurnLeft.Size = new System.Drawing.Size(23, 22);
            this.toolMenuTurnLeft.Text = "图片向左旋转";
            this.toolMenuTurnLeft.Click += new System.EventHandler(this.toolMenuTurnLeft_Click);
            // 
            // toolMenuTurnRight
            // 
            this.toolMenuTurnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMenuTurnRight.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuTurnRight.Image")));
            this.toolMenuTurnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMenuTurnRight.Name = "toolMenuTurnRight";
            this.toolMenuTurnRight.Size = new System.Drawing.Size(23, 22);
            this.toolMenuTurnRight.Text = "图片向右旋转";
            this.toolMenuTurnRight.Click += new System.EventHandler(this.toolMenuTurnRight_Click);
            // 
            // toolMenuDelete
            // 
            this.toolMenuDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMenuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuDelete.Image")));
            this.toolMenuDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMenuDelete.Name = "toolMenuDelete";
            this.toolMenuDelete.Size = new System.Drawing.Size(23, 22);
            this.toolMenuDelete.Text = "toolStripButton4";
            this.toolMenuDelete.ToolTipText = "删除当前图片";
            this.toolMenuDelete.Click += new System.EventHandler(this.toolMenuDelete_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(5, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(142, 203);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // PictureBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.toolMenu);
            this.Controls.Add(this.pic);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PictureBoxEx";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(152, 213);
            this.Enter += new System.EventHandler(this.PictureBoxEx_Enter);
            this.Leave += new System.EventHandler(this.PictureBoxEx_Leave);
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton toolMenuTurnLeft;
        private System.Windows.Forms.ToolStripButton toolMenuTurnRight;
        private System.Windows.Forms.ToolStripButton toolMenuDelete;
        private System.Windows.Forms.ToolStripButton toolMenuEdit;
        private System.Windows.Forms.PictureBox pic;
    }
}
