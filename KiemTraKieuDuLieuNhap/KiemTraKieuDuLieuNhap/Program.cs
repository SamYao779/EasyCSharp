using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraKieuDuLieuNhap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.WriteLine("Phai la so nguyen: ");
            }
            while (true);
            Console.WriteLine("\n\n{0} La so kieu so int !", n);
            Console.ReadLine();
        }
    }
}
