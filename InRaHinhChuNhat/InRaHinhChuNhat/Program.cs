using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRaHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao: ");
            int cao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap chieu rong: ");
            int rong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cao; i++)
            {
                for (int j = 0; j < rong; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
