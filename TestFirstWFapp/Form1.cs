using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFirstWFapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor != Color.Green)
            {
                button1.BackColor = Color.Green;
                button1.Text = "Green!";
            } else
            {
                button1.BackColor = Color.Red;
                button1.Text = "Red!";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/pavel-samsonenka/");
        }
    }
}
