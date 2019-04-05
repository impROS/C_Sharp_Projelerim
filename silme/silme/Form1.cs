using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yol = "";

            DirectoryInfo dizin = new DirectoryInfo(@"C:\TRed Yazilim\Filtre");

            FileInfo[] dosyalar = dizin.GetFiles();

            string silinemeyen_dosyalar = "";

            for (int i = 0; o < dosyalar.Length; o++)
            {

                try
                {

                    dosyalar[o].Delete();

                }

                catch (Exception ex)
                {

                    silinemeyen_dosyalar += dosyalar[o].Name + "\n";

                }

            }

            MessageBox.Show(silinemeyen_dosyalar);
        }
    }
}
