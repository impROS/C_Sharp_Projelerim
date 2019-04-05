using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace DosyaKoplayama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kopyalanacakDosya = "", dosyanınKopyanacagiKlasor = "", kopyalanacakDosyaIsmi = ""; 


        private void button3_Click(object sender, EventArgs e)
        {
            
            kopyalanacakDosya = textBox1.Text;
            dosyanınKopyanacagiKlasor = textBox2.Text;
            openFileDialog1.FileName = textBox1.Text;
            kopyalanacakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
            if (dosyanınKopyanacagiKlasor != "" && kopyalanacakDosya != "")
            {
                if (File.Exists(dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi);
                    MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı...");
                }
            }
            else if (dosyanınKopyanacagiKlasor == "")
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kopyalanacakDosya == "")
            {
                 MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
