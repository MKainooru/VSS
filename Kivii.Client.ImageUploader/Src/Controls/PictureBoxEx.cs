using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivii.Imaging.Uploader.Controls
{
    public partial class PictureBoxEx : UserControl
    {
        public System.Drawing.Image Image
        {
            get
            {
                return pic.BackgroundImage;
            }
            set
            {
                pic.BackgroundImage = value;
            }
        }
        public PictureBoxEx()
        {
            InitializeComponent();
        }

        private void PictureBoxEx_Enter(object sender, EventArgs e)
        {
            toolMenu.Visible = true;
        }

        private void PictureBoxEx_Leave(object sender, EventArgs e)
        {
            toolMenu.Visible = false;

        }

        private void pic_Click(object sender, EventArgs e)
        {
            this.ParentForm.ActiveControl = this;
        }

        private void toolMenuTurnLeft_Click(object sender, EventArgs e)
        {
            if (Image == null) return;
            Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pic.Refresh();
        }

        private void toolMenuTurnRight_Click(object sender, EventArgs e)
        {
            if (Image == null) return;
            Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pic.Refresh();
        }

        private void toolMenuEdit_Click(object sender, EventArgs e)
        {

        }

        private void toolMenuDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
