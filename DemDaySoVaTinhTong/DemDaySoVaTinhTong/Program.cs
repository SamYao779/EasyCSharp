using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemDaySoVaTinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.Write("Nhap day so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n.ToString().Length; i++)
            {
                s += i;
            }
            int c = n.ToString().Count();
            Console.WriteLine("\nTong cua day so {0} la {1} va co {2} ky tu !", n, s, c);
            Console.ReadLine();
        }
    }
}
