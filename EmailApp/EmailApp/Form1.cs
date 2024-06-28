using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace EmailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FontSize.SelectedIndex = 0;
            mailService.SelectedIndex = 0;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        /// <summary>
        /// 验证是否为邮件格式
        /// </summary>
        /// <param name="email">邮箱地址</param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
            Match m = RegEmail.Match(email);
            return m.Success;
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mailServiceName = mailService.SelectedItem.ToString();
                string stmpService = GetSmtpServiceFromMailService(mailServiceName);
                // 收件人地址
                string receiveerEmail = receiveBox.Text;
                // 发件人地址
                string senderEmail = sendBox.Text;
                // 发件人密码/授权码
                string senderPassword = passwordBox.Text;

                if (!IsValidEmail(receiveerEmail) || !IsValidEmail(senderEmail))
                {
                    MessageBox.Show("请输入有效的邮件地址！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Host = stmpService;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, receiveerEmail);
                mailMessage.Subject = themeBox.Text;
                mailMessage.Body = bodyBox.Text;
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.Normal;

                if (!string.IsNullOrEmpty(filePath.Text))
                {
                    Attachment attachment = new Attachment(filePath.Text);
                    mailMessage.Attachments.Add(attachment);
                }

                smtpClient.Send(mailMessage);
                MessageBox.Show("邮件发送成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("邮件发送失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 根据选择返回对应服务器地址
        /// </summary>
        /// <param name="mailService">服务器地址</param>
        /// <returns></returns>
        private string GetSmtpServiceFromMailService(string mailService)
        {
            switch (mailService)
            {
                case "QQ邮箱":
                    return "smtp.qq.com";
                case "网易邮箱":
                    return "smtp.yeah.net";
                case "谷歌邮箱":
                    return "smtp.gmail.com";
                default:
                    return "";
            }
        }
        /// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog annex = new OpenFileDialog();
            if (annex.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = annex.FileName;
            }
        }
        /// <summary>
        /// 字体加粗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }
        /// <summary>
        /// 斜体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void italic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }
        /// <summary>
        /// 下划线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }
        /// <summary>
        /// 删除线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strikeLine_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Strikeout);
        }
        /// <summary>
        /// 切换文本样式
        /// </summary>
        /// <param name="fontStyle"></param>
        private void ToggleFontStyle(FontStyle fontStyle)
        {
            if (bodyBox.SelectionFont != null)
            {
                FontStyle newStyle = bodyBox.SelectionFont.Style ^ fontStyle;
                bodyBox.SelectionFont = new System.Drawing.Font(bodyBox.SelectionFont.FontFamily, bodyBox.SelectionFont.Size, newStyle);
            }
        }
        /// <summary>
        /// 字号修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodyBox.SelectionFont != null && float.TryParse(FontSize.SelectedItem.ToString(), out float size))
            {
                bodyBox.SelectionFont = new System.Drawing.Font(bodyBox.SelectionFont.FontFamily, size, bodyBox.SelectionFont.Style);
            }
        }
        /// <summary>
        /// 左对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftAlign_Click(object sender, EventArgs e)
        {
            bodyBox.SelectionAlignment = HorizontalAlignment.Left;
        }
        /// <summary>
        /// 居中对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CenterAlign_Click(object sender, EventArgs e)
        {
            bodyBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        /// <summary>
        /// 右对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightAlign_Click(object sender, EventArgs e)
        {
            bodyBox.SelectionAlignment = HorizontalAlignment.Right;
        }
        /// <summary>
        /// 设置字体颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetFontColor(System.Drawing.Color color)
        {
            bodyBox.SelectionColor = color;
        }
        private void FontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetFontColor(colorDialog.Color);
            }
        }
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    // 将图片添加到剪贴板
                    Clipboard.SetImage(Image.FromFile(imagePath));

                    // 将剪贴板中的图片粘贴到富文本框中
                    bodyBox.Paste();
                }
            }
        }
        /// <summary>
        /// 导入文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Word Files (*.docx)|*.docx|Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = ReadFile(filePath);

                // 将读取的文件内容追加到邮件编辑框中现有内容的下方
                bodyBox.AppendText(fileContent);
            }
        }
        /// <summary>
        /// 划分读取文件的类型
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private string ReadFile(string filePath)
        {
            string text = string.Empty;

            string fileExtension = Path.GetExtension(filePath).ToLower();

            if (fileExtension == ".txt")
            {
                text = File.ReadAllText(filePath);
            }
            else if (fileExtension == ".docx")
            {
                text = ReadWordDocument(filePath);
            }
            else if (fileExtension == ".xlsx")
            {
                text = ReadExcelDocument(filePath);
            }
            else
            {
                text = "不支持的文件类型。";
            }

            return text;
        }
        /// <summary>
        /// Word格式文件的读取
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private string ReadWordDocument(string filePath)
        {
            string text = string.Empty;

            using (WordprocessingDocument docxDocument = WordprocessingDocument.Open(filePath, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body body = docxDocument.MainDocumentPart.Document.Body;

                foreach (var paragraph in body.Elements<Paragraph>())
                {
                    text += paragraph.InnerText + Environment.NewLine;
                }
            }

            return text;
        }
        /// <summary>
        /// Excel文件的读取
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private string ReadExcelDocument(string filePath)
        {
            StringBuilder content = new StringBuilder();

            string text = string.Empty;

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
            {

                if (excelPackage.Workbook.Worksheets.Count > 0)
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            text += worksheet.Cells[row, col].Value?.ToString() + "\t";
                        }
                        text += Environment.NewLine;
                    }
                }
                else
                {
                    text = "Excel 文件中没有工作表。";
                }
            }

            return text;
        }
        /// <summary>
        /// 插入表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertTable_Click(object sender, EventArgs e)
        {
            // 提示用户输入表的行数和列数
            TableInputDialog dialog = new TableInputDialog();
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int rows = dialog.Rows;
                int cols = dialog.Columns;
                bool autoSize = dialog.GetAutoSize();
                int fixedColumnWidth = dialog.FixedColumnWidth;

                // 将具有指定行和列的表插入到主体框中
                if (autoSize)
                {
                    InsertTableAutoSize(rows, cols);
                }
                else
                {
                    InsertTableFixedSize(rows, cols, fixedColumnWidth);
                }
            }
        }
        
        private void InsertTableAutoSize(int rows, int cols)
        {
            StringBuilder rtf = new StringBuilder();
            rtf.Append(@"{\rtf1 ");

            int cellWidth = ((bodyBox.ClientSize.Width - 3) / cols) * 15;

            for (int i = 0; i < rows; i++)
            {
                rtf.Append(@"\trowd");
                for (int j = 1; j <= cols; j++)
                {
                    rtf.Append(@"\cellx" + (j * cellWidth).ToString());
                }
                rtf.Append(@"\intbl \cell \row"); // 创建行
            }
            rtf.Append(@"\pard");
            rtf.Append(@"}");
            bodyBox.SelectedRtf = rtf.ToString();
        }

        private void InsertTableFixedSize(int rows, int cols, int fixedColumnWidth)
        {
            StringBuilder rtf = new StringBuilder();
            rtf.Append(@"{\rtf1 ");
            for (int i = 0; i < rows; i++)
            {
                rtf.Append(@"\trowd");
                for (int j = 1; j <= cols; j++)
                {
                    rtf.Append(@"\cellx" + (j * fixedColumnWidth).ToString());
                }
                rtf.Append(@"\intbl \cell \row"); // 创建行
            }
            rtf.Append(@"\pard");
            rtf.Append(@"}");
            bodyBox.SelectedRtf = rtf.ToString();
        }
    }
}
