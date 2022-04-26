using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDiemDanhSo2
{
    public class PTBac2
    {
        private double a_232;
        private double b_232;
        private double c_232;

        public double A_232 { get => a_232; set => a_232 = value; }
        public double B_232 { get => b_232; set => b_232 = value; }
        public double C_232 { get => c_232; set => c_232 = value; }

        public PTBac2(double a_232, double b_232, double c_232)
        {
            A_232 = a_232;
            B_232 = b_232;
            C_232 = c_232;          
        }

        public PTBac2()
        {
        }

        public static double Delta(double a_232, double b_232, double c_232)
        {
            return  (b_232 * b_232 - 4 * a_232 * c_232);
        }
        public static void ptb2(double a_232, double b_232, double c_232)
        {
           
            if (a_232 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c / b);
            }
            else
            {
                Double delta_232 = Delta(a_232, b_232, c_232);
                if (delta_232 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta_232 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b_232 / (2 * a_232));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", ((-b_232 + Math.Sqrt(delta_232)) / (2 * a_232)));
                    Console.WriteLine("x2 = {0}", ((-b_232 - Math.Sqrt(delta_232)) / (2 * a_232)));
                }
            }
        }
    }
}
