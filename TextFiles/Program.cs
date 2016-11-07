using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {

        // Read each line of the file into a string array. Each element
		// of the array is one line of the file.
		string[] lines = System.IO.File.ReadAllLines("Y:\GitHub\TextFiles\TextFiles\StudentScores.txt");

		// Display the file contents by using a foreach loop.
		System.Console.WriteLine("Contents of StudentScores.txt = ");

		foreach(string line in lines)
		{
			// Use a tab to indent each line of the file.
			Console.WriteLine("\t" + line);
		}

		// Keep the console window open in debug mode.
		Console.WriteLine("Press any key to exit.");
		System.Console.ReadKey();
        }
    }
}
