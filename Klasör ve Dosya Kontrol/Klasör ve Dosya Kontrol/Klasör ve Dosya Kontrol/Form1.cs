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

namespace Klasör_ve_Dosya_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Kopyalamak İstenen Dosya Seç
        string kopyalanacakDosyanınYolu;
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyanınYolu = openFileDialog1.FileName;
                textBox6.Text = openFileDialog1.FileName;

                dosyaOzellikleri();
            }
            else
            {
                //MessageBox.Show("Kopyalanacak dosyayı  seçmediniz!");
                label7.Text = "Kopyalanacak dosyayı seçmediniz!";
            }
        }
        #endregion

        #region Kopyalanacak Klasör
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK) 
            {
                textBox7.Text = folderBrowserDialog2.SelectedPath;
                kopyalancakKlasor();
                

            } else {
                label7.Text = "Kopyalanacak klasörü seçmediniz!";
            }
        }

        private void kopyalancakKlasor() {
            try
            {
                //dosyaları okuma
                string[] dizinDosyalar = Directory.GetFiles(textBox7.Text);

                //listBox Temizle
                kopyalanacakDosyaListesi.Items.Clear();

                //Listelemek için döngü
                foreach (string dosya in dizinDosyalar)
                {
                    //Dosya Tanımlama
                    FileInfo fileInfo = new FileInfo(dosya);
                    //Dosya Adları
                    dosyaAdi = fileInfo.Name;
                    kopyalanacakDosyaListesi.Items.Add(dosyaAdi);
                    

                }
            }
            catch { }
        }

        private void kopyalanacakDosyaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox7.Text + "\\" + kopyalanacakDosyaListesi.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dosyaOzellikleri();
        }
        #endregion


        #region Kopyalanacak Dosyanın Özellikleri
        string kopyalanacakdosyaAdi;
        long kopyalanacakDosyanınBoyutu;
        private void dosyaOzellikleri()
        {
            //Dosya Adı
            kopyalanacakdosyaAdi = kopyalanacakDosyaListesi.Text;
            textBox5.Text = kopyalanacakdosyaAdi;

            //Dosya Boyutu
            FileInfo info = new FileInfo(textBox6.Text);
            kopyalanacakDosyanınBoyutu = info.Length;
            textBox4.Text = kopyalanacakDosyanınBoyutu.ToString();
        }
        #endregion

        #region Hedef Klasör
        string hedefKlasor;
        private void button1_Click(object sender, EventArgs e)
        {
            //Klasör Seçme Diyaloğu
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //Hedef Klasör Tanımlama
                hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                //TextBox Aktarma
                textBox1.Text = hedefKlasor;
                //Klasör İçeriği Listeleme
                klasorIcerigiListele(hedefKlasor);
            }
            else
            {
                //MessageBox.Show("Hedef klasör seçmediniz!");
                label7.Text = "Hedef klasör seçmediniz!";
            }
        }
        #endregion

        #region Klasör içeriği listeleme
        string dosyaAdi = null;
        long dosyaBoyut;
        private void klasorIcerigiListele(string dizin)
        {
            try
            {
                //dosyaları okuma
                string[] dizinDosyalar = Directory.GetFiles(dizin);

                //listBox Temizle
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                //Listelemek için döngü
                foreach (string dosya in dizinDosyalar)
                {
                    //Dosya Tanımlama
                    FileInfo fileInfo = new FileInfo(dosya);
                    //Dosya Adları
                    dosyaAdi = fileInfo.Name;
                    listBox1.Items.Add(dosyaAdi);
                    //Dosya Boyutları
                    dosyaBoyut = fileInfo.Length;
                    listBox2.Items.Add(dosyaBoyut);

                }
            }
            catch {}
        }
        #endregion

        #region Listbox Seçilen Dosyaları Textbox Aktarma
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1'de seçildiğinde
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            //Dosya Adı
            textBox2.Text = listBox1.Text;
            //Dosya Boyutu
            textBox3.Text = listBox2.Text;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox2'de seçildiğinde
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            //Dosya Adı
            textBox2.Text = listBox1.Text;
            //Dosya Boyutu
            textBox3.Text = listBox2.Text;
        }
        #endregion

        #region Dosya Kontrolü
        private void dosyaKontrolu() 
        {
            try
            {
                if (File.Exists(hedefKlasor + "\\" + kopyalanacakdosyaAdi))
                {
                    //Dosya Boyutu
                    FileInfo info = new FileInfo(hedefKlasor + "\\" + dosyaAdi);
                    long dosyaBoyutu = info.Length;

                    if (dosyaBoyut == kopyalanacakDosyanınBoyutu) { }else
                    {

                        //Dosya boyutu aynı değil ise işlem yap
                        File.Delete(hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                        label7.Text = "'" + kopyalanacakdosyaAdi + "' isimli dosyanın adı ve boyutu aynı, silindi ve tekrar kopyalandı!";

                        File.Copy(textBox6.Text, hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                    }
                }
                else
                {
                    //Dosya hiç yok ise
                    Directory.CreateDirectory(hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                    File.Copy(textBox6.Text, hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                    label7.Text = "'" + kopyalanacakdosyaAdi + "' isimli dosya yokmuş kopyalandı!";
                }

            }
            catch { label7.Text = "Hata oluştu"; }
        }

        #endregion

        #region Timer1 Dosya Kontrollerinde Döngü İçin
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                

                //Seçili dosyanın listbox'da index'ini bir arttır
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                textBox2.Text = listBox1.Text;
                textBox3.Text = listBox2.Text;

                dosyaKontrolu();

                int listboxCount = listBox1.Items.Count - 1;
                int copyCount = kopyalanacakDosyaListesi.Items.Count - 1;

                if (listBox1.SelectedIndex == listboxCount) 
                {
                    DateTime saat = DateTime.Now;
                    label7.Text = "[" + saat + "][" + kopyalanacakDosyaListesi .Text + "]isimli dosyanın tarama işlemi tamamlandı ve tüm işlemler uygulandı.";
                    

                    kopyalanacakDosyaListesi.SelectedIndex = kopyalanacakDosyaListesi.SelectedIndex + 1;
                    listBox1.SelectedIndex = 0;
                }

                if (kopyalanacakDosyaListesi.SelectedIndex == copyCount)
                {
                    label7.Text = "Tarama işlemi tamamlandı ve tüm işlemler uygulandı.";
                    listBox1.SelectedIndex = 0;
                    kopyalanacakDosyaListesi.SelectedIndex = 0;
                    timer1.Enabled = false;

                }
            }
            catch { }
        }
        #endregion

        #region Tarama Başlat
        private void taramayıBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                TextWriter dosya = new StreamWriter(hedefKlasor + "\\1.txt"); 
                dosya.Flush(); 
                dosya.Close();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                textBox2.Clear();
                textBox3.Clear();
                //Klasör İçeriği Listeleme
                klasorIcerigiListele(hedefKlasor);
                timer1.Enabled = true;
                DateTime saat = DateTime.Now;
                label7.Text = "[" + saat + "]Tarama başladı.";
            }
            else 
            {
                label7.Text = "Tarama başlamadı!";
                DateTime saat = DateTime.Now;
                label7.Text = "[" + saat + "]Tarama başlamadı!";
            }
        }
        #endregion

        #region Tarama Durdur
        private void taramayıDurdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Text = "Tarama yarıda durduruldu.";

                listBox1.SelectedIndex = 0;
                textBox2.Clear();
                textBox3.Clear();
                timer1.Enabled = false;
            }
            catch { }
        }
        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter(kopyalanacakdosyaAdi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("d:\\yeniklasor");
            Directory.CreateDirectory(hedefKlasor + "\\" + kopyalanacakdosyaAdi);
        }







    }
}
