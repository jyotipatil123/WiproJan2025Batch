//using System;

//namespace ConsoleAppWiproJan2025.Day_5
//{
//    //interface i1
//    //{
//    //    int a = 10;   // error 
//    //     void addition();
//    //     void substraction();
//    //}
//    abstract class computer
//    {
//         int x = 100;
//        public abstract void addition();
//        public  void details()
//        {
//            Console.WriteLine(x);
//            Console.WriteLine("computer details");
//        }
//    }

//    class mouse : computer
//    {
//        public override void addition()
//        {
//            x = 1000;
//            Console.WriteLine("addition() is invoked ");
//        }
//        public  void details()
//        {
//            x = 10000;
//            Console.WriteLine("mouse details");
//        }
//    }

//    class abstraction_demo
//    {
//        static void Main(string[] args)
//        {
//            mouse m1 = new mouse();
//            m1.addition();
//            m1.details();
//            //m1.x...............error
//            m1.x = 1000;

//            mouse m1 = new computer();     // error
//            computer c1 = new computer();   // error



//            computer c2 = new mouse();  // 
//            c2.addition();
//            c2.details();
//            c2.x = 1000;
//        }
//    }
//}
