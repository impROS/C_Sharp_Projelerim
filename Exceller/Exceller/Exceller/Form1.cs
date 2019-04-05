using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        string s_dosyaadi = "";
        string s_veri = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void b_kaydet_Click(object sender, EventArgs e)
        {
            s_dosyaadi = t_dosyaadi.Text;
            if (s_dosyaadi != "")
            {
                ExcelProje.SaveAs(Application.StartupPath + @"\" + s_dosyaadi + ".xlsx", Excel.XlFileFormat.xlWorkbookDefault, Missing, Missing, false, Missing, Excel.XlSaveAsAccessMode.xlNoChange);
                ExcelProje.Close(true, Missing, Missing);
                ExcelUygulama.Quit();

                MessageBox.Show("Dosya Başarıyla Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen Bir Dosya Adı Giriniz.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelUygulama = new Excel.Application();
            ExcelProje = ExcelUygulama.Workbooks.Add(Missing);
            ExcelSayfa = (Excel.Worksheet)ExcelProje.Worksheets.get_Item(1);
            ExcelRange = ExcelSayfa.UsedRange;
            ExcelSayfa = (Excel.Worksheet)ExcelUygulama.ActiveSheet;

            ExcelUygulama.Visible = false;
            ExcelUygulama.AlertBeforeOverwriting = false;
        }

        private void b_yaz_Click(object sender, EventArgs e)
        {
            rowCnt = (int)t_row.Value;
            columnCnt = (int)t_column.Value;
            s_veri = t_veri.Text;
            if (s_veri != "" && rowCnt != 0 && columnCnt != 0)
            {
                Excel.Range bolge = (Excel.Range)ExcelSayfa.Cells[rowCnt, columnCnt];
                bolge.Value2 = s_veri;

                MessageBox.Show("İlgili bloğa başarıyla yazıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir veri giriniz. (Satır veya Sütun sıfır olamaz.)");
            }
            
        }

    }
}
