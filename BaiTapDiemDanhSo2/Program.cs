using System;

namespace BaiTapDiemDanhSo2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double a_232, b_232, c_232;
            Console.Write("Nhap a = ");
            a_232 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b_232 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            c_232 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh co dang {0}x^2 + {1}x + {2}", a_232, b_232, c_232);
            PTBac2 pt = new PTBac2();
            PTBac2.ptb2(a_232, b_232, c_232);

        }
    }
}
