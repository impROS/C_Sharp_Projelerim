using ChangeWallpaper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
namespace MasaüstüArkaplanDeğiştir
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Wallpaper w = new Wallpaper();
            string arkaplan = Environment.CurrentDirectory + "\\arkaplanlar\\Adsız.bmp";
             textBox1.Text=arkaplan ;
             w.ArkaPlaniDegistir(textBox1.Text, Wallpaper.Pozisyon.Centered); 

        }


    }
}
