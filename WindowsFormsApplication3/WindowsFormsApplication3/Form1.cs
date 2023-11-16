using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "aaa";
            string password = "bbb";

            if (textBox1.Text == login && textBox2.Text == password )
            {
                button1.BackColor = Color.Green;
                MessageBox.Show("OK");
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                button1.BackColor = Color.Red;
                MessageBox.Show("Error");
            }
        }
    }
}
