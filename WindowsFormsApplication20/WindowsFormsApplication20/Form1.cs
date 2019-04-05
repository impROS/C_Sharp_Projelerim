using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise,saniye,dakika,saat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            salise=salise+1;
            label1.Text = salise.ToString();
            
            if (label1.Text.ToString() == "59")
            { 
saniye=saniye+1;
label2.Text = saniye.ToString();
salise = 0;
if (label2.Text.ToString() == "59")
{
    dakika = dakika + 1;
    label3.Text = dakika.ToString();
    saniye = 0;
    if (label3.Text.ToString() == "59")
    {
        saat = saat + 1;
        label4.Text = saat.ToString();
        dakika = 0;
    }
}
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            label5.Text = dt.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dakika = dt.Second;
            label2.Text = dt.Second.ToString();
            timer1.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.Millisecond.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
