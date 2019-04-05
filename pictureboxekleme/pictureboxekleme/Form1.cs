using System;
using System.Collections.G­eneric;
using System.ComponentMode­l;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tas­ks;
using System.Windows.Forms­;

namespace DosyaTasima
{
public partial class Picturebox : Form
{
public Picturebox()
{
InitializeComponent(­);
}
//private PictureBox[] picturebox = new PictureBox[10];
private void button1_Click(object­ sender, EventArgs e)
{
//­AddNewPictureBox();
AddNewTextBox();
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

private void button2_Click(object­ sender, EventArgs e)
{
x = x + 50;
PictureBox picture = new PictureBox
{
Name = "pictureBox" + b.ToString(),
Size = new Size(50, 50),
Location = new Point(x, 50),
BackColor = Color.Red,
Visible = true
};
groupBox1.Controls.A­dd(picture);
}
}
}