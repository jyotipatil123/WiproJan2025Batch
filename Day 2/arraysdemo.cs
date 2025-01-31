////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleAppWiproJan2025.Day_2
////{
////    internal class arraysdemo
////    {
////        static void Main(string[] args)
////        {
////            //single dimensional array    

////            //int[] arr= new int[10];
////            //arr[0] = 1;    arr[1] = 2;    arr[2] = 3;      arr[3] = 4;   arr[4] = 5;  arr[5] = 6;

////            //for (int i = 0; i < arr.Length; i++)
////            //{
////            //    Console.WriteLine(arr[i]);
////            //}
////            ////===========================================================
////            //int[] arr1 = { 10, 20, 21, 22 };  //declaration

////            //for (int i = 0; i < arr1.Length; i++)
////            //{
////            //    Console.WriteLine(arr1[i]);
////            //}
////            ////==============================================================
////            //int[] arr2 = new int[5] {1,2,3,4,5}; //declaration

////            //for (int i = 0; i < arr2.Length; i++)
////            //{
////            //    Console.WriteLine(arr2[i]);
////            //}
////            ////===============================================================
////            //int[] arr3 = new int[] {1,2,3,4,5}; //declaration

////            //for (int i = 0; i < arr3.Length; i++)
////            //{
////            //    Console.WriteLine(arr3[i]);
////            //}

////            // double dimensional arrays

////            int[,] arr = new int[2,2] 
////                { 
////                     {6,7} ,
////                     {4,5}
////                };

////            Console.WriteLine("Double dimensional array demo : ");
////            for (int i = 0; i < arr.GetLength(0); i++) //0        1   
////            {
////                for (int j = 0; j < arr.GetLength(1); j++)// 0  1  0  1
////                {
////                    Console.WriteLine(arr[i,j]);
////                }
////            }

////        }
////    }
////}

//// foreach loop

//using System;
//using System.Windows;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //int[] arr1 = new int[5] { 4, 5, 2, 3, 7 };

//        //foreach (int i in arr1)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        //Jagged array

//        int[][] arr1 = new int[3][];
//        arr1[0] = new int[3];
//        arr1[1] = new int[2];
//        arr1[2] = new int[4];

//        arr1[0][0] = 1;
//        arr1[0][1] = 2;
//        arr1[0][2] = 3;

//        arr1[1][0] = 4;
//        arr1[1][1] = 5;

//        arr1[2][0] = 6;
//        arr1[2][1] = 7;
//        arr1[2][2] = 8;
//        arr1[2][3] = 9;

//        // display jagged array using for loop
//        for (int i = 0; i < arr1.Length; i++)
//        {
//            for (int j = 0; j < arr1[i].Length; j++)
//            {
//                Console.Write(arr1[i][j] + " ");
//            }
//            Console.WriteLine();
//        }

//        // display jagged array using foreach loop
//        foreach (var array in arr1)
//        {
//            foreach (var item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }



//        int[,] matrix = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        Console.WriteLine("Secondary Diagonal Elements:");

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            Console.Write(matrix[i, matrix.GetLength(1) - 1 - i] + " ");
//        }
//        Console.WriteLine();



//    }
//}