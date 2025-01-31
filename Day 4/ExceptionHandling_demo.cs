//// Exception handling demo 
//using System;

//namespace ConsoleAppWiproJan2025.Day_4
//{
//    class ExceptionHandling_demo
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter first number : ");
//                int num1 = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter second number : ");
//                int num2 = int.Parse(Console.ReadLine());

//                float result = num1 / num2;
//                Console.WriteLine("Division result is : " + result);
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Divide by zero exception");
//            }

//            catch (Exception obj)
//            {
//                Console.WriteLine("Error.........." + obj.Message);
//            }
//            finally  //optional  // used to close all the pointers like file handling pointers 
//            {
//                Console.WriteLine("This block will always execute");
//            }
//        }
//    }
//}
