using System;

namespace BaiTapSo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
        Ifinity_Loop:
            Console.WriteLine("        ====================BAI TAP====================");
            Console.WriteLine("Bai 1: Nhap vao mot so nguyen, in ra ket qua la so am hay so duong");
            Console.WriteLine("Bai 2: Nhap vao so nguyen dang so, in ra so nguyen dang chu");
            Console.WriteLine("Bai 3: Nhap vao 3 so thuc, kiem tra 3 so do co phai 3 canh cua tam giac khong");
            Console.WriteLine("Bai 4: Nhap 3 so thuc, kiem tra co phai 3 canh cua tam giac vuong khong");
            Console.WriteLine("Chon 0 de thoat!!");
            Console.Write("Chon bai: ");
            int bai = Int32.Parse(Console.ReadLine());
            switch (bai)
            {
                case 0:
                        break;
                case 1:
                    Console.Clear();
                    #region
                    Console.Write("Nhap mot so: ");
                    string strSo = Console.ReadLine();
                    if (int.TryParse(strSo, out so) == false)
                        Console.WriteLine("Du lieu nhap sai");
                    else
                    {
                        if (so >= 0)
                            Console.WriteLine("So {0} la so duong", so);
                        else
                            Console.WriteLine("So {0} la so am", so);
                    }
                    #endregion
                    goto Ifinity_Loop;
                    break;
                   
                case 2:
                    Console.Clear();
                    #region
                    Console.Write("Nhap so: ");
                    int num = Int32.Parse(Console.ReadLine());
                    if (num == 0)
                        Console.WriteLine("Khong");
                    if (num == 1)
                        Console.WriteLine("Mot");
                    if (num == 2)
                        Console.WriteLine("Hai");
                    if (num == 3)
                        Console.WriteLine("Ba");
                    if (num == 4)
                        Console.WriteLine("Bon");
                    if (num == 5)
                        Console.WriteLine("Nam");
                    if (num == 6)
                        Console.WriteLine("Sau");
                    if (num == 7)
                        Console.WriteLine("Bay");
                    if (num == 8)
                        Console.WriteLine("Tam");
                    if (num == 9)
                        Console.WriteLine("Chin");
                    if (num > 9)
                        Console.WriteLine("Nhap so trong khoang 0-9");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 3:
                    Console.Clear();
                    #region
                    Console.Write("Nhap canh 1: ");
                    Double canh1 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 2: ");
                    Double canh2 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 3: ");
                    Double canh3 = Double.Parse(Console.ReadLine());
                    if (canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
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
                    Double canhA = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 2: ");
                    Double canhB = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap canh 3: ");
                    Double canhC = Double.Parse(Console.ReadLine());
                    if (Math.Pow(canhA, 2) + Math.Pow(canhB, 2) == Math.Pow(canhC, 2))
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
