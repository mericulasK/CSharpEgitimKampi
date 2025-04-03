using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları 

            //Console.WriteLine("***** Yemek Kategorileri");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalıklar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, distcrict, city;

            //customerName = "Berkay";
            //customerSurname = "Adalı";
            //customerPhone = "+90 538 855 49 58";
            //customerEmail = "deneme@gmail.com";
            //distcrict = "Pınarhisar";
            //city = "Kırklareli";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + distcrict + "/" + city);


            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 300 80 70";
            //customerEmail = "test@gmail.com";
            //distcrict = "Sapanca";
            //city = "Sakarya";

         
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + distcrict + "/" + city);
            //Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 400;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " Tl ");
            Console.WriteLine("----- Kola: " + cokePrice + " Tl ");
            Console.WriteLine("----- limonata: " + lemonadePrice + " Tl ");
            Console.WriteLine("----- Kızartma: " + friesPrice + " Tl ");
            Console.WriteLine("----- Su: " + waterPrice + " Tl ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int pizzaCount;
            int friesCount;
            int lemonadeCount;

            int totalHamburgerPrice; 
            int totalCokePrice; 
            int totalFriesPrice ;
            int totalWaterPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            pizzaCount = 0;
            friesCount = 1;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Fiyatı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Pizza Fiyatı: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Su Fiyatı: " + totalWaterPrice + " TL ");
            Console.WriteLine("Kızartma Fiyatı: " + totalWaterPrice + " TL ");
            Console.WriteLine("Kola Fiyatı: " + totalCokePrice + " TL ");
            Console.WriteLine("Limonata Fiyatı: " + totalLemonadePrice + " TL ");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");
            #endregion
            Console.Read();



        }
    }
}
