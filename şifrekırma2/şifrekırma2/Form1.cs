using System;
using System.Windows.Forms;

namespace şifrekırma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sifre,toplam,sonuc;
        string zaman1,zaman2;
        private void button1_Click(object sender, EventArgs e)
        {
zaman1 = DateTime.Now.TimeOfDay.ToString();
            listBox1.Items.Add("Başlama Zamanı   = " + zaman1);
                               
            //System.Threading.Thread.Sleep(2000);
           // while (listBox1.Items.Add("Başlama Zamanı " + zaman1)==0)
            { 
                Application.DoEvents();
            }
            sifre = Convert.ToInt32(label2.Text);
            for (int i = 0; i < sifre; i++)
            {

                toplam++;
                label1.Text = toplam.ToString() ;

            }

            label1.Text = "Şifre Bulundu = " + toplam;
            zaman2 = DateTime.Now.TimeOfDay.ToString();
            listBox1.Items.Add("Bitiş Zamanı          = " + zaman2);
           // sonuc = Convert.ToInt32(zaman2) - Convert.ToInt32(zaman1);
            //MessageBox.Show(sonuc.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
