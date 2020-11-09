﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuboid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            

            }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read values for Length and Width and Height from textboxes
                double Length = double.Parse(textBox1.Text);
                double Width = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                //Calculate Volume
                double Volume = (Length * Width * Height);
                double SurfaceArea = 2.0 * (Length * Width + Length * Height + Width * Height);
                label4.Text = "Volume=" + Volume;
                label5.Text = "Surface Area=" + SurfaceArea;
            }

            catch
            {
                MessageBox.Show("Error on Input");
            }
           
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
