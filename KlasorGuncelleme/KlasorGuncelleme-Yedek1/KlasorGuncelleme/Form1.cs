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

namespace KlasorGuncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaAdi;
        string dosyaAdia;
        string hedefKlasor;
        string kopyalanacakdosyaAdi;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        #region Kaynak Klasör İçeriğini Listele
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //dosyaları okuma
                string[] dizinDosyalar = Directory.GetFiles(textBox1.Text);

                //listBoxları Temizle
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox8.Items.Clear();
                listBox7.Items.Clear();

                //Listelemek için döngü
                foreach (string dosya in dizinDosyalar)
                {
                    //Dosya Tanımlama
                    FileInfo fileInfo = new FileInfo(dosya);

                    //Dosya Adları ve Boyut Tanımla
                    dosyaAdi = fileInfo.Name;
                    dosyaBoyut = fileInfo.Length;

                    //Dosya Adı ve Boyutları Listele
                    listBox1.Items.Add(dosyaAdi);
                    listBox2.Items.Add(dosyaBoyut);
                    listBox3.Items.Add(dosyaAdi + dosyaBoyut);
                    label1.Text = "Dosyalar Başarıyla Listelendi";

                }
            }
            catch 
            {
                label1.Text = "HATA";
            }
        }
        #endregion

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
   
        }

        public object dosyaBoyut { get; set; }

        #region Hedef Klasör İçeriğini Listele
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //dosyaları okuma
                string[] dizinDosyalara = Directory.GetFiles(textBox2.Text);

                //listBoxları Temizle
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();
                listBox8.Items.Clear();
                listBox8.Items.Clear();

                //Listelemek için döngü
                foreach (string dosyaa in dizinDosyalara)
                {
                    //Dosya Tanımlama
                    FileInfo fileInfo = new FileInfo(dosyaa);

                    //Dosya Adları ve Boyut Tanımla
                    dosyaAdia = fileInfo.Name;
                    dosyaBoyuta = fileInfo.Length;

                    //Dosya Adı ve Boyutları Listele
                    listBox4.Items.Add(dosyaAdia);
                    listBox5.Items.Add(dosyaBoyuta);
                    listBox6.Items.Add(dosyaAdia + dosyaBoyuta);
                    label1.Text = "Dosyalar Başarıyla Listelendi";

                }
            }
            catch
            {

                label1.Text = "HATA";
            
            }

        }
        #endregion



        public object dosyaBoyuta { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {

                int liste1 = listBox1.Items.Count;
                int liste7 = listBox7.Items.Count;
                int liste8 = listBox8.Items.Count;
                int listekontrol=liste8+liste7+1;

                object listbox3 = listBox3.SelectedItem;
                string secililiste3 = Convert.ToString(listbox3);
 
                object listbox6 = listBox6.SelectedItem;
                string secililiste6 = Convert.ToString(listbox6);

               if (listekontrol == liste1) 
                {
                    label1.Text = "Tarama işlemi tamamlandı ve tüm işlemler uygulandı.";
 
                }



 
if (secililiste3 == secililiste6)
                {
                    listBox7.Items.Add(listBox1.SelectedItem);
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                
                //Seçili dosyanın listbox'da index'ini bir arttır
                listBox3.SelectedIndex = listBox3.SelectedIndex + 1;
                listBox6.SelectedIndex = listBox6.SelectedIndex + 1;
                liste1 = liste1 - 1;

                button3.PerformClick();
                }
                else
                {
                    listBox8.Items.Add(listBox1.SelectedItem);
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

                    //Seçili dosyanın listbox'da index'ini bir arttır
                    listBox3.SelectedIndex = listBox3.SelectedIndex + 1;
                    listBox6.SelectedIndex = listBox6.SelectedIndex + 1;
                    liste1 = liste1 - 1;
                    button3.PerformClick();
                }
                
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 2;
            listBox7.Items.Add(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int deneme=listBox6.Items.Count;
            string sayi = Convert.ToString(deneme);
            label1.Text = sayi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            object deneme3=listBox3.SelectedItem;
            string deneme4 = Convert.ToString(deneme3);
            label1.Text = deneme4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            listBox3.SelectedIndex = 0;
            listBox6.SelectedIndex = 0;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            button2.PerformClick();
            button7.PerformClick();
            button3.PerformClick();
            button10.PerformClick();
            button9.PerformClick();
            button1.PerformClick();
            button2.PerformClick();
            button7.PerformClick();
            button3.PerformClick();
            button10.PerformClick();
            button9.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                int liste8 = listBox8.Items.Count;
                hedefKlasor = textBox2.Text;
                object deneme8 = listBox8.SelectedItem;
                string kopyalanacakdosyaAdi = Convert.ToString(deneme8);
               
                if (liste8 == 0)
                {
                    label1.Text = "Tarama Bitti";
                }
                else
                {
                    File.Delete(hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                    File.Copy(textBox1.Text + "\\" + kopyalanacakdosyaAdi, hedefKlasor + "\\" + kopyalanacakdosyaAdi);
                    listBox8.SelectedIndex = listBox8.SelectedIndex + 1;
                    button9.PerformClick();

                }

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                listBox8.SelectedIndex = 0;
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

    }
}
