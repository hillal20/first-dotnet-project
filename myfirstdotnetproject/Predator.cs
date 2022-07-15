using System;
namespace myfirstdotnetproject
{
    public interface Predator
    {

        public void hunt();
        public void eat();
        public void jump();

    }

    public interface Prey
    {

        public void run();
        

    }
    public class Lion : Predator
    {
        public void hunt()
        {
            Console.WriteLine("=== hunting ====");
        }
        public void eat()
        {
            Console.WriteLine("==== eating =====");
        }
        public void jump()
        {
            Console.WriteLine("==== jumping =====");
        }
        public void play()
        {
            Console.WriteLine("==== play =====");
        }
    }


    public class Cheata : Predator, Prey
    {
        public void hunt()
        {
            Console.WriteLine("=== hunting ====");
        }
        public void eat()
        {
            Console.WriteLine("==== eating =====");
        }
        public void jump()
        {
            Console.WriteLine("==== jumping =====");
        }
        public void play()
        {
            Console.WriteLine("==== play =====");
        }
        public void run()
        {
            Console.WriteLine("==== run =====");
        }
    }
}




