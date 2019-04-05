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

namespace filtrekapa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.Directory.SetCurrentDirectory("C:\\");
                System.IO.Directory.Delete("TRed Yazilim", true);

            }
            catch
            {
                Process[] p;
                p = Process.GetProcessesByName(textBox1.Text) ;
                if (p.Length != 0)
                {
                    p[0].Kill();
                    System.IO.Directory.SetCurrentDirectory("C:\\");
                    System.IO.Directory.Delete("TRed Yazilim", true);
                }
            }
        }
    }
}