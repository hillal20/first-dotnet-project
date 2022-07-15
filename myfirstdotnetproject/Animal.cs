using System;
namespace myfirstdotnetproject
{
   abstract public class Animal
    {

        public abstract void speak();
       

    }


   public class Dog : Animal
    {
        public override void  speak()
        {
            Console.WriteLine(" ==== how how how ??? ===");
        }

    }


    public class Cat : Animal
    {

        public override void speak()
        {
            Console.WriteLine(" ==== miyaw miyaw miyaw  ===");
        }
    }
}

