using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VietHoaDauChu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi vao: ");
            string s = Console.ReadLine();
            
            Console.WriteLine("Ket qua: " + VietHoa(s));
            Console.ReadLine();
        }

        static string VietHoa(string s)
        {
            string result = "";
            var Arr = s.Split(' '); // Chia chuỗi thành các mãng nhỏ dựa vào khoảng cách

            for(int i =0; i < Arr.Length; i++) // Duyệt qua các mãng
            {
                string j = Arr[i].Substring(0, 1); // Lây vị trí đầu tiên của mỗi mãng
                result += j.ToUpper() + Arr[i].Remove(0, 1) + " "; // Viết hoa vị trí đầu + phần còn lại của mãng + thêm khoảng trắng
            }
            return result;
        }
    }
}
