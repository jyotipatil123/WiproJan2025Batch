////inheritance 
//using System;

//namespace ConsoleAppWiproJan2025.Day_4
//{
//    class vehicle
//    {
//        public int number;
//        public string name;
//        public string make;

//        public void displaydetails()
//        {
//            Console.WriteLine("number of vehicle : "+ number);
//            Console.WriteLine("name of vehicle :" + name);
//            Console.WriteLine("make of vehicle : " + make);
//        }
//    }

//    class car : vehicle    //single level inheritance 
//    {
//        public string color;
//        public void makeofcar()
//        {
//            Console.WriteLine("make of car is : 2024 ");
//        }
//    }
//    class bike : car  // multi level inheritance
//    {
//        public string color;
//        public void makeofbike()
//        {
//            Console.WriteLine("make of bike is : 2023");
//        }
//    }

//    class truck : car
//    {

//    }


//     class inheritance_demo
//    {
//        static void Main(string[] args)
//        {
//            // single level inheritance 
//            //bike b1 = new bike();
//            //b1.number = 102;
//            //b1.name = "honda";
//            //b1.make = "2023";
//            //b1.makeofbike();
//            //b1.displaydetails();

//            //car c1= new car();
//            //c1.number = 101;
//            //c1.make = "2024";
//            //c1.makeofcar();
//            //c1.displaydetails();

//            //multi level inheritance 
//            bike b1= new bike();

//            //b1.number = 1;
//            //b1.name = "Test";
//            //b1.make = "Test123";

//            //b1.displaydetails();
//            //b1.makeofbike();
//            //b1.makeofcar();


//            bike b20 = new bike();    //base
//            b20.color = "green";
//            b20.color = "red";


//            //car c1= new car();
//            //c1.color = "red";
//        }
//    }
//}
