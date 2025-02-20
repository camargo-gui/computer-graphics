using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        private Bitmap original;
        private Bitmap current;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    original = new Bitmap(ofd.FileName);
                    current = new Bitmap(original);
                    picMain.Image = current;
                    brightnessSlider.Value = 0;
                    hueSlider.Value = 0;
                }
            }
        }
    }
}
