using System;
namespace myfirstdotnetproject
{
    public class Threads
    {
        public Threads()
        {
        }

       public static void showThreads()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "main thread";
            Console.WriteLine("thread ====> " + thread.Name);



        }
    }
}

