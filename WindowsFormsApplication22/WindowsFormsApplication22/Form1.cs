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
namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dene;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            
            {
                dene = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception ex)
            {

            MessageBox.Show(ex.Message);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                dene = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
timer1.Enabled = false;
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
