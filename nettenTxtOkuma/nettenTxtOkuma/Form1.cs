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

namespace nettenTxtOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Listbox'ı temizle
            listBox1.Items.Clear();

            // Dosyamızı okuyacak.
            StreamReader oku;

            // Belirtmiş olduğum yoldaki dosyayı açacak. 
            /* NOT: @ bu işareti koymamın nedeni \\ 2 defa bundan 
            yapmamak içindir. */
            oku = File.OpenText(textBox1.Text);

            string yazi;

            // Satır boş olana kadar okumaya devam eder.
            while ((yazi = oku.ReadLine()) != null)
            {
                // Listbox'ı .txt içeriği ile doldur.
                listBox1.Items.Add(yazi.ToString());
            }

            // Okumayı kapat.
            oku.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Size = new System.Drawing.Size(listBox1.Width + 10, listBox1.Height);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.IntegralHeight = false;
            listBox1.Height = listBox1.Height+10;
        }
         
    }
}
