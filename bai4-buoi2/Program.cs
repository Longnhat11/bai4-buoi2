using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so n: ");
            string n = Console.ReadLine();
            int Kiemtra;
            bool isNumeric = int.TryParse(n, out Kiemtra);
            while (isNumeric == false)
            {
                Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                n = Console.ReadLine();
                isNumeric = int.TryParse(n, out Kiemtra);
            }
            int i= 1;int GiaiThua = 1;
            if (Kiemtra > 0)
            {
                while (i <= Kiemtra)
                {
                    GiaiThua*= i;
                    i++;
                }
                Console.WriteLine("giai thua cua so "+Kiemtra+" la "+GiaiThua);
            }
            else { Console.WriteLine("khong the tinh giai thua so am!"); }
            Console.ReadKey();
        }
    }
}
