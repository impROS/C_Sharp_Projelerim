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
using System.Threading;
namespace filtrekapat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button5.PerformClick();
            System.IO.Directory.SetCurrentDirectory("C:\\");
            System.IO.Directory.Delete("TRed Yazilim", true);
            button1.PerformClick();
            }
            catch
            {
                try
                {
                    button5.PerformClick();
                    button1.PerformClick();
                    button2.PerformClick();
                    System.IO.Directory.SetCurrentDirectory("C:\\");
                    System.IO.Directory.Delete("TRed Yazilim", true);
                }
                catch { }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\Run.exe");
                System.IO.Directory.SetCurrentDirectory("C:\\");
                System.IO.Directory.Delete("TRed Yazilim", true);

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            button5.PerformClick();
            button5.PerformClick();
            button5.PerformClick();
            button1.PerformClick();
            button1.PerformClick();
            button5.PerformClick();
            button6.PerformClick();
}

        private void button4_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
            button2.PerformClick();
            MessageBox.Show("Filtre Başarıyla Devre Dışı Bırakılmıştır","impROS");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            foreach (System.Diagnostics.Process pa in System.Diagnostics.Process.GetProcesses())
                if (pa.ProcessName == "Filtre")
                    pa.Kill();
            System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\Filtre.exe");
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "FKontrol")
                    p.Kill();
            System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\FKontrol.exe");
            foreach (System.Diagnostics.Process pc in System.Diagnostics.Process.GetProcesses())

            foreach (System.Diagnostics.Process pb in System.Diagnostics.Process.GetProcesses())
                if (pb.ProcessName == "Run")
                    pb.Kill();
            System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\Run.exe");
                }
                catch { }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo dosyabilgisi = new FileInfo(@"C:\TRed Yazilim\Filtre\Run.exe");
                dosyabilgisi.IsReadOnly = false;
                string dosyaAdi = @"C:\TRed Yazilim\Filtre\Run.exe";
                File.SetAttributes(dosyaAdi, FileAttributes.Normal);
                System.IO.File.Delete(@"C:\TRed Yazilim\Filtre\Run.exe");
            }
            catch { }
        }
}
}
      