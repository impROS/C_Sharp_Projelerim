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
namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaninTasinacagiKlasor="";
        public static long KlasorBoyut(DirectoryInfo yol)
        {
            return yol.GetFiles().Sum(fi => fi.Length) +
            yol.GetDirectories().Sum(di => KlasorBoyut(di));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo klasoryolu = new DirectoryInfo(dosyaninTasinacagiKlasor);
            dosyaninTasinacagiKlasor = textBox1.Text;
            long boyutyol = KlasorBoyut(klasoryolu);
            MessageBox.Show("Taşınacak dosya boyutu" + boyutyol.ToString() + "byte");
        }
    }
}
