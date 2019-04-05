using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //içindeki dosyaları okumak istediğimiz klasörün dizin bilgisini veriyoruz.
            DirectoryInfo di = new DirectoryInfo(path);

            //FileInfo tipinden bir değişken oluşturuyoruz.
            //çünkü di.GetFiles methodu, bize FileInfo tipinden bir dizi dönüyor.
            FileInfo[] rgFiles = di.GetFiles();

            //foreach döngümüzle fgFiles içinde dönüyoruz.
            foreach (FileInfo fi in rgFiles)
            {
                var fileInfo = FileVersionInfo.GetVersionInfo("Dosya.dll");
                if (fi.ProductVersion != fi.FileVersion)
                {
                    // kopyalamayı yapabilirsin

                }
            }
        }
    }
}
