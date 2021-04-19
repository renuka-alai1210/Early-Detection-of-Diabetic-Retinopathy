using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EarlyDibetic
{
    public partial class GrayScale : Form
    {
        public static Bitmap bt6;
        public static Bitmap bt1;
        public static Bitmap bt;
        public static string path = "";
        public GrayScale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Select input Image file 
                openFileDialog1.ShowDialog();
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);  // Display input image in picture box 
                button2.Enabled = true;
                path = openFileDialog1.FileName;
                bt6 = new Bitmap(openFileDialog1.FileName);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bt = new Bitmap(pictureBox1.BackgroundImage);
                grayscale(bt);
                bt1 = new Bitmap(pictureBox2.BackgroundImage);
            }
            catch { }
            
        }

        public void grayscale(Bitmap bt)
        {
            for (int i = 0; i < bt.Width; i++)
            {
                for (int j = 0; j < bt.Height; j++)
                {
                    Color c = bt.GetPixel(i, j);
                    double r = c.R;
                    double g = c.G;
                    double b = c.B;

                    double avg = (r + g + b) / 3; //Calculate AVG                   
                    bt.SetPixel(i, j, Color.FromArgb(int.Parse(avg.ToString("0")), int.Parse(avg.ToString("0")), int.Parse(avg.ToString("0")))); //Assign AVG value                    
                }
            }
            pictureBox2.BackgroundImage = bt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void GrayScale_Load(object sender, EventArgs e)
        {

        }
    }
}
