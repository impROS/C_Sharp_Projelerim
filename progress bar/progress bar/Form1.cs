using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = pictureBox1.Left;
            label1.Text = "Yükleniyor ..";
            label1.ForeColor = Color.Red;
            pictureBox2.Width++;


            label3.Text = saydir.ToString();
            if (pictureBox2.Width.ToString() == pictureBox1.Width.ToString())
            {
                label1.Left = pictureBox1.Left;
                label1.Text = "Yükleme Tamamlandı";
                label1.ForeColor = Color.Yellow;
                timer1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int pboyut,islem,sonuc,saydir;
        private void button1_Click(object sender, EventArgs e)
        {
            pboyut = pictureBox1.Left + pictureBox1.Right;
            label2.Text = pboyut.ToString();
            islem = ((Convert.ToInt32(textBox1.Text) + pboyut )* 100) / pboyut;
            timer1.Interval = islem;
            label3.Text = textBox1.Text;
            timer1.Enabled = true;
            timer2.Enabled=true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            saydir = Convert.ToInt32(label3.Text);
            saydir = saydir - 1;
        }
    }
}
