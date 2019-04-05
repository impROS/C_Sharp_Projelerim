using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isciSayisi = 10;

            PictureBox[] isciler = new PictureBox[isciSayisi];

            for (int i = 0; i < isciSayisi; i++)
            {
                isciler[i] = new PictureBox();
                isciler[i].Name = "isci-" + i.ToString();
                isciler[i].Location = new Point(10 + i, 20 + i);
                isciler[i].Size=new Size(50+i,50+i);
                isciler[i].ImageLocation = @"C:\deneme1\deneme.jpg";
                isciler[i].Visible = true;
                isciler[i].BackColor = Color.Transparent;
                isciler[i].SizeMode = PictureBoxSizeMode.Normal;

                this.Controls.Add(isciler[i]);
                isciler[i].BringToFront();

            }

        }
    }
}
