using System;
namespace myfirstdotnetproject
{
    public class Human
    {
         String name;
         int age;
         public  static  int childernNumber = 0;

        public Human(String name, int age )
        {
            this.name = name;
            this.age = age;
            childernNumber++;
        }

      public  void eat()
        {
            Console.WriteLine($"{name} is eating");
        }

      public   void sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
      public   void howOld()
        {
            Console.WriteLine($"he is {age} old");
        }
    }
}

