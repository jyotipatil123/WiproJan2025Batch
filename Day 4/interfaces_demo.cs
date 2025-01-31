//using System;

//namespace ConsoleAppWiproJan2025.Day_4
//{
//    //class 7.3 version 
//    // implicit interfaces 
//    interface ICalc1    
//    {
//        void Addition();      
//    }
//    interface ICalc2 : ICalc1     
//    {     
//        void Subtraction();   
//    }


//    class demo : ICalc2     //,......................................  // implementing the interface 
//    {
//         void ICalc1.Addition()           // explicit way of implementing interface 
//        {
//            int a=10, b=2;
//            Console.WriteLine("Addition result is : "+(a+b));
//        }

//         void ICalc2.Subtraction()
//        {
//            int a = 10, b = 2;
//            Console.WriteLine("Subtraction result is : " + (a + b));
//        }
//    }


//    class interfaces_demo
//    {
//        static void Main(string[] args)
//        {
//           //// ICalc obj = new ICalc();   //error
            
//           // demo d1= new demo();
//           // d1.Addition();
//           // d1.Subtraction();

//           // // or

//           // ICalc1 c1 = new demo(); // interface object can be initialized to class 
//           // c1.Addition();

//           // ICalc2 c2 = new demo();
//           // c2.Subtraction();

//            // explicit way

//            demo d1 = new demo();
//           // d1.addition();  //error
//           // d1.substraction(); //error

//            ICalc1 calc1 = new demo();
//            calc1.Addition();

//            ICalc2 calc2 = new demo();
//            calc2.Subtraction();

//        }
//    }
//}
