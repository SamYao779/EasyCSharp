using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen: ");
            n = int.Parse(Console.ReadLine());
            bool flag = n > 1 ? true : false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    flag = false;
                break;
            }

            if (flag == true)
                Console.WriteLine("{0} La so nguyen to !", n);
            else
                Console.WriteLine("{0} Khong la so nguyen to !", n);
            Console.ReadLine();
        }
    }
}
