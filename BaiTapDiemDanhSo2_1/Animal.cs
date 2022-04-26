using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDiemDanhSo2_1
{
    public abstract class  Animal
    {
        protected Animal()
        {
        }


        public abstract void eat();
        public abstract void makeSound();

       
    }

    public class Cat : Animal
    {
    

        public override void eat()
        {
            Console.WriteLine("Con meo an thit ca");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meow meow meow");
        }
        public void run()
        {
            Console.WriteLine("Con meo chay thay nhanh");
        }
    }
    public class Bird : Animal
    {     

        public override void eat()
        {
            Console.WriteLine("Con chim an banh mi");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chip Chip Chip");
        }
        public void fly()
        {
            Console.WriteLine("Con chim bay toc do");
        }
    }

}
