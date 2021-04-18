using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jill
{
    public partial class Preview : Form
    {
        string full_path = null;

        public Preview(string path)
        {
            InitializeComponent();
            full_path = path;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            render.Image = Image.FromFile(full_path);
            render.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
