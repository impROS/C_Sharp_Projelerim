using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i <= 100; i++)  //I sayısını sıfırdan başlattık ve 100'e kadar artıtrttık 101 //olunca döngüden çıkacak ve aşağıda verilen şartı taamamlayıp döngüden çıkacak..
            {
                toplam = toplam + i; 
                //  toplam+=I; şeklinde de yazılabilirdi
                label1.Text = toplam.ToString();
            }

            label1.Text = toplam.ToString();
        }
    }
}
