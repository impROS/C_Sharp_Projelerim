using System;
using System.Windows.Forms;
namespace program_hızı
{
    public partial class Form1 : Form
    {
        int deneme1, deneme2;
        string deneme3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(deneme1.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
