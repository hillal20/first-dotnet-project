using System;
namespace myfirstdotnetproject
{
    public class GettersAndSetters
    {
        public GettersAndSetters()
        {
        }
    }

    public class Car
    {
        private int speed;

        public Car(int speed)
        {
            this.Speed = speed;
        }

        public int Speed
        {
            get {
                Console.WriteLine(" i am the getter");
                return speed;
            }
            set {
                Console.WriteLine(" i am the setter");
                speed = value;
            }
        }

        // or we could use the short cut
        //  public int Speed { get;set;}
    }
}

