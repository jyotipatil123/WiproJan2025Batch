//// File: Program.cs
//using System;

//namespace MyNamespace
//{
//    public class BaseClass
//    {
//        protected internal void ProtectedInternalMethod()
//        {
//            Console.WriteLine("Hello from ProtectedInternalMethod!");
//        }
//    }
//    public class DerivedClass : BaseClass
//    {
//        public void CallProtectedInternalMethod()
//        {
//            // Accessible within derived class
//            ProtectedInternalMethod();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BaseClass baseClass = new BaseClass();
//            DerivedClass derivedClass = new DerivedClass();

//            // Accessible within the same assembly
//            baseClass.ProtectedInternalMethod();

//            derivedClass.CallProtectedInternalMethod();
//        }
//    }
//}
