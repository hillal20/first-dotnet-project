using System;
using System.Collections.Generic;


namespace myfirstdotnetproject
{
    

    public class Hasky
    {

        private String name;
        private bool dangerous;

        public Hasky(String name , bool dangerous)
        {
            this.Name = name;
            this.Dangerous = dangerous;
        }

        public string Name { get; set; }
        public bool Dangerous { get; set; }

        public void Bark(int numberOfBarks)
        {
          Console.WriteLine($"==> the hasky {name} {dangerous} is barking { numberOfBarks}");
        }
    }

   public  class DogsShelter
    {

       static  public List<Hasky> dogslist = new List<Hasky>()
        {
           new Hasky("bobi", true),
           new Hasky("moris", false),
           new Hasky("sif", false),
           new Hasky("titi", true),
        };

    }
}

