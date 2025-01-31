////// all types of methods in C#
////using System;

////namespace ConsoleAppWiproJan2025.Day_3
////{
////    internal class methods_demo
////    {
////        static void Main(string[] args)
////        {
////            // static void method
////            method1();

////            //public void method
////            methods_demo o1 = new methods_demo();
////            o1.method2();

////           // method2();           //error 
////        }
////        public static void method1()
////        {
////            Console.WriteLine("static void method is invoked");
////        }
////        public void method2()
////        {
////            Console.WriteLine("Public void method is invoked");
////        }
////    }
////}
////===================================================================================================================

//// all types of methods in C#
//using System;

//namespace ConsoleAppWiproJan2025.Day_3
//{
//    internal  class methods_demo
//    {
//        static void Main(string[] args)
//        {
//            //// static void method
//            //A.method1();

//            ////public void method
//            //A o1 = new A();
//            //o1.method2();            

//            //// method2();           //error 
//            ///
//            //B obj= new B();
//            //obj.method1();   //error 
//            //obj.method2();
//            //obj.method3();


//            A obj= new A();
//            obj.method2();

//           // A.method1();   // public static void method1() can be accessed 
//           //private static method can not be accessed 
            
//        }
//    }


//    public class A
//    {
//        protected static void method1()            // private, public, protected 
//        {
//            Console.WriteLine("static void method is invoked");
//        }
//        public void method2()
//        {
//            method1();
//            Console.WriteLine("Public void method is invoked");
//        }
//    }
//}

