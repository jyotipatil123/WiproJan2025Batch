// File handling concept 
using System;
using System.IO;

namespace ConsoleAppWiproJan2025.Day_5
{
     class filehandling_demo
    {
        static void Main(string[] args)
        {
            //FileInfo f1 = new FileInfo(@"c:\demo\program1.cs");
            //Console.WriteLine(f1.Name);
            //Console.WriteLine(f1.FullName);
            //Console.WriteLine(f1.Length);
            //Console.WriteLine(f1.DirectoryName);
            //Console.WriteLine(f1.CreationTime);
            //Console.WriteLine(f1.LastWriteTime);
            //Console.WriteLine(f1.Extension);
         
            //DriveInfo  df=  new DriveInfo("c:\\");
            //Console.WriteLine(df.TotalSize);
            //Console.WriteLine(df.Name);
            //Console.WriteLine(df.AvailableFreeSpace);

            //DirectoryInfo dinfo = new DirectoryInfo("c:\\demo");
            //Console.WriteLine(dinfo.Name);
            //Console.WriteLine(dinfo.FullName);
            //Console.WriteLine(dinfo.Parent);
            //Console.WriteLine(dinfo.CreationTime);
            //Console.WriteLine(dinfo.LastWriteTime);
            //Console.WriteLine(dinfo.Extension);

            //================================================File operations 
            // reading from a file 
            //string filePath = @"c:\demo\program1.cs";
            //string content;

            //// Read the file using StreamReader
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    content = reader.ReadToEnd();
            //    Console.WriteLine(content);
            //}

            //// Read the file using File.ReadAllText
            //content = File.ReadAllText(filePath);
            //Console.WriteLine(content);
            //================================================================

            string filePath = @"c:\demo\program1.cs";
            string content = "Hello, World!";

            // Write to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(content);
            }
            //=============================================================
            // writealltext 
            content = "Hello, World!";

            // Write to the file using File.WriteAllText
            File.WriteAllText(filePath, content);
            //================================================================
            // appending in to a file
            content = "Appending this line.";

            // Append to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(content);
            }
            // delete a file
            File.Delete(filePath);
            File.Copy(filePath, content);
        }
    }
}
