using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Left = button1.Left;
            button2.Width = button1.Width;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button3.Height=this.Height-200;
            button4.Height = button3.Height;
            button4.Width = button4.Width;
            button4.Left = button4.Left;

        }
    }
}
