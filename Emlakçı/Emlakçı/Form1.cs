using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlakçı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "emlak" && textBox2.Text == "1234")
            {
                Form2 emlak = new Form2();
                emlak.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyin!!!");
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}
