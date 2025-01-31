//using System;
//using System.Text;

//namespace ConsoleAppWiproJan2025
//{
//     class demo
//    {
//        static void Main()
//        {
//            //string and stringbuilder

//            //collection of characters --string 

//            // immutable, mutable ??

//            // 

//            string s1 = "welcome";        //immutable and mutable
//            Console.WriteLine(s1);

//            s1 = "bye";
//            Console.WriteLine(s1);

//            Console.WriteLine(s1.ToLower());
//            Console.WriteLine(s1.ToUpper());

//            //StringBuilder sb=new StringBuilder();

//            // string is immutable
//            string strMyValue = "Hello Visitor";
//            // create a new string instance instead of changing the old one
//            strMyValue += "How Are";
//            strMyValue += "You ??";
//            Console.WriteLine(strMyValue);

//            //==================================================================           
//            // stringbuilder is mutable 
//            StringBuilder sbMyValue1 = new StringBuilder("Hello");
//            sbMyValue1.Append("Visitor");
//            sbMyValue1.Append("How Are You ??");
//            string strMyValue1 = sbMyValue1.ToString();
//            Console.WriteLine(strMyValue1);
//        }
//    }
//}
