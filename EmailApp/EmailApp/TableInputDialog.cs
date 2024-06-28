using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailApp
{
    public partial class TableInputDialog : Form
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        private bool autoSize;

        public bool GetAutoSize()
        {
            return autoSize;
        }

        private void SetAutoSize(bool value)
        {
            autoSize = value;
        }

        public int FixedColumnWidth { get; private set; }

        public TableInputDialog()
        {
            InitializeComponent();
            AutoSizeRadioButton.Checked = true;
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // 解析文本框中的行和列
            int.TryParse(RowsTextBox.Text, out int rows);
            int.TryParse(ColumnsTextBox.Text, out int columns);
            int.TryParse(FixedColumnWidthTextBox.Text,out int fixedColumnWidth);

            // 设置行和列属性
            Rows = rows;
            Columns = columns;
            FixedColumnWidth = fixedColumnWidth;
       

            // 关闭对话框
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // 关闭对话框而不设置行和列属性
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void autoSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                SetAutoSize(true); 
                FixedColumnWidthTextBox.Enabled = false; 
            }
        }

        private void fixedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                SetAutoSize(false); 
                FixedColumnWidthTextBox.Enabled = true;
                FixedColumnWidthTextBox.Text = "1000";
            }
        }
    }
}
