using System;
using System.Windows.Forms;

namespace Kivii.Imaging.Uploader
{
    static class Program
    {
 
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            if (args == null) args = new string[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FrmCamera());
        }
    }
}
