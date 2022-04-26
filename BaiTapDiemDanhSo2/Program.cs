using System;

namespace BaiTapDiemDanhSo2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Nhap a = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            c = Double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh co dang {0}x^2 + {1}x + {2}", a, b, c);
            PTBac2 pt = new PTBac2();
            PTBac2.ptb2(a, b, c);

        }
    }
}
