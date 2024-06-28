namespace EmailApp
{
    partial class TableInputDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnsTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AutoSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.FixedRadioButton = new System.Windows.Forms.RadioButton();
            this.FixedColumnWidthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "行：";
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RowsTextBox.Location = new System.Drawing.Point(98, 50);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(100, 27);
            this.RowsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "列：";
            // 
            // ColumnsTextBox
            // 
            this.ColumnsTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColumnsTextBox.Location = new System.Drawing.Point(98, 101);
            this.ColumnsTextBox.Name = "ColumnsTextBox";
            this.ColumnsTextBox.Size = new System.Drawing.Size(100, 27);
            this.ColumnsTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.Location = new System.Drawing.Point(123, 219);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 33);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OkButton.Location = new System.Drawing.Point(259, 219);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 33);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "确定";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AutoSizeRadioButton
            // 
            this.AutoSizeRadioButton.AutoSize = true;
            this.AutoSizeRadioButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoSizeRadioButton.Location = new System.Drawing.Point(259, 49);
            this.AutoSizeRadioButton.Name = "AutoSizeRadioButton";
            this.AutoSizeRadioButton.Size = new System.Drawing.Size(124, 28);
            this.AutoSizeRadioButton.TabIndex = 6;
            this.AutoSizeRadioButton.Text = "自动列宽";
            this.AutoSizeRadioButton.UseVisualStyleBackColor = true;
            this.AutoSizeRadioButton.CheckedChanged += new System.EventHandler(this.autoSizeRadioButton_CheckedChanged);
            // 
            // FixedRadioButton
            // 
            this.FixedRadioButton.AutoSize = true;
            this.FixedRadioButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FixedRadioButton.Location = new System.Drawing.Point(259, 100);
            this.FixedRadioButton.Name = "FixedRadioButton";
            this.FixedRadioButton.Size = new System.Drawing.Size(124, 28);
            this.FixedRadioButton.TabIndex = 7;
            this.FixedRadioButton.Text = "固定列宽";
            this.FixedRadioButton.UseVisualStyleBackColor = true;
            this.FixedRadioButton.CheckedChanged += new System.EventHandler(this.fixedRadioButton_CheckedChanged);
            // 
            // FixedColumnWidthTextBox
            // 
            this.FixedColumnWidthTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FixedColumnWidthTextBox.Location = new System.Drawing.Point(259, 134);
            this.FixedColumnWidthTextBox.Name = "FixedColumnWidthTextBox";
            this.FixedColumnWidthTextBox.Size = new System.Drawing.Size(100, 27);
            this.FixedColumnWidthTextBox.TabIndex = 9;
            // 
            // TableInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 292);
            this.Controls.Add(this.FixedColumnWidthTextBox);
            this.Controls.Add(this.FixedRadioButton);
            this.Controls.Add(this.AutoSizeRadioButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ColumnsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RowsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TableInputDialog";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColumnsTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton AutoSizeRadioButton;
        private System.Windows.Forms.RadioButton FixedRadioButton;
        private System.Windows.Forms.TextBox FixedColumnWidthTextBox;
    }
}