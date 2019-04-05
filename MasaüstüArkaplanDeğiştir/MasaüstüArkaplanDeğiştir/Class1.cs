using System;
using System.Runtime.InteropServices;
using System.Drawing;
using Microsoft.Win32;
namespace ChangeWallpaper
{
    public class Wallpaper
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Pozisyon : int
        {
            Tiled,
            Centered,
            Stretched
            // Resmi Döşe, Ortala, Sığdır 
        }

        public void ArkaPlaniDegistir(string path, Pozisyon Pozisyon)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true); // Wallpaperin tutulduğu registry Key’i açıyoruz. 
            switch (Pozisyon) //Keye yeni değeri atıyoruz. 
            {
                case Pozisyon.Stretched: key.SetValue(@"WallpaperPozisyon", "2");
                    key.SetValue(@"TileWallpaper", "0"); break;
                case Pozisyon.Centered: key.SetValue(@"WallpaperPozisyon", "1");
                    key.SetValue(@"TileWallpaper", "0"); break;
                case Pozisyon.Tiled: key.SetValue(@"WallpaperPozisyon", "1");
                    key.SetValue(@"TileWallpaper", "1"); break;
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE); // Ayarları Kaydediyoruz.
        }
    }
}