using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxoluşturmabirdenfazla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            private PictureBox[] picturebox = new PictureBox[10];

for (int i = 1; i < 11; i++)
{
picturebox[i] = new PictureBox();
picturebox[i].Name = "picturebox"+i.ToString ();
picturebox[i].SetBounds(10, 10, 150, 150);//location ve size belirleme
this.Controls.Add(picturebox[i]);
}
        }
    }
}
