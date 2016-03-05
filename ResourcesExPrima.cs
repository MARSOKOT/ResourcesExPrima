using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TopMost = true;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs x)
        {
            this.Opacity = (double) (numericUpDown1.Value) / 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                if (numericUpDown2.Text != "" && numericUpDown2.Text != "")
                {
                    this.Width = Convert.ToInt16((582 * numericUpDown2.Value) / 97);
                    this.Height = Convert.ToInt16((418 * numericUpDown2.Value) / 97 + 32);
                }
            }
        }
    }
}
