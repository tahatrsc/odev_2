﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boy; //Boy diye değişken tanımlıyoruz.
            double kilo; // Kilo değerinde sayısal veri tipi acıyoruz.
            string cinsiyet; // Cinsiyet diye bir değişken tanımlıyoruz.
            double inç = 2.54; // Virgüllü değer olduğu için double girildi. İnt tam sayı olarak değerlendirilir.

            double işlem; // küsüratlı işlem olabilir. bu yüzden double
            Console.WriteLine("Boyunuzu girin"); // Consolda bu yazı yazılacak
            boy = Convert.ToInt16(Console.ReadLine()); //Consoldan String değeri alındığı için Int'a ceviriyoruz (Convert Ediyoruz)


            Console.WriteLine("Kilonuzu girin"); // Consolda bu yazı yazılacak
            kilo = Convert.ToInt16(Console.ReadLine()); // Kilo bilgisini alıyoruz.

            Console.WriteLine("Cinsiyetinizi girin"); // Consolda bu yazı yazılacak
            cinsiyet = Console.ReadLine(); // Kilo bilgisini alıyoruz.
            
            if (cinsiyet == "kadın") // Cinsiyet değeri Kadın kelimesine eşitmi eşitse parantez içini
            {
                işlem = 45.5 +2.3*(boy / inç - 60); // Sayfa 27'deki förmülü buraya ekliyorum.
                if (kilo <= işlem) // Kilosu formülden kücük mü diye şart ekliyoruz.
                {
                    Console.WriteLine("İdeal kilodasınız."); // küçükse bu şartın karşılığında bu yazı ekrana yazıyor.
                }
                else // Eğer if (kilo <= işlem) şartını sağlamıyorsa else komudu devreye girer 
                {
                    Console.WriteLine("İdeal kiloda değilsiniz."); //İdeal kiloda olmadığını belirtir.
                }
            }
            if (cinsiyet == "erkek") 
            {
                işlem = 50 + 2.3 * (boy / inç - 60);
                if (kilo <= işlem)
                {
                    Console.WriteLine("İdeal kilodasınız.");
                }
                else
                {
                    Console.WriteLine("İdeal kiloda değilsiniz.");
                }
            }
        }
    }
}
