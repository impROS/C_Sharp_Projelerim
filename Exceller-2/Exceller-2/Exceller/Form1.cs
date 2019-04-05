using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace Exceller
{
    public partial class Form1 : Form
    {
        Excel.Application ExcelUygulama;
        Excel.Workbook ExcelProje;
        Excel.Worksheet ExcelSayfa;
        object Missing = System.Reflection.Missing.Value;
        Excel.Range ExcelRange;

        int rowCnt = 0;
        int columnCnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.ProcessName == "EXCEL") //p.ProcessName == "baykar_form.vshost"
                {
                    p.Kill();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            ExcelUygulama = new Excel.Application();
            ExcelProje = ExcelUygulama.Workbooks.Open(openFileDialog1.FileName);
            ExcelSayfa = (Excel.Worksheet)ExcelProje.Worksheets.get_Item(1);
            ExcelRange = ExcelSayfa.UsedRange;
            ExcelSayfa = (Excel.Worksheet)ExcelUygulama.ActiveSheet;

            ExcelUygulama.Visible = false;
            ExcelUygulama.AlertBeforeOverwriting = false;

            label1.Text = openFileDialog1.FileName+" adlı dosya yüklendi.";

            rowCnt = ExcelRange.Rows.Count + 1;
            columnCnt = ExcelRange.Columns.Count + 1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ExcelProje.Close();
                ExcelUygulama.Quit();
            }
            catch (Exception)
            {

                throw;
            }

            releaseObject(ExcelSayfa);
            releaseObject(ExcelProje);
            releaseObject(ExcelUygulama);

            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.ProcessName == "EXCEL")
                {
                    p.Kill();
                }
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sdbconnection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + openFileDialog1.FileName + "; Extended Properties='Excel 12.0; TypeGuessRows=0; HDR=YES; IMEX=1'";
            OleDbConnection dbconnection = new OleDbConnection(sdbconnection);
            dbconnection.Open();
            OleDbDataAdapter dbadapter = new OleDbDataAdapter("Select * from [Sayfa1$]", dbconnection);
            DataTable dtable = new DataTable();
            dbadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void yenile()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                object hucre = ExcelSayfa.Cells[numericUpDown1.Value, numericUpDown2.Value];
                Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                if (bolge.Value2 != null)
                {
                    string veri = bolge.Value2.ToString();
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add(veri);
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.Items.Add("");
                    MessageBox.Show("Bos bir alan sectiniz.");
                }
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                comboBox1.Items.Clear();
                for (int i = 1; i < columnCnt; i++)
                {
                    object hucre = ExcelSayfa.Cells[numericUpDown1.Value, i];
                    Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                    if (bolge.Value2 != null)
                    {
                        string veri = bolge.Value2.ToString();
                        comboBox1.Items.Add(veri);
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1.Items.Add("");
                        MessageBox.Show("Bos bir alan sectiniz.");
                    }
                }
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                comboBox1.Items.Clear();
                for (int i = 1; i < rowCnt; i++)
                {
                    object hucre = ExcelSayfa.Cells[i, numericUpDown2.Value];
                    Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                    if (bolge.Value2 != null)
                    {
                        string veri = bolge.Value2.ToString();
                        comboBox1.Items.Add(veri);
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1.Items.Add("");
                        MessageBox.Show("Bos bir alan sectiniz.");
                    }
                }
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                comboBox1.Items.Clear();
                for (int i = 1; i < rowCnt; i++)
                {
                    for (int a = 1; a < columnCnt; a++)
                    {
                        object hucre = ExcelSayfa.Cells[i, a];
                        Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                        if (bolge.Value2 != null)
                        {
                            string veri = bolge.Value2.ToString();
                            comboBox1.Items.Add(veri);
                            comboBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            comboBox1.Items.Add("");
                            MessageBox.Show("Bos bir alan sectiniz.");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                object hucre = ExcelSayfa.Cells[numericUpDown1.Value, numericUpDown2.Value];
                Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                bolge.Value2 = textBox1.Text;
                yenile();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                object hucre = ExcelSayfa.Cells[comboBox1.SelectedIndex + 1, numericUpDown2.Value];
                Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                bolge.Value2 = textBox1.Text;
                yenile();
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                object hucre = ExcelSayfa.Cells[numericUpDown1.Value, comboBox1.SelectedIndex + 1];
                Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
                bolge.Value2 = textBox1.Text;
                yenile();
            }

            textBox1.Text = "";

            try
            {
                ExcelProje.Save();
            }
            catch (Exception)
            {

                MessageBox.Show("Düzenleme Yapılan Dosyanın Kapalı Olduğundan Emin Olunuz...");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelProje.Save();
            }
            catch (Exception)
            {

                MessageBox.Show("Düzenleme Yapılan Dosyanın Kapalı Olduğundan Emin Olunuz...");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object hucre = ExcelSayfa.Cells[dataGridView1.CurrentCell.RowIndex + 2, dataGridView1.CurrentCell.ColumnIndex + 1];
            Excel.Range bolge = ExcelSayfa.get_Range(hucre, hucre);
            bolge.Value2 = dataGridView1.CurrentCell.Value;
        }
    }
}
