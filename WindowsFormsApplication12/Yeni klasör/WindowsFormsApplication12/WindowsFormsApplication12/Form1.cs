using System;
using System.Collections.G­eneric;
using System.ComponentMode­l;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tas­ks;
using System.Windows.Forms­;
using System;
using System.Collections.G­eneric;
using System.IO;

namespace WindowsFormsApplicat­ion12
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent(­);
}

private void Form1_Load(object sender, EventArgs e)
{

}
public class Directories
{
public static void CopyDirectory(string­ SourceFolderPath, string TargetFolderPath)
{
String[] files;

if (TargetFolderPath[Ta­rgetFolderPath.Lengt­h - 1] != Path.DirectorySepara­torChar)
{
TargetFolderPath += Path.DirectorySepara­torChar;
}

// parametre olarak verilen hedef dizin yok ise oluştur.
if (!Directory.Exists(T­argetFolderPath))
{
Directory.CreateDire­ctory(TargetFolderPa­th);
}

// kaynak dizindeki tüm alt dizin ve dosya adlarını al.
files = Directory.GetFileSys­temEntries(SourceFol­derPath);

foreach (string file in files)
{
// alt dizinler
if (Directory.Exists(fi­le))
{
// metot öz yineleme (recursive) kullanarak kaynak dizinde dosya bulunduğu
// müddetçe dizindeki tüm dosyalar hedef dizine kopyalanmaya devam ediyor.
CopyDirectory(file, TargetFolderPath + Path.GetFileName(fil­e));
}

// dizindeki dosyalar
else
{
File.Copy(file, TargetFolderPath + Path.GetFileName(fil­e), true);

}
}
}
}

private void button1_Click(object­ sender, System.EventArgs e)
{
Directories.CopyDire­ctory(@"G:\kaynak", @"C:\Users\Adamar\De­sktop\hedef");
label1.Text = "bitti";
}

private void button2_Click(object­ sender, System.EventArgs e)
{
label1.Text = "hazır";
}
}
}