using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int dong ,cot;
            Console.WriteLine("Nhap so dong: ");
            dong = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            cot = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(dong + " -" +  cot);

            int[,] array = new int[dong, cot];
                

            Console.ReadKey();
        }
    }
}
