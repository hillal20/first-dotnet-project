using System;
namespace myfirstdotnetproject
{
    public class Gernerics
    {
        
       static public void displayElements<ANYTYPE>(ANYTYPE[] elemenst)
        {
            foreach (ANYTYPE e in elemenst)
            {
                Console.WriteLine(" e ====> " + e);
            }
        }
    }

    
}

