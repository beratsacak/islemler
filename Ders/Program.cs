using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dortislem dortislem = new Dortislem();
            Console.Write("Sayı Gir : ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Gir :");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            dortislem.toplama(sayi1 , sayi2);
            dortislem.cıkarma(sayi1 , sayi2);
            dortislem.carpma(sayi1, sayi2);
            dortislem.bolme(sayi1 , sayi2);
        }
    }
    public class Dortislem
    {
        
        public double toplama(double sayi1, double sayi2)
        {
            Console.WriteLine("Toplama Sonucu= "+(sayi1+sayi2));
            return sayi1 + sayi2; 
        }
        public double cıkarma(double sayi1, double sayi2)
        {
            Console.WriteLine("Çıkarma Sonucu= "+ (sayi1 - sayi2));
            return sayi1-sayi2;
        }
        public double carpma(double sayi1, double sayi2)
        {
            Console.WriteLine("Çarpma Sonucu= " + (sayi1 * sayi2));
            return sayi1 * sayi2;
        }
        public double bolme(double sayi1, double sayi2)
        {
            Console.WriteLine("Bölme Sonucu= " + (sayi1 / sayi2));
            return sayi1 / sayi2;
        }


    }
}
