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
            Button newButon = new Button();
            newButon.BackColor = Color.BlanchedAlmond;
            newButon.ForeColor = Color.Black;
            newButon.Text = "Hello Button";
            newButon.Location = new Point(10, 10);
            this.Controls.Add(newButon);
        }
    }
}
