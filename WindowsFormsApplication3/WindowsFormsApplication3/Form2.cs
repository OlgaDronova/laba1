﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            Color userColor = dialog.Color;
            button2.BackColor = userColor;    
            }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            Color userColor = dialog.Color;
            button2.ForeColor = userColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }
    }
}
