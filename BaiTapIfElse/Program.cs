using System;

namespace BaiTapSo1
{
    class Program
    {
        static void Main(string[] args)
        {
        int so232;
        Ifinity_Loop:
            Console.WriteLine("        ====================BAI TAP====================");
            Console.WriteLine("Bai 1: Nhap vao mot so nguyen, in ra ket qua la so am hay so duong");
            Console.WriteLine("Bai 2: Nhap vao so nguyen dang so, in ra so nguyen dang chu");
            Console.WriteLine("Bai 3: Nhap vao 3 so thuc, kiem tra 3 so do co phai 3 canh cua tam giac khong");
            Console.WriteLine("Bai 4: Nhap 3 so thuc, kiem tra co phai 3 canh cua tam giac vuong khong");
            Console.WriteLine("Chon 0 de thoat!!");
            Console.Write("Chon bai: ");
            int bai232 = Int32.Parse(Console.ReadLine());
            switch (bai232)
            {
                case 0:
                        break;
                case 1:
                    Console.Clear();
                    #region
                    Console.Write("Nhap mot so: ");
                    string strSo232 = Console.ReadLine();
                    if (int.TryParse(strSo232, out so232) == false)
                        Console.WriteLine("Du lieu nhap sai");
                    else
                    {
                        if (so232 >= 0)
                            Console.WriteLine("So {0} la so duong", so232);
                        else
                            Console.WriteLine("So {0} la so am", so232);
                    }
                    #endregion
                    goto Ifinity_Loop;
                    break;
                   
                case 2:
                    Console.Clear();
                    #region
                    Console.Write("Nhap so: ");
                    int num232 = Int32.Parse(Console.ReadLine());
                    if (num232 == 0)
                        Console.WriteLine("Khong");
                    if (num232 == 1)
                        Console.WriteLine("Mot");
                    if (num232 == 2)
                        Console.WriteLine("Hai");
                    if (num232 == 3)
                        Console.WriteLine("Ba");
                    if (num232 == 4)
                        Console.WriteLine("Bon");
                    if (num232 == 5)
                        Console.WriteLine("Nam");
                    if (num232 == 6)
                        Console.WriteLine("Sau");
                    if (num232 == 7)
                        Console.WriteLine("Bay");
                    if (num232 == 8)
                        Console.WriteLine("Tam");
                    if (num232 == 9)
                        Console.WriteLine("Chin");
                    if (num232 > 9)
                        Console.WriteLine("Nhap so trong khoang 0-9");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 3:
                    Console.Clear();
                    #region
                    Console.Write("Nhap canh 1: ");
                    Double canha232 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 2: ");
                    Double canhb232 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 3: ");
                    Double canhc232 = Double.Parse(Console.ReadLine());
                    if (canha232 + canhb232 > canhc232 && 
                        canha232 + canhc232 > canhb232 && 
                        canhb232 + canhc232 > canha232)
                        Console.WriteLine("3 canh tam giac");
                    else
                        Console.WriteLine("Khong phai 3 canh tam giac");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 4:
                    Console.Clear();
                    #region
                    Console.Write("Nhap canh 1: ");
                    Double canhA232 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 2: ");
                    Double canhB232 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 3: ");
                    Double canhC232 = Double.Parse(Console.ReadLine());
                    if (Math.Pow(canhA232, 2) + Math.Pow(canhB232, 2) == Math.Pow(canhC232, 2) ||
                        Math.Pow(canhB232, 2) + Math.Pow(canhC232, 2) == Math.Pow(canhA232, 2) ||
                        Math.Pow(canhA232, 2) + Math.Pow(canhC232, 2) == Math.Pow(canhB232, 2))
                        Console.WriteLine("3 canh tam giac vuong");
                    else
                        Console.WriteLine("Khong phai 3 canh tam giac vuong");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Bai tap <=4, nhap lai!!");
                    goto Ifinity_Loop;
                    break;

            }

       
        }
    }
}
