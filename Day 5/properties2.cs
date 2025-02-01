//using System;

//class book
//{
//    private string title = "Harry Potter";

//    public string Title
//    {
//        get      //read only
//        {
//            return title;
//        }
//    }

//    public string Author
//    {
//        set      //write only
//        {
//            Author = value;  // value is a keyword -- set the std value from the compiler -- default value is set
//        }
//    }

//    int price;
//    public int Price
//    {
//        get
//        {
//            return price;
//        }
//        set
//        {
//            price = value;
//            price = price * 100;
//        }
//    }

//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        book b1 = new book();
//        //b1.Title = "Test"; // error cuz set to read only can not write
//        Console.WriteLine("Title of book : " + b1.Title);
//        b1.Author = "JK";
//        //Console.WriteLine("Author of book : "+b1.author); // error cuz set to write only
//        b1.Price = 10;
//        Console.WriteLine($"Price of book is : {b1.Price}");


//    }
//}