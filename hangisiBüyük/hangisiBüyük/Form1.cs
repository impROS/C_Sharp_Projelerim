using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangisiBüyük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Location = label1.Location;
            label1.Top = label1.Top - 10;
            textBox2.Location = label2.Location;
            label2.Top = label2.Top - 10;
            textBox3.Location = label3.Location;
            label3.Top = label3.Top - 10;
            label1.BackColor=Color.Transparent;
            label1.Text = "1.Sayıyı Giriniz";
            textBox1.Width = label1.Width  ;
            label2.Text = "2.Sayıyı Giriniz";
            textBox2.Width = label2.Width;
            label3.Text = "3.Sayıyı Giriniz";
            textBox3.Width = label3.Width;
            int butonboyut = (label3.Left - label1.Left) / 2 + label1.Left;
           button1.Left = butonboyut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int birincisayi, ikincisayi, ücüncüsayi;
            birincisayi = Convert.ToInt32(textBox1.Text);
            ikincisayi = Convert.ToInt32(textBox2.Text);
            ücüncüsayi = Convert.ToInt32(textBox3.Text);
            if (birincisayi > ikincisayi)
            {
                if (birincisayi > ücüncüsayi)
                {
                    MessageBox.Show("En Büyük Sayi = " + birincisayi, "Hangisi Büyük");
                }
                else
                {
                    MessageBox.Show("En Büyük Sayi = " + ücüncüsayi, "Hangisi Büyük");
                }

            }
            else
            {
                if (ikincisayi > ücüncüsayi)
                {
                    MessageBox.Show("En Büyük Sayi = " + ikincisayi, "Hangisi Büyük");
                }
                else
                {
                    MessageBox.Show("En Büyük Sayi = " + ücüncüsayi, "Hangisi Büyük");
                }
            }
            }
            catch
            {
label4.Text="Adamakıllı sayı giriniz";
            }
        }     
    }
}
