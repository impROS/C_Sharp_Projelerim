using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayaç = 0;
        int bisikletsolauzaklık;
        private void Form1_Load(object sender, EventArgs e)
        {
            bisikletsolauzaklık = pictureBox1.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayaç++;
            int lamba = label3.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(10, 30);
            int bisikletgenislik = pictureBox1.Width;
            label4.Text = sayaç.ToString();

            if (bisikletgenislik + pictureBox1.Left >= label5.Left && sayaç <= 40)
            {
                timer1.Enabled = false;
            }
            

            if (sayaç == 60)
            {
                sayaç = 0;
                label4.Text = sayaç.ToString();
            }
            if (sayaç <= 30)
            {
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 30 && sayaç <= 40)
            {
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 40)
            {
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Green;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayaç >= 40)
            {
                timer2.Enabled = true;

            }
            else
            {
                MessageBox.Show("Kırmızı ışık yanıyor lütfen bekleyin!!!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayaç++;
            int lamba = label3.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,8);
            int bisikletgenislik = pictureBox1.Width;
            label4.Text = sayaç.ToString();

            if (bisikletgenislik + pictureBox1.Left >= label3.Left)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            if (sayaç == 60)   
            {
                sayaç = 0;
                label4.Text = sayaç.ToString();
            }
            if (sayaç <= 30)
            {
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 30 && sayaç <= 40)
            {
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 40)
            {
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Green;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayaç++;
            label4.Text = sayaç.ToString();
            if (sayaç == 60) 
            {
                sayaç = 0;
                label4.Text = sayaç.ToString();
            }
            if (sayaç <= 30)
            {
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 30 && sayaç <= 40)
            {
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Gray;
            }
            if (sayaç >= 40)
            {
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Green;
            }
        }
    }
}
