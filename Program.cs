using System;
using System.IO;

namespace Files_handlings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("File_Handling.......!!");
            FileStream fs = new FileStream("D:\\Repos File\\MyFile.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("We Can Read and Display From File");
            string str = sr.ReadToEnd();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
        }
    }
}
