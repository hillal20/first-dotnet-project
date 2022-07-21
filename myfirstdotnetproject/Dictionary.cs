using System;
using System.Collections.Generic;


namespace myfirstdotnetproject
{

    public class MyDictionary
    {
        public void  showMyDictionary()
        {
            Dictionary<int, String> myDic = new Dictionary<int, String>()
            {
                {1, "january" },
                {2, "fabruary" },
                {3, "march" },
                {4, "april" },
                {5, "may" }
            };

            myDic[6] = "june";
            myDic.Add(7, "july");

            String month = myDic[7];
            Console.WriteLine(" month ===> " + month);


            ///// if the element is not existing in the dictionary we can avoid
            /// throwing an exception and returning null  instead
            ///


            var result = myDic.TryGetValue(1, out string may);
            Console.WriteLine("result ===>  " + result);
        }
    }
}

