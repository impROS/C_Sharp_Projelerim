using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System; // bunu her zaman eklememiz lazim
using System.IO; //StreamReader ve StreamWriter siniflari için
using System.Net.Sockets; // Socket, TcpListener ve NetworkStrem siniflari için

namespace socketilişkisi
{
    public class Server
    {

        public static void Main()
        {

            //Bilgi alisverisi için bilgi almak istedigimiz port numarasini TcpListener sinifi ile gerçeklestiriyoruz

            TcpListener TcpDinleyicisi = new TcpListener(1234);
            TcpDinleyicisi.Start();

            Console.WriteLine("Sunucu baslatildi...");

            //Soket baglantimizi yapiyoruz.Bunu TcpListener sinifinin AcceptSocket metodu ile yaptigimiza dikkat edin
            Socket IstemciSoketi = TcpDinleyicisi.AcceptSocket();


            // Baglantının olup olmadığını kontrol ediyoruz
            if (!IstemciSoketi.Connected)
            {
                Console.WriteLine("Sunucu baslatilamiyor...");
            }
            else
            {
                //Sonsuz döngü sayesinde AgAkimini sürekli okuyoruz
                while (true)
                {
                    Console.WriteLine("Istemci baglantisi saglandi...");

                    //IstemciSoketi verilerini NetworkStream sinifi türünden nesneye aktariyoruz.
                    NetworkStream AgAkimi = new NetworkStream(IstemciSoketi);

                    //Soketteki bilgilerle islem yapabilmek için StreamReader ve StreamWriter siniflarini kullaniyoruz
                    StreamWriter AkimYazici = new StreamWriter(AgAkimi);
                    StreamReader AkimOkuyucu = new StreamReader(AgAkimi);


                    //StreamReader ile String veri tipine aktarma islemi önceden bir hata olursa bunu handle etmek gerek
                    try
                    {
                        string IstemciString = AkimOkuyucu.ReadLine();

                        Console.WriteLine("Gelen Bilgi:" + IstemciString);

                        //Istemciden gelen bilginin uzunlugu hesaplaniyor
                        int uzunluk = IstemciString.Length;

                        //AgAkimina, AkimYazını ile IstemciString inin uzunluğunu yazıyoruz 
                        AkimYazici.WriteLine(uzunluk.ToString());

                        AkimYazici.Flush();
                    }

                    catch
                    {
                        Console.WriteLine("Sunucu kapatiliyor...");
                        return;
                    }
                }
            }

            IstemciSoketi.Close();
            Console.WriteLine("Sunucu Kapatiliyor...");
        }
    }
}