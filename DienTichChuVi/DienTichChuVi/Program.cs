using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienTichChuVi
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            Console.Write("Nhap chieu dai: ");
            hcn.ChieuDai = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap chieu rong: ");
            hcn.ChieuRong = double.Parse(Console.ReadLine());

            Console.WriteLine("Chu Vi = " + hcn.ChuVi());
            Console.WriteLine("Dien Tich = " + hcn.DienTich());
            Console.ReadLine();
        }
    }
}
