//// abstract class demo
//using System;

//namespace ConsoleAppWiproJan2025.Day_4
//{
//     abstract class india
//    {
//        public abstract void welcome();   //function signature 
//        public void display()
//        {
//            Console.WriteLine("display function is invoked");
//        }
//    }
//    class US : india
//    {
//        public override void welcome()
//        {
//            Console.WriteLine("Welcome to our country");
//        }
//    }

//    class abstract_demo
//    {
//        static void Main(string[] args)
//        {
//            US obj = new US();
//            obj.welcome();
//            obj.display();

//        }
//    }
//}


using System;

struct MyStruct
{
    public void display()
    {
        Console.WriteLine("display function");
    }
}

interface i1 : MyStruct
{

}