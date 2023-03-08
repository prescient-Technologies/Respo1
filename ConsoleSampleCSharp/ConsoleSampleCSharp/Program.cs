using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleSampleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			System.Console.WriteLine("Hello World!");
			String fullPath =  System.Environment.CurrentDirectory + "/myfile.txt";
			using (StreamWriter writer = new StreamWriter(fullPath))
{
   writer.WriteLine("This is sample output file.");
   writer.WriteLine("It is generated through C# code.");
}

        }
    }
}
