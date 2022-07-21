using System;
namespace myfirstdotnetproject
{

    public class CustomKeyDictionary
    {

        public void showDictionary()
        {

            var myDictionary = new Dictionary<Ambassador, Country>();

            //let generate some objects of the ambassadors and the countries

            Ambassador ambassador1 = new Ambassador("hill");
            Country country1 = new Country("italy", ambassador1, 5);

            Ambassador ambassador2 = new Ambassador("fill");
            Country country2 = new Country("spain", ambassador2, 4);

            Ambassador ambassador3 = new Ambassador("mora");
            Country country3 = new Country("greece", ambassador3, 7);


            // let add them to the dictionary 
            myDictionary.Add(ambassador1, country1);
            myDictionary.Add(ambassador2, country2);
            myDictionary.Add(ambassador3, country3);
            // as we see the keys in the dictionary are objects and not primitive types


            // let look for an intem in the dictionary
            if(myDictionary.TryGetValue(new Ambassador("hill"), out Country count))
            {
                // new Ambassador("hill") is a new object and nothing to do with tht
                // the ambassador1 , they have 2 different refrences
                //  to fix that we need to compare the value of the instances and not
                // the references and for that we need to override the equal method
                // in the Ambassador class , and we need to override the gethashcode as well 
                Console.WriteLine(" country capital ====> " + count.Capital);
            }
            else
            {
                Console.WriteLine(" == the country is not in the dictionary ====");
            }
        }

    }


    // let have ambassador class
    public class Ambassador
    {

        private  String name;
        public Ambassador(String name)
        {
            Name = name;
        }

        public String Name
        {
            get; set;
        
        }


        //  overriding equals 
        public override bool Equals(object? obj)
        {
            // if we pass null we dont need to compare we just say false
            if (obj == null) return false;
            // if obj is not an instance of Ambassador we just say false
            if (!(obj is Ambassador)) return false;

            return StringComparer.OrdinalIgnoreCase.Equals(((Ambassador)obj).Name, this.Name);
        }

        // override gethashcode
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Name);
        }


    }
    


    // let have counry code
    public class Country
    {

        String capital;
        Ambassador ambass;
        int tenure;
        public Country(String capital, Ambassador ambassador , int tenure)
        {
            Capital = capital;
            Ambass= ambassador;
        }

        public String Capital
        {
            get;set;
        }
        public Ambassador Ambass
        {
            get; set;
        }
        public int Tenure
        {
            get; set;
        }
    }
}

