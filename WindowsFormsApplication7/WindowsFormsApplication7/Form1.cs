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
using System.Diagnostics;
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "FKontrol.exe")
                    p.Kill();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Process.Start("taskkill /F /IM Filtre.exe");
            Process.Start("taskkill /F /IM FKontrol.exe");
            

            System.IO.Directory.SetCurrentDirectory("C:\\");

            System.IO.Directory.Delete("TRed Yazilim", true);
        }
    }
}
