using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static int TotalinArray(int []arr, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + arr[i];
            }
            return tong;
        }
         public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so phan tu cua mang:  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mang co  " + n + " phan tu");
            
            int []array = new int[n];
            Console.WriteLine("===Nhap Mang===");
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[" + i + "]: ");
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("===Xuat Mang===");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("array[" + i + "]: " + array[i]);
            }

            // Đảo ngược mảng
            int temp = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    
                }
            }
            Console.WriteLine("===Mang sau khi da dao nguoc la===");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("array[" + i + "]: " + array[i]);
            }
            Console.WriteLine("===tong cac phan tu trong mang la: " + TotalinArray(array, n));
            Console.ReadKey();

        }
    }
}
