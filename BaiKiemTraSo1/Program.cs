using System;

namespace BaiKiemTraSo1
{
    class Program
    {
        static void PhepTinh(Double a_32, Double b_32)
        {
            Console.Write("Tong, Hieu, Tich, Thuong cua {0} va {1} la: {2}, {3}, {4}, {5}", a_32, b_32, a_32 + b_32, a_32 - b_32, a_32 * b_32, a_32 / b_32);
            Console.ReadLine();
        }

        static int ChuyenDoi(int soThapPhan_32)
        {
            string result_32 = "";
            while (soThapPhan_32 > 1)
            {
                int conlai_32 = soThapPhan_32 % 2;
                result_32 = Convert.ToString(conlai_32) + result_32;
                soThapPhan_32 /= 2;
            }
            result_32 = Convert.ToString(soThapPhan_32) + result_32;
            int soNhiPhan = Int32.Parse(result_32);
            return soNhiPhan;

        }
        static void ThongTinSinhVien()
        {
            Console.WriteLine("Ho ten: Nguyen Hoang Ke Long");
            Console.WriteLine("Lop hoc phan: 221LTC02");
            Console.WriteLine("Ma sinh vien: 191150531032");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("            ============BAI TAP============");
                Console.WriteLine("Bai 1:   In ra tong hieu tich thuong cua 2 so nhap vao ban phim cho truoc");
                Console.WriteLine("Bai 2:   In ra la co Viet Nam bang dau = va *");
                Console.WriteLine("Bai 3:   Doi so thap phan thanh so nhi phan tu so thap phan nhap tu ban phim.");
                Console.WriteLine("Bai 4:   In ra thong tin ban than (Ho ten, lop, masv)");
                Console.Write("Chon bai: ");
                int bai_32 = Int32.Parse(Console.ReadLine());

                switch (bai_32)
                {
                    case 0:
                        return;
                    case 1:
                        Console.Clear();
                        #region
                        Double a_32, b_32;
                        Console.Write("Nhap a: ");
                        a_32 = Double.Parse(Console.ReadLine());
                        Console.Write("Nhap b: ");
                        b_32 = Double.Parse(Console.ReadLine());
                        PhepTinh(a_32, b_32);
                        #endregion
                       
                        break;
                    case 2:
                        Console.Clear();
                        #region

                        #endregion
                       
                        break;
                    case 3:
                        Console.Clear();
                        #region
                        Console.Write("Nhap so thap phan: ");
                        int soThapPhan = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Chuyen doi sang so nhi phan: " + ChuyenDoi(soThapPhan));
                        Console.ReadLine();
                        #endregion
                      
                        break;
                    case 4:
                        Console.Clear();
                        #region
                        ThongTinSinhVien();
                        #endregion
                     
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Chon bai tu 1 -> 4, Nhap lai!!!");
                       
                        break;
                }
            }
           
        }
    }
}
