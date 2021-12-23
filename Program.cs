using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._12
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("boy: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("kilo: ");
            //double k = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("yil: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("cinsiyet: ");
            //string c = Convert.ToString(Console.ReadLine());




            //Ideal1 id = new Ideal1();
            //Console.WriteLine(id.Hesap(b,k,y,c));



            ////int c = Convert.ToInt32(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double t = Convert.ToDouble(Console.ReadLine());





            //Hacim hcm = new Hacim();
            //Console.WriteLine(hcm.HacimHesap(b,t));




            int sayi = 0;
                





            do
            {
                RandomTc uret = new RandomTc();
                Console.WriteLine("sayı giriniz: ");
                
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(uret.SayiTut(sayi));

            } while (sayi !=3);
            Console.WriteLine("program kapatılıyor..");
            
            
            
            Console.ReadKey();
        }
    }
}
