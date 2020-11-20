using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero.");
            }

            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if(fileName == null || fileName == "")
            {
                throw new ArgumentException("Filename submission cannot be empty or blank.");
            }

            if(fileName.EndsWith(".cs"))
            {
                return 1;
            }

            return 0;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(2, 0);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Divide(10, 2));


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> pair in students)
            {
                try
                {
                    Console.WriteLine(pair.Key + " points: " + CheckFileExtension(pair.Value));
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(pair.Key + ": " + e.Message);
                }   
            }
        }
    }
}
