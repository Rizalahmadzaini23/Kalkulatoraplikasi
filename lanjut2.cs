using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanjut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. penjumlahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");

            Console.WriteLine();
            Console.Write("ïnput nomer menu[1 - 4]:");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (input > 4|| input < 1)
            {
                Console.WriteLine("maaf, menu tidak tersedia");
                pesan();
            }
            else
            {
                Console.Write("input nilai a :");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("input nilai b :");
                int b = Convert.ToInt32(Console.ReadLine());

                if(input == 1)

                {
                    Console.WriteLine("hasil penjumlahan {0} + {1} = {2}", a, b, penambahan(a, b));
                }
                else if(input == 2)
                {
                    Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                }
                else if (input == 3)
                {
                    Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                }
                else if (input == 4)
                {
                    Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                }
                pesan();


            }
        }
        static int penambahan (int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static float pembagian(float a, float b)
        {
            return a / b;
        }
        static void pesan()
        {
            Console.WriteLine();
            Console.Write("tekan sembarang untuk keluar....");
            Console.ReadKey();
        }
    }
}
