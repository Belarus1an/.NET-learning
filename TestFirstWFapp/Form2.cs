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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Pink;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.BackColor = Color.BlanchedAlmond;
            newButton.ForeColor = Color.Black;
            newButton.Text = "Hello Button";
            newButton.Location = new Point(10, 10);
            this.Controls.Add(newButton);

            Button newButton2 = new Button();
            newButton2.BackColor = Color.BlanchedAlmond;
            newButton2.ForeColor = Color.Black;
            newButton2.Text = "Hello Button2";
            newButton2.Location = new Point(10, 20);
            groupBox1.Controls.Add(newButton2);
        }
    }
}
