////using System;
////class MyClass
////{
////    static void Main(string[] args)
////    {
////        A.class1 obj = new A.class1();
////        obj.function1();

////        B.class2 obj2 = new B.class2();
////        obj2.function2();

////        C.class3 obj3 = new C.class3();
////        obj3.function3();
////    }

////}



//// Nested namespaces demo
//// File: Program.cs
//using System;

//namespace MyNamespace
//{
//    // Class within MyNamespace
//    public class MyClass
//    {
//        public void MyMethod()
//        {
//            Console.WriteLine("Hello from MyMethod!");
//        }
//    }

//    // Nested namespace
//    namespace NestedNamespace
//    {
//        // Class within NestedNamespace
//        public class NestedClass
//        {
//            public void NestedMethod()
//            {
//                Console.WriteLine("Hello from NestedMethod!");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Accessing class within MyNamespace
//        MyNamespace.MyClass myClass = new MyNamespace.MyClass();
//        myClass.MyMethod();

//        // Accessing class within NestedNamespace
//        MyNamespace.NestedNamespace.NestedClass nestedClass = new MyNamespace.NestedNamespace.NestedClass();
//        nestedClass.NestedMethod();
//    }
//}
