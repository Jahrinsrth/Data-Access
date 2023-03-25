using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data_access
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________");

            string filePath = @"F:\Projects\testing\test.txt";

            // reading from the file
            // return a string array and we convert that to a list
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("This is from 3rd line");

            // writing to the file
            File.WriteAllLines(filePath, lines);

            // stops the console from closing out 
            Console.ReadLine();
        }
    }
}
