using System;
using System.Collections.Generic;
using System.IO;

public class Directories
{
    public static void CopyDirectory(string SourceFolderPath, string TargetFolderPath)
    {
        String[] files;

        if (TargetFolderPath[TargetFolderPath.Length - 1] != Path.DirectorySeparatorChar)
        {
            TargetFolderPath += Path.DirectorySeparatorChar;
        }

        // parametre olarak verilen hedef dizin yok ise oluştur.
        if (!Directory.Exists(TargetFolderPath))
        {
            Directory.CreateDirectory(TargetFolderPath);
        }

        // kaynak dizindeki tüm alt dizin ve dosya adlarını al.
        files = Directory.GetFileSystemEntries(SourceFolderPath);

        foreach (string file in files)
        {
            // alt dizinler
            if (Directory.Exists(file))
            {
                // metot öz yineleme (recursive) kullanarak kaynak dizinde dosya bulunduğu
                // müddetçe dizindeki tüm dosyalar hedef dizine kopyalanmaya devam ediyor.
                CopyDirectory(file, TargetFolderPath + Path.GetFileName(file));
            }

            // dizindeki dosyalar
            else
            {
                File.Copy(file, TargetFolderPath + Path.GetFileName(file), true);
            }
        }
    }
}