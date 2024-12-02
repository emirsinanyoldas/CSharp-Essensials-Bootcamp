using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            /*Console.WriteLine("hello world");
            Console.WriteLine("hello world");*/

            //Console.WriteLine("hello world");
            //Console.WriteLine("how are you today?");

            /*
            string assey1 = Console.ReadLine();
            Console.WriteLine(assey1);
            */

            /*Console.WriteLine("Bir yazı giriniz: ");
            string yazi1 = Console.ReadLine();
            Console.WriteLine($" ekrandan alınan kelime: {yazi1}");     
            //yazı içerisinde hem ifade hemde yazı kullandım


            Console.WriteLine("Bir sayı giriniz: ");
            int sayi;
            sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"girilen sayı: {sayi}");
            */

            /*for (int i = 10; i >= 0; i --)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Space shuttle lifts off");
            */

            /*int a = 5;
            while (a > 0)
            {
                Console.WriteLine(a);
                a--;        //a++ yapınca sonsuz döngü oluyor
            }
            */


            /*int b = 5;
            do
            {
                Console.WriteLine("Hello");
                b--;
            }
            while (b >= 0);
            */

            /*Console.WriteLine("Enter a number please: ");
            
            int sayi1;
            sayi1=Convert.ToInt32(Console.ReadLine());  
            //ekrana yazılan yazıyı int 32 ye dönüştürüp alıyoruz

            if (sayi1 == 5)
            {
                Console.WriteLine("The number is equal to 5");
            }
            else if (sayi1 == 6)
            {
                Console.WriteLine("The number is equal to 6");
            }
            else if (sayi1 == 7)
            {
                Console.WriteLine("The number is equal to 7");
            }
            else
            {
                Console.WriteLine("Sayı kontrol edilen sayıdan farklıdır");
            }
            */

            /*int a = 5;
            int b = 6;
            if ((a == 5) && (b == 6))
            {
                Console.WriteLine("Girilen sayılar istenildiği gibi.");
            }
            else
            {
                Console.WriteLine("Sayı değerleri farklıdır.");
            */

            /*int z = 4, x = 5;
            if ((z > 4) && (x > 5))
            {
                Console.WriteLine("Girilen sayılar istenildiği gibi.");
            }
            else
            {
                Console.WriteLine("Sayı değerleri farklıdır.");
            }
            */

            /*int sayi4 = 21;
            switch (sayi4)
            {
                case 0:
                    Console.WriteLine("Sayı 0'dır.");
                    break;
                case 1:
                    Console.WriteLine("Sayı 1'dir.");
                    break;
                case 2:
                    Console.WriteLine("Sayı 2'dir.");
                    break;
                case 3:
                    Console.WriteLine("Sayı 3'dür.");
                    break;
                default:
                    Console.WriteLine("Sayı bilinmiyor");
                    break;
            }
            */

            string word = "hello world";
            switch (word)
            {
                case "merhaba":
                    Console.WriteLine($"Var olan kelime: {word}");
                    break;
                case "wassup":
                    Console.WriteLine($"Var olan kelime: {word}");
                    break;
                case "hello":
                    Console.WriteLine($"Var olan kelime: {word}");
                    break;
                default:
                    Console.WriteLine("Var olan kelime bulunamadı");
                    break;
            }
        }
    }
}
