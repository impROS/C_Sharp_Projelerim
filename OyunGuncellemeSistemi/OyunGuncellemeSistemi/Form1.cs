using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunGuncellemeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             Start:
            try
            {
                System.Diagnostics.Process.Start(@"C:\\impROS\\Joygame\\WolfTeamTS" + "\\deneme.exe");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                DialogResult dialogResult = MessageBox.Show("Yeniden Denensin mi ", "Dosya Bulunamıyor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    goto Start;

                }

            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox1.Location;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox2.Location;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox8.Location;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox3.Location;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox4.Location;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox5.Location;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox6.Location;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox7.Location;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox9.Location;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox10.Location;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox11.Location;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox12.Location;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox13.Location;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox14.Location;
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox15.Location;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox16.Location;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox17.Location;
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Location = pictureBox18.Location;
        }
        }
    }

