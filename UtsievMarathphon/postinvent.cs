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
    public partial class postinvent : Form
    {
        public postinvent()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new inventar().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new inventar().Show();
        }
    }
}
