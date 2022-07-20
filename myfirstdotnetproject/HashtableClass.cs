using System;
using System.Collections;


namespace myfirstdotnetproject
{
    public class HashtableClass
    {


      static  public void showHashtabe ()
        {


            Hashtable hashtable = new Hashtable()
            {
                {5, "USA" },
                {6, "c#" }
            };


            hashtable.Add(0, "hilal");
            hashtable.Add(1, "aissani");
            hashtable.Add(2, "illinoi");
            hashtable.Add(3, "sogeti");

            Console.WriteLine(" 3 ===> " + hashtable[3]);


            // hastables can be created via dicssionary
            Dictionary<int, String> dic = new Dictionary<int, String>();
            dic.Add(0, "zero is here ");
            dic.Add(10, "ten");

            String zero = dic[0];
            Console.WriteLine("zero ===> " + zero);

            Hashtable hashtable1 = new Hashtable(dic);
            String ten = (String)hashtable1[10];

            Console.WriteLine(" ten ====> " + ten);

            // hashtable elements are key-value pairs stored in dictionary entry


            foreach(DictionaryEntry st in hashtable)
            {
                Console.WriteLine(" st1 ===> " + st.Key);

            }
            foreach (DictionaryEntry st in hashtable1)
            {
                Console.WriteLine(" st2 ===> " + st.Value);

            }

            foreach (var value   in hashtable1.Values)
            {
                Console.WriteLine(" value ===> " + value);

            }
            foreach (var key in hashtable1.Keys)
            {
                Console.WriteLine(" key ===> " + key);

            }

        }


    }
}

