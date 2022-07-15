using System;
using System.Collections.Generic;

namespace myfirstdotnetproject {
    class Program
    {

        //static  void myFun()
        //{
        //    Console.WriteLine("=== my function is here =====");
        //}
        static void Main(String[] args)
        {

            //////////////////////////////////////////// data types /////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            //Console.WriteLine("Hello, World!");
            //Console.Write("==== hello world 2 ====");

            //////////////////////////////// data types


            //const int age = 50; // const is not mutuabel for the life of the program 
            //double hights = 49.39;
            //char y = '@';
            //String str = "aissani";
            //Console.WriteLine("age + hieght ==="+   age + hights + y + str);

            //////////////////////////////  casting

            //double speed = 49.84;
            //int speed2 = Convert.ToInt32(speed);
            //Console.WriteLine(" type of speed ===> " + speed.GetType());
            //Console.WriteLine(" speed 2 ===> " + speed2);

            //String g = "true";
            //bool b = Convert.ToBoolean(g);
            //Console.WriteLine("type b ====> "+ b.GetType());



            ///////////////////////////////  IO ///////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            ///

            //Console.WriteLine(" what is your name: ");
            //String name = Console.ReadLine();
            //Console.WriteLine("name ===> " + name);


            //////////////////// math class //////////////////////////////
            //////////////////////////////////////////////////////////////
            ///

            //double f = Math.Pow(2, 4);
            //Console.WriteLine(" f ====> " + f);

            //////////// random /////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            ///

            //Random random = new Random();

            // to get a random number between 1 and 6
            //int ran = random.Next(1, 7);
            //Console.WriteLine(" ran ====> " + ran);


            //////// string methods ///////////////////////////////////
            //////////////////////////////////////////////////////////
            ///

            //String fullName = "HIlal Aissani";
            //String phoneNumber = "898-989-03993";

            //phoneNumber =  phoneNumber.Replace("-", "/");
            //Console.WriteLine(" phone ====>" + phoneNumber);

            //fullName = fullName.Insert(0, "@");
            //Console.WriteLine(" fullname ===>" + fullName);
            //Console.WriteLine(fullName.Length);

            //String name = fullName.Substring(1);
            //Console.WriteLine("name ===> " + name);

            //String lastName = name.Substring(6);
            //Console.WriteLine("last name ====> "+lastName);

            ////////////////////// while loop //////////////////
            ////////////////////////////////////////////////////


            //int num = 4;

            //while(num < 11)
            //{
            //    num++;
            //    Console.WriteLine(" num ====> " + num);

            //}
            //Console.WriteLine(" outside the loop ====> ");



            /////////// arrays //////////////////////////////////////
            ////////////////////////////////////////////////////////

            //String[] cars = { "gold", "cc", "tigwan" };
            //Console.WriteLine(" cars ====> " + cars.Length);
            //Console.WriteLine(" car1 ====> " + cars[0]);

            // arrays have a fixed size
            // String[] array = new string[3]; this means the Length is 3

            //foreach (String car in cars )
            //{
            //    Console.WriteLine(" c ====> " + car);
            //}


            ////////////// fuctions ///////////////////////////////////
            ///////////////////////////////////////////////////////////
            ///

            // static key word is for the same class functions that need to be triggered
            // inside the main method of the class

            // String func()
            //{
            //    Console.WriteLine(" i am here ");
            //    return "i am here ";
            //};

            //myFun();
            //func();func

            /////////////// functions with params of a different lenght
            ////////////////////////////////////
            ///


            //double myTotal(params double[] prices )
            //{
            //    double total = 0;
            //    foreach(double price in prices)
            //    {

            //        total += price;
            //    }


            //    return total;
            //}

            //Console.WriteLine("  total 0 ===> " + myTotal());
            //Console.WriteLine("  total 1 ===> " + myTotal(1));
            //Console.WriteLine("  total 2 ===> " + myTotal(1,2));
            //Console.WriteLine("  total 3 ===> " + myTotal(1,2,3));
            //Console.WriteLine("  total 4 ===> " + myTotal(1,2,3,4));


            ///////// string interpolation /////////////////////////
            /////////////////////////////////
            ///

            //String str = $" Hilal Aissani is {37} years old";
            //Console.WriteLine(" n =====>" + str);





            /////////////////// multidemential array /////////////////
            //////////////////////////////
            //////


            //String[,] cars = { { "gold", "cc" }, { "204", "505" }, { "camry", "avlon" } };
            //Console.WriteLine(" car ====>" + cars[0, 1]);

            //// the lenght of the first demention 
            //Console.WriteLine(" car length 1 ====>" + cars.GetLength(0));

            //// the lenght of the second demention 
            //Console.WriteLine(" car length 2 ====>" + cars.GetLength(1));


            //// for each in mulidemnetional arrays is loopig for every element 
            //foreach (String car in cars)
            //{
            //    Console.WriteLine("car 2 ===> " + car);
            //}



            //////// classes /////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////

            //Messages.showMessage();

            //Human hilal = new Human("hilal", 37);
            //hilal.eat();
            //hilal.howOld();
            //hilal.sleep();

            //Human bilal = new Human("bilal", 38);
            //bilal.eat();
            //bilal.howOld();
            //bilal.sleep();


            //Console.WriteLine(" childern ====> " + Human.childernNumber);



            /////////// inheritance ////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////

            //Parent parent = new Parent();
            //Child child = new Child();
            //GrandChild grandChild = new GrandChild();

            //parent.sayHi();
            //Console.WriteLine(parent.lastName);
            //Console.WriteLine(Parent.nickName);

            //child.sayHi();
            //child.play();
            //Console.WriteLine(child.lastName);
            //Console.WriteLine(child.age);
            //Console.WriteLine(Child.nickName);

            //grandChild.cry();
            //grandChild.sayHi();
            //Console.WriteLine(grandChild.lastName);
            //Console.WriteLine(grandChild.milk);
            //Console.WriteLine(GrandChild.nickName);



            ////////////// abstract classes /////////////////////////////////////
            ////////////////////////////////////////////////////////////////////


            //// abstract class can not be generating objects
            //  AbstractClass.hello();

            //// all abstact methods need to be impelemented in the childs 
            //AbstractClassChild abstractClassChild = new AbstractClassChild("hillal");
            //abstractClassChild.helloWord();
            //abstractClassChild.showChildName();

            //////// method overriding /////////////////////////
            ////////////////////////////////////////////////////
            ///

            //Dog dog = new Dog();
            //Cat cat = new Cat();

            //dog.speak();
            //cat.speak();


            ///////////////// ploymorphism /////////////////////////
            ////////////////////////////////////////////////////////

            // polymorphisim is the childern inhirirts the same properties
            // form the parents and if we need to have an array of different
            // children we simply assign the array to the parent

            //Dog dog = new Dog();
            //Cat cat = new Cat();

            //Animal[] animals = { dog, cat };


            ///////////////////////// interfaces //////////////////
            ///////////////////////////////////////////////////////
            ///

            //Lion lion = new Lion();

            //lion.eat();
            //lion.hunt();
            //lion.jump();
            //lion.play();

            //Cheata cheata = new Cheata();

            //cheata.eat();
            //cheata.hunt();
            //cheata.jump();
            //cheata.play();
            //cheata.run();

            ///////////////////////////////// list ////////////////
            //////////////////////////////////////////////////////
            //////////

            //List<String> food = new List<String>();

            //food.Add("pizza");
            //food.Add("pie");
            //food.Add("bread");
            //food.Add("spagiti");
            //food.Add("pasta");


            //food.Remove("pasta");
            //food.Insert(0, "soup");

            //Console.WriteLine("count ===> " + food.Count());
            //Console.WriteLine("soup index ===> " + food.IndexOf("soup"));

            //foreach (String meal in food)
            //{
            //    Console.WriteLine(" ===> " + meal);
            //}

            //////////////// getters and setters ////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////
            ////

            //Car car = new Car(30);
            //Console.WriteLine(" car speed1 ====> " + car.Speed);

            //car.Speed = 90;
            //Console.WriteLine(" car speed2 ====> " + car.Speed);



            ///////////////////////// enums //////////////////////////
            ////////////////////////////////////////////////////////


            //Console.WriteLine($"the month {Enumerations.January}" +
            //    $"is the {(int)Enumerations.January} "+
            //    $"in the row");



            ////////////////   generics ///////////////////////////
            //////////////////////////////////////////////////////
            ///


            //String[] schools = { "NYU", "CUNY" };
            //int[] numbers = { 1, 2};
            //double[] doubles = { 2.4, 3.5};

            //Gernerics.displayElements(schools);
            //Gernerics.displayElements(numbers);
            //Gernerics.displayElements(doubles);


            //////////////// Threads /////////////////////////
            //////////////////////////////////////////////////

            Threads.showThreads();


        }
    }


}

