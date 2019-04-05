using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }
        int modsayi = 1, sonuc = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            
            modsayi = modsayi + 1;
            sonuc = modsayi % 2;
            if (sonuc.ToString() == "0")
            {
                label1.Text = "Açık";
                label1.ForeColor = Color.Green;
                button1.ForeColor = Color.Red;
                button1.Text = "Kapat";
            }
            else if (sonuc.ToString() == "1")
            {
                label1.Text = "Kapalı";
                label1.ForeColor = Color.Red;
                button1.ForeColor = Color.Green;
                button1.Text = "Aç";
            }
            else
            {
                MessageBox.Show("Program Bir Hatayla Karşılaştı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
