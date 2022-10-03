using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;
        int n = 0;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int tab = nth.Text.to;
            n = (a * 123);
            key.Text = n + "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (n / 123 == 1)
            {
                key.Text = "A";
            }
            else
            {
                key.Text = (n / 123) + "";
            }
            
        }
    }
}
