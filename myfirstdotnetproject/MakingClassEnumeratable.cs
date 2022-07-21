using System;
using System.Collections;
using System.Collections.Generic;


namespace myfirstdotnetproject
{
    
    public class PlayWithNames
    {   

        public List<String> showNames()
        {
            var lastNames = new List<String>()
            {
                "jhon", "martin", "tom"
            };

            foreach(String lastName in lastNames)
            {
                Console.WriteLine("l name ====>" + lastName);
            }

            return lastNames;
        }
    }


    public class Student
    {

        private String name;
        private int age;

        public Student(String name , int age)
        {
            Name = name;
            Age = age;
        }

        public String Name { get; set; }
        public int Age { get; set; }
    }


    public class ClassRoom : IEnumerable, IEnumerator
    {

        public Student[] studentsList;


        public ClassRoom()
        {
            studentsList = new Student[5]{
                                    new Student("john", 15),
                                    new Student("bill", 14),
                                    new Student("marc", 20),
                                    new Student("peter", 17),
                                    new Student("phil", 13),
                                  };
        }

        /// <summary>
        /// all the stuff below is to make the classroom class irreratabe
        /// which means we can irrerate on it object after the creation instead the
        /// studentsList array 
        /// </summary>

        // define the index for the looping 
        public int index = -1;

        // impleneting the getEnumerator funtion which comes from the interface IEnumerable
        public IEnumerator GetEnumerator()
        {
            // we have to return  a calss implementing the IEnumerator intreface 
            return (IEnumerator)this;
        }


        // impleneting the 3  funtions which come  from the interface IEnumerator
        public bool MoveNext()
        {
            index++;
            return index < studentsList.Length ? true : false;
        }
        public object Current
        {
            get { return studentsList[index]; }
        
        }
       
        public void  Reset()
        {
            index = 0;
        }
    }



}

