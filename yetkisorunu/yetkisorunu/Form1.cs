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

namespace yetkisorunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            //Çalışma yolu tanımlanır
            string yol = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "\\BenimProgramım\\BenimVeriKlasorum\\");


            //o dizin var mı kontrol ediliyor. Yoksa if bloğu içindeki kod çalışır.
            if (!System.IO.Directory.Exists(yol))
            {
                //belirtilen yoldaki dizini bir zahmet yarat ki program patlamasın.
                System.IO.Directory.CreateDirectory(yol);
            }
            //bilgi verilir.
            MessageBox.Show(string.Format("Klasör full yetkiyle kullanıma açıldı\n\nYol: {0}", yol));


            //explorer.exe ile yaratılan dizin açılıverir.
            System.Diagnostics.Process.Start("explorer.exe", " " + yol);


            //dizinle ilgili ne yapacaksan yol değişkeni ile yolu belirtirsin.
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(yol + "Benimdosyam.txt", false))
            {
                sw.WriteLine("Merhaba cnm benim");
                sw.WriteLine(string.Format("Ben bu dizinde yaratıldım : '{0}'", yol));
                sw.WriteLine("İyi günlerde kullan...");
            }
            //yaratılan dosyayı çalıştır. Notepad açılıcak büyük olasılık :P
            System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\Run.exe");
            System.Diagnostics.Process.Start("notepad.exe" + yol + "Benimdosyam.txt");
        }
    }
}
