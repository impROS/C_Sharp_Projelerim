using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 10000;
            progressBar1.Visible = true;
            int i;
            for (i = 1; i <= 10000; i++)
            {
                progressBar1.Value = i;
                listBox1.Items.Add(i.ToString());
            }
            progressBar1.Value = 10000;

        }
    }
}
