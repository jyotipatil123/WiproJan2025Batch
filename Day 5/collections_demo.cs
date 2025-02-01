////// collection classes demo

////using System;
////using System.Collections;
////using System.Collections.Generic;


////namespace ConsoleAppWiproJan2025.Day_5
////{
////     class collections_demo
////    {
////        static void Main(string[] args)
////        {
////            //Stack s1 = new Stack(); //LIFO  last in first out
////            //s1.Push(1);
////            //s1.Push(2);
////            //s1.Push(3);
////            //s1.Push(4);
////            //s1.Push(5);

////            //Console.WriteLine("stack elements are :");
////            //foreach (var item in s1)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //=============================================================

////            //Stack s1 = new Stack(); //LIFO  last in first out
////            //s1.Push(10);
////            //s1.Push('a');
////            //s1.Push("bangalore");
////            //s1.Push(4.3344f);
////            //s1.Push(5234.888);

////            //Console.WriteLine("stack elements are :");
////            //foreach (var item in s1)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //s1.Pop();

////            //Console.WriteLine("stack elements are :");
////            //foreach (var item in s1)
////            //{
////            //    Console.WriteLine(item);
////            //}

////            //Console.WriteLine("Top most element in stack : "+s1.Peek());
////            //// s1.Clear();
////            //Console.WriteLine("Count of stack is : "+ s1.Count);
////            ////============================================================
////            //Queue q1= new Queue();  // FIFO
////            //q1.Enqueue(10);
////            //q1.Enqueue(11);
////            //q1.Enqueue(12);
////            //q1.Enqueue(13);
////            //q1.Enqueue(14);

////            //Console.WriteLine("Queue elements are : ");
////            //foreach (var item in q1)
////            //{
////            //    Console.WriteLine(item);
////            //}

////            //q1.Dequeue();
////            //Console.WriteLine("Queue elements are : ");
////            //foreach (var item in q1)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //Console.WriteLine("Queue top most element is : "+ q1.Peek());
////            //Console.WriteLine(q1.Count);

////            //  arraylist 
////            ArrayList arr1 = new ArrayList();
////            arr1.Add(1);
////            arr1.Add(2);
////            arr1.Add(3);
////            arr1.Add(4);

////            Console.WriteLine("Arraylist elements are : ");
////            foreach(int i in arr1) 
////                Console.WriteLine(i);

////            //arr1.Clear();
////            //arr1.Count

////            Stack s1 = new Stack(); //LIFO  last in first out
////            s1.Push(10);
////            s1.Push('a');
////            s1.Push("bangalore");
////            s1.Push(4.3344f);
////            s1.Push(5234.888);

////            arr1.AddRange(s1);

////            int[] myarray= new int[3] {10,20,30};
////            arr1.AddRange(myarray);

////            Console.WriteLine("Now arraylist elements are : ");
////            foreach (var item in arr1)
////            {
////                Console.WriteLine(item);
////            }


////            // remove all elements from 0th index , 3 elements 
////            arr1.RemoveRange(0, 3);

////            arr1.Reverse();

////            arr1.Remove(20);  // remove the element 20 from the arraylist

////            arr1.RemoveAt(0); // remove at 0th position element



////            //==============================================================

////        }
////    }
////}


//// hash table and sortedlist

//using System;
//using System.Collections;
//using System.Collections.Generic;
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //Hashtable ht = new Hashtable();
//        //ht.Add("d", 4);
//        //ht.Add("a", 1);       
//        //ht.Add("c", 3);       
//        //ht.Add("b", 2);

//        //Console.WriteLine("All keys : ");
//        //foreach (string s in ht.Keys)
//        //{
//        //    Console.WriteLine(s);
//        //}

//        //Console.WriteLine("All Values : ");
//        //foreach (int s in ht.Values)
//        //{
//        //    Console.WriteLine(s);
//        //}

//        //Console.WriteLine("Keys and values : ");
//        //foreach(DictionaryEntry s in ht)
//        //{
//        //    Console.WriteLine(s.Key + "  "+ s.Value);
//        //}

//        //foreach (var key in ht.Keys)
//        //{
//        //    Console.WriteLine((string)key);
//        //    break; // Exit after printing the first key
//        //}

//        //// Iterate through the keys to find a particular key
//        //string searchKey = "a";
//        //foreach (var key in ht.Keys)
//        //{
//        //    if ((string)key == searchKey)
//        //    {
//        //        Console.WriteLine("Found key: " + key);
//        //        break;
//        //    }
//        //}

//      //  ht.CopyTo

//        //// sorted list
//        //SortedList sl= new SortedList();
//        //sl.Add("Delhi", 3);
//        //sl.Add("Bangalore", 1);
//        //sl.Add("Mysore", 2);        

//        //foreach (DictionaryEntry item in sl)
//        //{
//        //    Console.WriteLine(item.Key+"   "+item.Value);
//        //}
//        ////sl.Clear();
//        ////sl.Count;
//        ////sl.Remove(0);
//        ////sl.RemoveAt(0);
//        ////sl.CopyTo();
        
//        Stack<int> stack = new Stack<int>();
//        stack.Push(1);
//        stack.Push(2);
//        stack.Push(3);
//        stack.Push('a');

//        //stack.Push("anita");   // error
//        //stack.Push(222.333f);  // error 

//        foreach (var item in stack)
//        {
//            Console.WriteLine(item);
//        }
      
//        // List collection
//        List<int> ls = new List<int>();
//        ls.Add(1);
//        ls.Add(2);
//        ls.Add(3);
//        ls.Add(4);
//        Console.WriteLine("List elements are : ");
//        foreach (var item in ls)
//        { 
//            Console.WriteLine(item); 
//        }

//        for (int i = 0; i < ls.Count; i++)
//        {
//            Console.WriteLine(ls[i]);
//        }

//        ls.Sort();
//        ls.Reverse();
//        //ls.FindLastIndex();


//    //====================================================================================
//      Queue<int> queue = new Queue<int>();

//      HashSet<int> hs = new HashSet<int>();
//      hs.Add(1);
//      hs.Add(2);
//      hs.Add(3);
//        Console.WriteLine("Hashset elements are : ");
//        foreach (var item in hs)
//        {
//            Console.WriteLine(item);
//        }

//     // hashtable  ..... non generic
      
//      SortedList<int, int> sl= new SortedList<int, int>();  
//     // ArrayList  ..... non generic 

//    }
//}