﻿using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using System.IO;

namespace DosyaKoplayama { public partial class Form1 : Form { public Form1() { InitializeComponent(); }

string kopyalanacakDosya = "", dosyanınKopyanacagiKlasor = "", kopyalanacakDosyaIsmi = "";

private void button3_Click(object sender, EventArgs e) {

kopyalanacakDosya = textBox1.Text; dosyanınKopyanacagiKlasor = textBox2.Text; openFileDialog1.FileName = textBox1.Text; kopyalanacakDosyaIsmi = openFileDialog1.SafeFileName.ToString(); if (dosyanınKopyanacagiKlasor != "" && kopyalanacakDosya != "") { if (File.Exists(dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi)) { FileInfo inf = new FileInfo(textBox1.Text); //eğer dosyamız hedef klasöründe varsa if (File.Exists(textBox2.Text + "\\" + inf.Name)) { //hedefteki dosya bilgisi FileInfo inf2 = new FileInfo(textBox2.Text + "\\" + inf.Name); MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi); MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı..."); } } else if (dosyanınKopyanacagiKlasor == "") { MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else if (kopyalanacakDosya == "") { MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } } } }