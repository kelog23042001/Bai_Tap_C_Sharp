using System;

namespace BaiTapDiemDanhSo3
{
    class Program
    {
        public static void input(int[] arr)
        {
            
            Console.WriteLine("Nhap mang: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap arr[{0}] =", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void output(int[] arr)
        {
            Console.WriteLine("Mang da nhap: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, arr[i]);
            }
        }
        public static void max_min(int[] arr)
        {
            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min = arr[i];
            }
            Console.WriteLine("Gia tri lon nhat: {0}", max);
            Console.WriteLine("Gia tri nho nhat: {0}", min);

        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            input(arr);
            output(arr);
            max_min(arr);
        }
    }
}
