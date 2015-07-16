using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanDoiGiaTri2Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("nhap y: ");
            y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("X la : " + x + "\n" + "Y la : " + y);
            Console.ReadLine();
        }
    }
}
