using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {


            //SelamVer("Furkan");
            //SelamVer();


            //int sonuc=   Topla(3,5);


            //Diziler-Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Ahmet";
            string ogrenci3 = "Sevde";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Ahmet";
            ogrenciler[2] = "Sevde";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1=new Person();
            person1.FirstName = "AHMET FURKAN";
            person1.LastName = "ÇELİK";
            person1.DateOfBrithYear = 1998;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Furkan";

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> yeniSehierler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehierler1.Add("Sakarya");
            foreach (var sehir in yeniSehierler1)
            {
                Console.WriteLine(sehir);
            }





            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
        static void SelamVer(string isim="")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        
        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc);
            return sonuc;
        }


    }
}