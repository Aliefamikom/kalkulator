using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "kalkulator";
            // int a = 10; //declarasi variabel a, dengan nilai awal 10;
            // int b = 6; // declarasi variabel b, dg nilai awal 6;

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());//proses casting

            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());//proses casting

            Console.WriteLine();//tambah baris kosong

            Console.WriteLine("1. hasil penambahan "); 
            Console.WriteLine("2. hasil pengurangan ");
            Console.WriteLine("3. hasil perkalian ");
            Console.WriteLine("4. hasil pembagian ");

            Console.WriteLine("pilih menu");
            int pilih;
            pilih = Convert.ToInt32(Console.ReadLine());
            switch(pilih)
            { 
                case 1:
                    Console.WriteLine(a + b);
                    Console.ReadKey(); break;

                case 2:
                    Console.WriteLine(a - b);
                    Console.ReadKey(); break;

                case 3:
                    Console.WriteLine(a * b);
                    Console.ReadKey(); break;

                case 4:
                    Console.WriteLine(a / b);
                    Console.ReadKey(); break;

                default:
                    Console.WriteLine("menu tidak tersedia !!!");
                    Console.ReadKey(); break;

            }


        }


    }
}
