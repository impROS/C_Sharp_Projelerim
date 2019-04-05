using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şifrekırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
           string zaman1;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;


            zaman1 = DateTime.Now.TimeOfDay.ToString();
                listBox1.Items.Add("Başlama Zamanı "+zaman1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Şifre Deneniyor ..";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayi++;
            label2.Text = sayi.ToString();
            if (label2.Text == label1.Text)
            {
                label3.Text = "Şifre Bulundu" + sayi.ToString();
                zaman1 = DateTime.Now.TimeOfDay.ToString();
                listBox1.Items.Add("Bitiş Zamanı " + zaman1);
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }
    }
}
