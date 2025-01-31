//////structures demo
////using System;

////namespace ConsoleAppWiproJan2025.Day_4
////{
////    // different types of data 
////    // arrays -similar type of data
////    // class vs structure 
////	struct Book
////	{
////		public int bookid;
////		public string bookname;
////        public void details()
////        {
////            Console.WriteLine("details about the book ");
////        }
////	}

////    //struct Book2 :Book1             //inheritance not possible 
////    //{ 
////    //    public int bookid;
////    //    public string bookname;
////    //    public void details()
////    //    {
////    //        Console.WriteLine("details about the book ");
////    //    }
////    //}
////    class MyClass 
////	{
////        static void Main(string[] args)
////        {
////            Book book1= new Book();
////            book1.bookid = 100;
////            book1.bookname = "test";
////            book1.details();

////            Console.WriteLine("Book1 details");
////            Console.WriteLine("Id" + book1.bookid);
////            Console.WriteLine("bookname" + book1.bookname);


////            Book book2 = new Book();
////            book2.bookid = 100;
////            book2.bookname = "test";

////            Console.WriteLine("Book2 details");
////            Console.WriteLine("Id" + book2.bookid);
////            Console.WriteLine("bookname" + book2.bookname);
////        }
////    }
////}


//// enum
//using System;

//public class Program
//{
//    enum A
//    {
//        sunday, // 0
//        Monday, // 1
//        Tuesday, // 2
//        Wednesday, // 3
//        Thursday, // 4
//        Friday, // 5
//        Saturday // 6
//    }
//    public static void Main()
//    {
//        A today = A.sunday;
//        Console.WriteLine($"Today is : {today}");
//        Console.WriteLine("Today is : "+ today);

//        int dayValue = (int)today;
//        Console.WriteLine($"Numeric value of {today} is {dayValue}");
//    }
//}
