////// constructors demo
////using System;

////namespace ConsoleAppWiproJan2025.Day_5
////{
////    class employee
////    {
////        public employee()  // default constructor 
////        {
////            Console.WriteLine("default constructor is invoked");
////        }
////        //public employee(string fn, string ln)  // parameterized constructor 
////        //{
////        //    Console.WriteLine("parameterized constructor is invoked"+" "+ fn+" "+ln);
////        //}
////        static employee()  // executed first
////        {
////            Console.WriteLine("static constructor is invoked ");
////        }
////    }
////     class constructor_demo
////    {
////        static void Main(string[] args)
////        {
////            // default constructor invokation
////            //employee e1 = new employee();


////            // parameterized constructor invokation
////            //employee e2= new employee("suresh","Nair");    

////            // static constructor invokation
////            employee e1 = new employee();
////            employee e2= new employee();
////            employee e3 = new employee();

////        }
////    }
////}


//// diamond problem 

//using System;
//using System.Runtime.InteropServices.WindowsRuntime;

//namespace CSharpConsoleApp.DiamondProblemExample
//{
//    public class A
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("Print method of class A.");
//        }
//    }

//    public class B : A
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Print method of class B");
//        }
//    }

//    public class C : A
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Print method of class C");
//        }
//    }

//    // Error: D class can not have multiple base classes.
//    public class D : C, B
//    {

//    }

//    class DiamondProblemExample
//    {
//        static void Main(string[] args)
//        {
//            D obj = new D();
//            obj.Print();
//        }
//    }
//}