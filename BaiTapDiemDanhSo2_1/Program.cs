using System;

namespace BaiTapDiemDanhSo2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat_232 = new Cat();
            Bird bird_232 = new Bird();

            cat_232.eat();
            cat_232.makeSound();
            cat_232.run();
            bird_232.eat();
            bird_232.makeSound();
            bird_232.fly();
        }
    }
}
