using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
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

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo inf = new FileInfo(kaynakBox.Text);
//eğer dosyamız hedef klasöründe varsa
if (File.Exists(hedefBox.Text + "\\" + inf.Name))
{
//hedefteki dosya bilgisi
FileInfo inf2 = new FileInfo(hedefBox.Text + "\\" + inf.Name);
if (inf.Length != inf2.Length) //kaynaktak ve hedefteki dosya boyutu aynı değilse
{
    File.Create 
File.Copy(kaynakBox.Text, hedefBox.Text + "\\" + inf.Name, true);
}
}
}
        }
    }

