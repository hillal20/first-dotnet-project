using System;
namespace myfirstdotnetproject
{
    abstract class AbstractClass
    {

        static int price = 30;
        static String country = "USA";


       static  public void hello()
        {
            Console.WriteLine(" hello abstrct class");
        }

        public abstract String helloWord();
    }




    class AbstractClassChild : AbstractClass
    {

        private  String childName;

        public AbstractClassChild(String childName)
        {
            this.childName = childName;

        }

        public override String helloWord()
        {
            Console.WriteLine("hello world");
            return "hello world";
        }

        public void showChildName()
        {
            Console.WriteLine($" child name is {this.childName}");
        }

    }
}

