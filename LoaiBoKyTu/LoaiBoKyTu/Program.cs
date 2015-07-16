using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaiBoKyTu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            s = s.Replace("a", ""); //Loại bỏ chữ a trong chuỗi
            Console.WriteLine("Ket qua: {0}", s);
            Console.ReadLine();
        }
    }
}
