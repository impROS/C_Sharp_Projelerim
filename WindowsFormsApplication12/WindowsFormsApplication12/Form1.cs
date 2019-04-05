using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApplication12
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
        public class Directories
        {
            public static void CopyDirectory(string SourceFolderPath, string TargetFolderPath)
            {
                String[] files;

                if (TargetFolderPath[TargetFolderPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    TargetFolderPath += Path.DirectorySeparatorChar;
                }

                // parametre olarak verilen hedef dizin yok ise oluştur.
                if (!Directory.Exists(TargetFolderPath))
                {
                    Directory.CreateDirectory(TargetFolderPath);
                }

                // kaynak dizindeki tüm alt dizin ve dosya adlarını al.
                files = Directory.GetFileSystemEntries(SourceFolderPath);
                
                
                foreach (string file in files)
                {
                    // alt dizinler
                    if (Directory.Exists(file))
                    {
                        // metot öz yineleme (recursive) kullanarak kaynak dizinde dosya bulunduğu
                        // müddetçe dizindeki tüm dosyalar hedef dizine kopyalanmaya devam ediyor.
                        CopyDirectory(file, TargetFolderPath + Path.GetFileName(file));
                    }

                    // dizindeki dosyalar
                    else
                    {
                        File.Copy(file, TargetFolderPath + Path.GetFileName(file), true);
        
                    }
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string[] filesa;
            Directories.CopyDirectory(@"G:\kaynak", @"C:\Users\Adamar\Desktop\hedef");
            filesa = Directory.GetFileSystemEntries(@"G:\kaynak");
            listBox1.Items.Add(filesa);
            label1.Text = "bitti";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            label1.Text = "hazır";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
