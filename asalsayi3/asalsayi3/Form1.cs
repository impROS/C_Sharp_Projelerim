using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalsayi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
int i, j;
   Boolean asal;
   listBox1.Items.Clear();
   for (i = int.Parse(textBox1.Text); i<= int.Parse(textBox2.Text); i++)
   {
       label2.Text = i.ToString();
    asal = true;

    for (j = 2; j <= i - 1; j++)
    {

     Application.DoEvents();
     if ((i % j) == 0) 
     {
      //Tam bölünüyorsa asal değil
      asal = false;
      break;
     }
    }
    if (asal) 
     listBox1.Items.Add(i);
   }
label1.Text="bitti";
  }
   }
  }
