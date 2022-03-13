using System;

namespace BaiTapSo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ifinity_Loop:
            Console.WriteLine("            ============BAI TAP============");         
            Console.WriteLine("Bai 1:  Nhap vao dien tich, tinh the tich hinh cau.");
            Console.WriteLine("Bai 2:  Nhap toan do 2 diem A, B. Tinh khoang cach AB.");
            Console.WriteLine("Bai 3:  Nhap vao 3 so thuc, cho biet loai tam giac gi.");
            Console.WriteLine("Bai 4:  Nhap vao 3 so, sap xep theo thu tu tang dan.");
            Console.WriteLine("Bai 5:  Viet chuong trinh giai he phuong trinh 2 an.");
            Console.WriteLine("Bai 6:  Nhap vao so gio, in ra tuong duong theo tuan, ngay gio.");
            Console.WriteLine("Bai 7:  Nhap vao 2 thoi diem, tinh thoi gian trai qua giua 2 thoi diem nay.");
            Console.WriteLine("Bai 8:  Nhap n, in ra so chu, so cuoi cung, so dau tien, tong cac chu so, so dao nguoc cua n.");
            Console.WriteLine("Bai 9:  Rut gon phan so.");
            Console.WriteLine("Bai 10: Nhap n>0, tim m lon nhat sao cho 1+2+3+...+m <n.");
            Console.WriteLine("Bai 11: Nhap n, tinh tong s biet:");
            Console.WriteLine("        n chan: 2 + 4 + 6 +...+ n");
            Console.WriteLine("        n le:   1 + 3 + 5 +...+ n");
            Console.Write("Chon bai: ");
            int bai_232 = Int32.Parse(Console.ReadLine());
            switch (bai_232)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    #region
                    Double pi_232 = 3.14, dienTich_232, banKinh_232, theTich_232;
                    do
                    {
                        Console.Write("Nhap dien tich hinh cau S =  ");
                        dienTich_232 = Double.Parse(Console.ReadLine());
                        if (dienTich_232 < 0)
                            Console.WriteLine("dien tich phai > 0, nhap lai");
                    } while (dienTich_232 < 0);
                    banKinh_232 = Math.Sqrt(dienTich_232 / (4 * pi_232));
                    Console.WriteLine("=> Ban kinh hinh cau R =" + banKinh_232);
                    theTich_232 = (4 * pi_232 * Math.Pow(banKinh_232, 3) / 3);
                    Console.WriteLine("The tich hinh cau la, V = " + theTich_232);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 2:
                    Console.Clear();
                    #region
                    Double x1_232, x2_232, y1_232, y2_232;
                    Console.WriteLine("Nhap lan luot toa do diem A(x1, y1): ");
                    x1_232 = Double.Parse(Console.ReadLine());
                    y1_232 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap lan luot toa do diem B(x2, y2): ");
                    x2_232 = Double.Parse(Console.ReadLine());
                    y2_232 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Toa do diem A({0},{1}), B({2},{3})", x1_232, y1_232, x2_232, y2_232);
                    Double AB = Math.Sqrt(Math.Pow(x2_232 - x1_232, 2) + Math.Pow(y2_232 - y1_232, 2));
                    Console.WriteLine("Khoang cach AB = " + AB);
                    #endregion
                    goto Ifinity_Loop;  
                    break;
                case 3:
                    Console.Clear();
                    #region
                    Double canh1_232, canh2_232, canh3_232;
                    do
                    {
                        Console.WriteLine("Nhap lan luot cac canh tam giac: ");
                        canh1_232 = Double.Parse(Console.ReadLine());
                        canh2_232 = Double.Parse(Console.ReadLine());
                        canh3_232 = Double.Parse(Console.ReadLine());
                        if (canh1_232 < 0 || canh2_232 < 0 || canh3_232 < 0)
                            Console.WriteLine("3 canh phai > 0, nhap lai");
                    } while (canh1_232 < 0 || canh2_232 < 0 || canh3_232 < 0);
                    if (canh1_232 + canh2_232 > canh3_232 &&
                        canh1_232 + canh3_232 > canh2_232 &&
                        canh2_232 + canh3_232 > canh1_232)
                    {
                        if (Math.Pow(canh1_232, 2) + Math.Pow(canh2_232, 2) == Math.Pow(canh3_232, 2) ||
                       Math.Pow(canh1_232, 2) + Math.Pow(canh3_232, 2) == Math.Pow(canh2_232, 2) ||
                       Math.Pow(canh2_232, 2) + Math.Pow(canh3_232, 2) == Math.Pow(canh1_232, 2))
                            Console.WriteLine("Tam giac vuong");
                        else if (canh1_232 == canh2_232 && canh2_232 == canh3_232)
                            Console.WriteLine("Tam giac deu");
                        else if (canh1_232 == canh2_232 || canh2_232 == canh3_232 || canh3_232 == canh1_232)
                            Console.WriteLine("Tam giac can");
                        else
                            Console.WriteLine("Tam giac thuong");
                        double p_232 = (canh1_232 + canh2_232 + canh3_232) / 2;
                        Console.WriteLine("Dien tich tam giac: " + Math.Sqrt(p_232 * (p_232 - canh3_232) * (p_232 - canh1_232) * (p_232 - canh2_232)));
                    }
                    else
                        Console.WriteLine("Khong phai 3 canh tam giac");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 4:
                    Console.Clear();
                    #region
                    int a_232, b_232, c_232, t_232;                    
                    do{
                        Console.WriteLine("Nhap lan luot 3 so a, b, c: ");
                        a_232 = Int32.Parse(Console.ReadLine());
                        b_232 = Int32.Parse(Console.ReadLine());
                        c_232 = Int32.Parse(Console.ReadLine());
                        if (a_232 < 0 || b_232 < 0 || c_232 < 0)
                            Console.WriteLine("a, b, c phai > 0, nhap lai");
                    } while (a_232 < 0 || b_232 < 0 || c_232 < 0);
                    
                    if (a_232 > b_232) {
                        t_232 = a_232;
                        a_232 = b_232;
                        b_232 = t_232;
                    }
                    if (a_232 > c_232) {
                        t_232 = a_232;
                        a_232 = c_232;
                        c_232 = t_232;
                    }
                    if (b_232 > c_232){
                        t_232 = b_232;
                        b_232 = c_232;
                        c_232 = t_232;
                    }
                    Console.WriteLine("Thu tu tang dan:{0}, {1}, {2}", a_232, b_232, c_232);
                    goto Ifinity_Loop;
                    #endregion
                    break;
                case 5:
                    Console.Clear();
                    #region
                    Double a1_232, b1_232, c1_232, a2_232, b2_232, c2_232, D_232, Dx_232, Dy_232, x_232, y_232;
                    Console.WriteLine("Nhap a1, b1, c1: ");
                    a1_232 = Int32.Parse(Console.ReadLine());
                    b1_232 = Int32.Parse(Console.ReadLine());
                    c1_232 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap a2, b2, c2: ");
                    a2_232 = Int32.Parse(Console.ReadLine());
                    b2_232 = Int32.Parse(Console.ReadLine());
                    c2_232 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("He phuong trinh co dang: ");
                    Console.WriteLine("{0}x + {1}y = {2}", a1_232, b1_232, c1_232);
                    Console.WriteLine("{0}x + {1}y = {2}", a2_232, b2_232, c2_232);
                    D_232 = a1_232 * b2_232 - a2_232 * b1_232;
                    Dx_232 = c1_232 * b2_232 - c2_232 * b1_232;
                    Dy_232 = a1_232 * c2_232 - a2_232 * c1_232;
                    if (D_232 == 0){
                        if (Dx_232 + Dy_232 == 0)
                            Console.WriteLine("He phuong trinh co vo so nghiem");
                        else
                            Console.WriteLine("He phuong trinh vo nghiem");
                    }
                    else{
                        x_232 = Dx_232 / D_232;
                        y_232 = Dy_232 / D_232;
                        Console.WriteLine("He phuong trinh co 2 nghiem, x = {0}, y = {1}", x_232, y_232);
                    }
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 6:
                    Console.Clear();
                    #region
                    int gio_232;
                    do {
                        Console.Write("Nhap so gio: ");
                        gio_232 = Int32.Parse(Console.ReadLine());
                        if (gio_232 < 0)
                            Console.WriteLine("Gio phai >= 0");  
                    } while (gio_232 < 0);                    
                    Console.WriteLine("{0} tuan, {1} ngay, {2} gio", gio_232 / (24 * 7), (gio_232 % (24 * 7)) / 24, (gio_232 % (24 * 7)) % 24);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 7:
                    Console.Clear();
                    #region
                    int gio1_232, phut1_232, giay1_232, gio2_232, phut2_232, giay2_232, thoiGian_232;
                    Console.WriteLine("Nhap gio, giay, phut [1]: ");
                    gio1_232 = Int32.Parse(Console.ReadLine());
                    phut1_232 = Int32.Parse(Console.ReadLine());
                    giay1_232 = Int32.Parse(Console.ReadLine());
                    thoiGian_232 = 3600 * gio1_232 + 60 * phut1_232 + giay1_232;
                    Console.WriteLine("Nhap gio, giay, phut [2]: ");
                    gio2_232 = Int32.Parse(Console.ReadLine());
                    phut2_232 = Int32.Parse(Console.ReadLine());
                    giay2_232 = Int32.Parse(Console.ReadLine());
                    thoiGian_232 -= 3600 * gio2_232 + 60 * phut2_232 + giay2_232;
                    if (thoiGian_232 < 0)
                        thoiGian_232 -= thoiGian_232;
                    Console.WriteLine("Hieu thoi gian: {0} gio, {1} phut, {2} giay", thoiGian_232 / 3600, (thoiGian_232 % 3600) / 60, (thoiGian_232 % 3600) % 60);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 8:
                    Console.Clear();
                    #region
                    int n_232, t1_232, u_232 = 0, sum_232 = 0, count_232 = 0, res_232 = 0;
                    Console.Write("Nhap so tu nhien n: ");
                    n_232 = Int32.Parse(Console.ReadLine());
                    t1_232 = n_232;
                    while (t1_232 != 0){
                        count_232++;
                        u_232 = t1_232 % 10;
                        sum_232 += u_232;
                        t1_232 /= 10;
                        res_232 = res_232 * 10 + u_232;
                    }
                    Console.WriteLine("{0} co {1} chu so", n_232, count_232);
                    Console.WriteLine("Chu so cuoi cung la: " + n_232 % 10);
                    Console.WriteLine("Chu so dau tien la: " + u_232);
                    Console.WriteLine("Tong cac chu so la: " + sum_232);
                    Console.WriteLine("So dao nguoc la: " + res_232);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 9:
                    Console.Clear();
                    #region
                    Double tu_232, mau_232, ttu_232, tmau_232;
                    Console.WriteLine("Nhap tu so: ");
                    tu_232 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap mau so: ");
                    mau_232 = Double.Parse(Console.ReadLine());
                    if (mau_232 == 0){
                        Console.WriteLine("Mau phai > 0");
                        break;
                    }
                    ttu_232 = Math.Abs(tu_232);
                    tmau_232 = Math.Abs(mau_232);
                    while (ttu_232 != tmau_232 && ttu_232 != 0 && tmau_232 != 0){
                        if (ttu_232 > tmau_232) ttu_232 -= tmau_232;
                        else tmau_232 -= ttu_232;
                    }
                    tu_232 /= ttu_232;
                    mau_232 /= ttu_232;
                    Console.Write("Sau khi rut gon: ");
                    if (mau_232 == 1)
                        Console.WriteLine("" + tu_232);
                    else
                        Console.WriteLine("{0}/{1}", tu_232, mau_232);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 10:
                    Console.Clear();
                    #region
                    int n3_232, m_232, s_232;
                    do{
                        Console.Write("Nhap n: ");
                        n3_232 = Int32.Parse(Console.ReadLine());
                        if (n3_232 <= 0)
                        {
                            Console.WriteLine("n la so duong, nhap lai");
                        }
                    } while (n3_232 <= 0);
                    s_232 = 0;
                    m_232 = 1;
                    while (s_232 + m_232 < n3_232)
                    {
                        Console.Write("" + m_232);
                        s_232 += m_232;
                        m_232++;
                        if (s_232 + m_232 < n3_232) Console.Write(" + ");
                    }
                    if (s_232 != 0){
                        Console.WriteLine(" = {0} < {1}", s_232, n3_232);
                        Console.WriteLine("m = {0}", m_232 - 1);
                    }
                    else Console.WriteLine("Khong tim thay\n");
                    #endregion
                    goto Ifinity_Loop;
                    break;
                case 11:
                    Console.Clear();
                    #region
                    int n2_232, i1_232, s2_232 = 0;
                    do
                    {
                        Console.Write("Nhap n: ");
                        n2_232 = Int32.Parse(Console.ReadLine());
                        if (n2_232 < 0)
                            Console.WriteLine("Gio phai >= 0");
                    } while (n2_232 < 0);                  
                    for (i1_232 = n2_232; i1_232 > 0; i1_232 -= 2) s2_232 += i1_232;
                    Console.WriteLine("Tong bang: " + s2_232);
                    #endregion
                    goto Ifinity_Loop;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Chon tu bai 1-11, chon lai!!!");
                    goto Ifinity_Loop;
                    break;
            }
        }
    }
}
