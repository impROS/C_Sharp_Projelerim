using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerçekzamanlıkronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
int salise,salise2,salise3=DateTime.Now.Millisecond,saniye,dakika,saat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label5.Text != DateTime.Now.Second.ToString())
            {
                salise = salise + 1;
                label1.Text = salise.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
