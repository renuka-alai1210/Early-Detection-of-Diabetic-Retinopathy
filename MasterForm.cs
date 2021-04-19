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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panel2.Controls.Clear();
            GrayScale r = new GrayScale();
            r.TopLevel = false;
            r.Dock = DockStyle.Left;
            r.WindowState = FormWindowState.Maximized;
            r.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(r);
            r.Show();
        }

        private void theSobelImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
        }

        private void restoredTransmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dehazedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void actionContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Mainform r = new Mainform();
            r.TopLevel = false;
            r.Dock = DockStyle.Fill;
            r.WindowState = FormWindowState.Maximized;
            r.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(r);
            r.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void convertToHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            GrayScale r = new GrayScale();
            r.TopLevel = false;
            r.Dock = DockStyle.Fill;
            r.WindowState = FormWindowState.Maximized;
            r.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(r);
            r.Show();
        }

        private void fetureExtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void segmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Mainform r = new Mainform();
            r.TopLevel = false;
            r.Dock = DockStyle.Fill;
            r.WindowState = FormWindowState.Maximized;
            r.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(r);
            r.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
