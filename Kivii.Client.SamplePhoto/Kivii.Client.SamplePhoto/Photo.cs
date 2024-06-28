using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivii.Client.SamplePhoto
{
    public class Photo
    {
        public Bitmap Image { get; set; }
        public string Name { get; set; }

        public Photo(Bitmap image, string name)
        {
            Image = image;
            Name = name;
        }
    }
}
