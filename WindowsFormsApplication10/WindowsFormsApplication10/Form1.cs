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

namespace WindowsFormsApplication10
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
        public static void copyDirectory(string Src, string Dst)
        {

            String[] Files;



            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)

                Dst += Path.DirectorySeparatorChar;

            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);

            Files = Directory.GetFileSystemEntries(Src);

            foreach (string Element in Files)
            {

                // Dizindeki Alt Klasörler

                if (Directory.Exists(Element))

                    copyDirectory(Element, Dst + Path.GetFileName(Element));

                // Dizindeki Dosyalar

                else

                    File.Copy(Element, Dst + Path.GetFileName(Element), true);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            copyDirectory(Application.StartupPath + "\\tasinacakklasor\\", saveFileDialog1.FileName);
        }
    }
}
