using System;
namespace myfirstdotnetproject
{
    public class Parent
    {
        public String lastName = "Hufman";
        public static String nickName = "Huf";
        public  void sayHi()
        {
            Console.WriteLine(" ==== hi parent ====");
        }
    }




    class Child : Parent
    {
       public  int age = 12;

        public void play()
        {
            Console.WriteLine(" ==== child playing ====");
        }
    }


    class GrandChild : Parent
    {
       public  bool milk = true;
        public void cry()
        {
            Console.WriteLine(" ==== grand child cryig  ====");
        }
    }


}




