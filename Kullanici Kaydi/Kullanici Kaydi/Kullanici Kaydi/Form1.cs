using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kullanici_Kaydi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Boş kutuları doldurun");
            else
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=kayit.accdb");
                OleDbCommand kaydet = new OleDbCommand("insert into Tablo1 (kadi,sifre) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglan);
                baglan.Open();
                kaydet.ExecuteNonQuery();
                if (baglan.State == ConnectionState.Open)
                {
                    MessageBox.Show("Yeni Kullanıcı Yaratıldı,www.elektroarge.com");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Kullanıcı Kaydında Hata");
                }
                baglan.Close();
            }
        }
    }
}
