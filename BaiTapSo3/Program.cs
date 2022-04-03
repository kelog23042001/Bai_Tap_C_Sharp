using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaiTapSo3
{
    class Program
    {
        int checkNguyenTo(int n)
        {     
            if (n < 2)
            {
                return 0;  
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if ( n % i == 0)
                    return 0;
            }
            return 1;
        } 
        void bai58()
        {
            int n = 0;         
            do
            {
                Console.Write("Nhap n: ");
                n = Int32.Parse(Console.ReadLine());
            } while (n < 0 && n > 100);
            int i = 2;        
            while (i < n)
            {
                if (checkNguyenTo(i) == 1)
                {
                    Console.Write("{0} ", i);                  
                }
                i++;
            }
        }
        int[] random (int n, int min, int max)
        {
            int x;
            Random rd = new Random();
            int[] a = new int[n];
            int i = 0;
            while (i < n) {
                x = rd.Next(min,max);
                if (kiemtratrung(a, i, x)) {
                    a[i] = x;
                    i++;
                }
            }    
            return a;
        }
        void xuatmang(int[] a, int n)
        {
            Console.WriteLine("Xuat mang: ");
            for(int i = 0; i < n; i++) {
                Console.WriteLine("a[{0}] = {1} ", i, a[i]);
            }
        }
        int tongDuong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++) {
                if (a[i] % 2 == 0)
                    tong += a[i];               
            }
            return tong;
        }
        bool kiemtratrung(int[] a, int n, int x)
        {
            for(int i = 0; i< n; i++) {
                if (a[i] == x)
                    return false;
            }
            return true;
        }
        void kiemtratong(int[] a, int n)
        {
            int tongChan = 0, tongLe = 0;   
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0 && a[i] % 2 == 0)
                    tongChan += a[i];
                if (i % 2 == 0 && a[i] % 2 != 0)
                    tongLe += a[i];                    
            }
            if (tongLe == tongChan)
                Console.WriteLine("tong le o vi tri chan ({0}) bang tong chan o vi tri le ({1})", tongLe, tongChan);
            else
                Console.WriteLine("tong le o vi tri chan ({0}) khac tong chan o vi tri le ({1})", tongLe, tongChan);
        }
        int USCLN(int a, int b)
        {
            if (b == 0) 
                return a;
            return USCLN(b, a % b);
        }
        void coprime(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (USCLN(a[i], a[j]) == 1)
                        Console.WriteLine("({0}, {1})", a[i], a[j]);
        }
        void Bai59()
        {
            int n;
            string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);
            n += 60;
            Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);
            Console.ReadLine();
        }
        int[] perfectShuffle(int[] arr)
        {
            int size = arr.Length / 2;
            int[] a = new int[size];
            int[] b = new int[arr.Length - size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = arr[i];
            }
            int j = 0;
            if (arr.Length % 2 == 0)
            {
                for (int i = b.Length; i < arr.Length; i++)
                {
                    b[j++] = arr[i];
                }
            }
            else
            {
                for (int i = b.Length - 1; i < arr.Length; i++)
                {
                    b[j++] = arr[i];
                }
            }
            int[] c = new int[arr.Length];
            return tronArray(a, b);
        }
        int[] tronArray(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];

            int iA = 0;
            int iB = 0;
            int nC = 0;
            while (iA < a.Length && iB < b.Length)
            {
                c[nC++] = a[iA++];
                c[nC++] = b[iB++];
            }
            while (iA < a.Length)
            {
                c[nC++] = a[iA++];
            }
            while (iB < b.Length)
            {
                c[nC++] = b[iB++];
            }

            return c;
        }
        int sum_arr(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    s += arr[i];
                }
            }
            return s;
        }
        void Bai60()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            a = random(n, -100, 100);
            xuatmang(a, n);
            int[] c = perfectShuffle(a);
            Console.WriteLine("perfect shuffle : ");
            xuatmang(c, c.Length);
            int count = 1;
            do
            {
                c = perfectShuffle(c);
                count++;
            } while ((!(a.SequenceEqual(c))));

            Console.Write($"Can {count} lan shuffle de mang tro ve ban dau");
        }
        int nhap_K(int n)
        {
            int k = -1;
            do
            {
                try
                {
                    Console.Write("Nhap k (0 <= k <= {0}) : ", n - 1);
                    k = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    k = -1;
                }

            } while ((k < 0 || k >= n));
            return k;
        }
         void xoa_k(int[] a, int k)
        {
            for (int i = k; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
        }
        void Bai61()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            a = random(n, -100, 100);
            xuatmang(a, n);
            Console.WriteLine("Tong cac so duong trong mang: " + tongDuong(a, n));
            Console.WriteLine();
            int k = nhap_K(n);
            Console.WriteLine("Mang sau khi xoa : ");
            xoa_k(a, k);
            //show values array
            xuatmang(a, n-1);
        }
        void Bai62()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            a = random(n, 10, 20);
            xuatmang(a, n);
            kiemtratong(a, n);
            coprime(a, n);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Program pr = new Program();
            int chonbai = 0;
            do
            {
                Console.WriteLine("\n             =========================BÀI TẬP=========================");
                Console.WriteLine("Bai 1: Viết chương trình thực hiện thuật toán sàng Erastosthenes10");
                Console.WriteLine("Bai 2: Nhập vào năm Dương lịch, xuất tên năm Âm lịch. Xuất năm Dương lịch kế tiếp có cùng tên năm Âm lịch");
                Console.WriteLine("Bai 3: : Viết chương trình thực hiện những yêu cầu sau:\n            a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên dương có giá trị chứa trong đoạn[10, 20] và xuất mảng.\n            b.Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn hay không ?\n            c.Xác định xem mảng có cặp số nguyên tố cùng nhau(coprime) nào không.");
               
                Console.WriteLine("Bai 4:  Viết chương trình thực hiện những yêu cầu sau: \n            a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên có giá trị chứa trong đoạn[-100, 100] và xuất mảng. \n            b.Tính tổng các số nguyên dương có trong mảng. \n            c.Xóa phần tử có chỉ số p(p nhập từ bàn phím) trong mảng.");
                Console.WriteLine("Bai 5: : Viết chương trình thực hiện những yêu cầu sau:\n            a.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên dương có giá trị chứatrong đoạn[10, 20] và xuất mảng.\n            b.Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵnhay không ? \n            c.Xác định xem mảng có cặp số nguyên tố cùng nhau(coprime) nào không.");
                Console.Write("Chon bai : ");
                chonbai = int.Parse(Console.ReadLine());
                switch (chonbai)
                {
                    case 1:
                        Console.Clear();
                        pr.bai58();
                        break;
                    case 2:
                        Console.Clear();
                        pr.Bai59();
                        break;
                    case 3:
                        Console.Clear();
                        pr.Bai60();
                        break;
                    case 4:
                        Console.Clear();
                        pr.Bai61();
                        break;
                    case 5:
                        Console.Clear();
                        pr.Bai62();
                        break;
                    default:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                }
            } while (chonbai >= 1 && chonbai <= 5);
        }
    }
}
