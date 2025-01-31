//// methods with parameter and methods with return type
//using System;

//namespace ConsoleAppWiproJan2025.Day_3
//{
//    class methods_demo2
//    {
//        static void Main(string[] args)
//        {
//            method1();

//            methods_demo2 obj = new methods_demo2();
//            Console.WriteLine("Addition result is : " + obj.add(10, 20));
//            //or
//            var sum = obj.add(10, 20);
//            Console.WriteLine("sum is :" + sum);
//        }
//        static void method1()
//        {
//            Console.WriteLine("static void method is invoked");
//        }
//        public int add(int a, int b)
//        {
//            return (a + b);
//        }

//        public int sub(int a, int b)
//        {
//            var result = a + b;
//            return (result);
//        }


//        //public object mult(object a, object b)
//        //{
//        //    object sum = (object)(a + b);
//        //    return (sum);
//        //}

//        //correct
//        public object sum(object a, object b)
//        {
//            object result = (int)(a) + (int)( b);
//            return result;
//        }
            
//        public double sum(double a, double b)
//        {
//            var result= a + b;
            
//            return result;
//        }

//        //int num1 = (int)a;
//        //int num2 = (int)b;
//        //return num1* num2;


//    }
//}

