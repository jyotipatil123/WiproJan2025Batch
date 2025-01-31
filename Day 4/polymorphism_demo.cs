////// polymorphism
/////
//// method overloading concept
////using System;

////namespace ConsoleAppWiproJan2025.Day_4
////{
////    class demo
////    {
////        public void addition()
////        {
////            int a = 10, b = 20;
////            Console.WriteLine("Addition result is :"+(a+b));
////        }
////        public void addition(int a)
////        {
////           Console.WriteLine("Addition result is :" + (a + a));
////        }

////        public void addition(int a, int b)
////        {
////           Console.WriteLine("Addition result is :" + (a + b));
////        }
////    }




////     class polymorphism_demo
////    {
////        static void Main(string[] args)
////        {
////            demo d1=new demo();
////            d1.addition();
////            d1.addition(10);
////            d1.addition(20, 30);
////        }
////    }
////}

//// method overriding 

//// polymorphism
//using System;

//namespace ConsoleAppWiproJan2025.Day_4
//{
//    class demo1
//    {
//        public virtual void Addition()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("Addition result is :" + (a + b));
//        }      
//    }
//    class demo2 : demo1
//    {
//        public  override void Addition()
//        {
//            int a = 100, b = 200;
//            Console.WriteLine("Addition result is : "+(a+b));
//        }
//        //public void Addition(int a, int b)
//        //{
//        //   Console.WriteLine("Addition result is :" + (a + b));
//        //}
//    }

//    class polymorphism_demo
//    {
//        static void Main(string[] args)
//        {
//           // demo1 obj= new demo1();
//           // obj.Addition();


//           //demo2 obj1= new demo2();
//           //obj1.Addition();

//            demo2 demo = new demo2();
//            demo.Addition();
//          //  demo.Addition(10, 20);


//        }
//    }
//}
