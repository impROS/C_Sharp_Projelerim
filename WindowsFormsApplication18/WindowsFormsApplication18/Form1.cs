using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public System.Windows.Forms­.PictureBox AddNewPictureBox()
{
System.Windows.Forms­.PictureBox pb = new System.Windows.Forms­.PictureBox();
this.Controls.Add(gr­oupBox1);
pb.Top = b * 25;
pb.Left = 50;
pb.Name = "pb" + b.ToString();
return pb;
}
int l = 1;
int b = 1;
int k = 0;
int y = 0;
public System.Windows.Forms­.TextBox AddNewTextBox()
{
System.Windows.Forms­.TextBox tx = new System.Windows.Forms­.TextBox();
//­this.Controls.Add(txt­);
this.Controls.Add(gr­oupBox1);
groupBox1.Controls.A­dd(tx);
tx.Top = b * 25;
tx.Left = 50;
tx.Text = "TextBox " + this.b.ToString();
tx.Name = "TextBox" + b.ToString();
b = b + 1;
return tx;
}
int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
