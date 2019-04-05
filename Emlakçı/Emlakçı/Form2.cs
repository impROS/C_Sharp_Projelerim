using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlakçı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox2.Items.Add(comboBox2.Text);
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(textBox3.Text);
            listBox6.Items.Add(comboBox4.Text);
            listBox7.Items.Add(comboBox3.Text);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 10; i <= 150; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 tv = new Form3();
            tv.Show();
            this.Hide();
        }
    }
}
