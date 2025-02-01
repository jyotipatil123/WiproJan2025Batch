////  properties demo
//using System;
//using System.Runtime.InteropServices.WindowsRuntime;

//namespace ConsoleAppWiproJan2025.Day_5
//{
//    //class employee
//    //{
//    //    public int a;
//    //    public int Id 
//    //    { 
//    //        get
//    //        {
//    //            return Id;
//    //        }
//    //    }  // get -read set -write  accessors


//    //    public string Name { get; set; } // automatic property
//    //    public string Description { get; set; }
//    //}
//    public class Book
//    {
//        private string title="c# programming";
//        public string Title
//        {
//            get                //read only 
//            { 
//                return title; 
//            }
//        }
//        public string author
//        {
//            set               //write only
//            {
//                author = value;    // value is a keyword -- VS- set the std value from the compiler -- default value is set 
//            }
//        }

//        int price = 1000;
//        public int Price
//        {
//            get
//            {
//                return price;
//            }
//            set
//            {
//                price = value;
//                price = price * 100;
//            }
//        }

//        public int year
//        {
//            get;set;            //automatic property
//        }

//    }
//    class properties_demo
//    {
//        static void Main(string[] args)
//        {
//            Book b1= new Book();
//            b1.Title = "C# programming ";  // you can read the value -error
//            Console.WriteLine(b1.Title);
//            b1.author = "Microsoft";
//            Console.WriteLine("Author is : "+ b1.author);  // you can write the value --can not read --error

//            b1.Price = 10000;
//            Console.WriteLine("Book price is : "+b1.Price);

//            b1.year = 2025;
//            Console.WriteLine(b1.year);

//            //employee emp = new employee();
//            //emp.Id = 1;  //error --made it as only get;
//            //emp.Name = "Saurabh";
//            //emp.Description = "Wipro";

//            //Console.WriteLine($"Employee id is :{emp.Id} ");
//            //Console.WriteLine($"Employee Name is :{emp.Name} ");
//            //Console.WriteLine($"Employee Description is :{emp.Description} ");
//        }
//    }
//}
