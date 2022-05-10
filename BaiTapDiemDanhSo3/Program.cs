using System;

namespace BaiTapDiemDanhSo3
{
    class Program
    {
        public static void input(int[] arr_232)
        {
            
            Console.WriteLine("Nhap mang: ");
            for (int i_232 = 0; i_232 < 10; i_232++)
            {
                Console.Write("Nhap arr_232[{0}] =", i_232);
                arr_232[i_232] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void output(int[] arr_232)
        {
            Console.WriteLine("Mang da nhap: ");
            for (int i_232 = 0; i_232 < 10; i_232++)
            {
                Console.WriteLine("a[{0}] = {1}", i_232, arr_232[i_232]);
            }
        }
        public static void max_min(int[] arr_232)
        {
            int max = arr_232[0], min = arr_232[0];
            for (int i = 1; i < 10; i++)
            {
                if (max < arr_232[i])
                    max = arr_232[i];
                if (min > arr_232[i])
                    min = arr_232[i];
            }
            Console.WriteLine("Gia tri lon nhat: {0}", max);
            Console.WriteLine("Gia tri nho nhat: {0}", min);

        }
        public static void sort_up(int[] arr_232)
        {
            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
               if(arr_232[i] < arr_232[i + 1])
                {
                    arr_232[i] = temp;
                    temp = arr_232[i + 1];
                    arr_232[i + 1] = arr_232[i];
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr_232 = new int[10];
            input(arr_232);
            output(arr_232);
            max_min(arr_232);
        }
    }
}
