﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtsievMarathphon
{
    public partial class @long : Form
    {
        public @long()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel4.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form info = new info();
            info.Show();
        }
    }
}