using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TextFiles
{
    /* Week 3: Individual: Text Files
     * Marcia L. Allen
     * November 14, 2016
     * Store ten student names and their individual score in a text file 
     * such as Notepad. There will be one score per student. For example,
     * a line in the file may look as such: Carole McKinney, 95 
     * Write a C# program using Microsoft® Visual Studio® to retrieve the 
     * names and the scores. This program may be a console application or 
     * a Windows Forms application. No matter whether you choose to develop
     * a Windows Forms application or a console application, be sure the 
     * interface is professional looking and intuitive to use for the novice end user. 
     * Display the highest score and the average score of the class.
     * Show to the user what is being read from the input file.
     * Hint: You might consider adding delimiters between the data values in the 
     * original text file to simplify retrieving and processing the data.
     * Notes: If you would like the file to include more data than 10 records, 
     * it is acceptable to do so, but you must have at least 10 records. In 
     * addition, you do not need to validate the input data - that is beyond 
     * the scope of the assignment at this point. For the highest score, if you 
     * would like, you can also report the student name who had it, but it is not required.
     * Include identifying information in the form of block comments at the top 
     * of each class in the project (programmer name, date, program description).
     * Include adequate comments throughout the program, utilize meaningful names 
     * for controls, variables, fields, and forms. Include white space for 
     * readability purposes in the code. Refer to the Programming Assignment 
     * grading form to view grading criteria.
     */

    class TextFiles
    {
        static void Main(string[] args)
        {

            //  Message describing what is being displayed
            Console.WriteLine("Contents of Text File:\n");
            Console.WriteLine("Student Name: \t\tGrade: ");
            Console.WriteLine("==============================\n");

            //  Identifying the file to be read
            String file = "StudentScores.txt";
            String record ="";
            StreamReader inReader;

            //  Initialize ArrayList to hold the character based name and the numeric based grade
            ArrayList name = new ArrayList();
            ArrayList grade = new ArrayList();

            //  Initialize variables
            Int32 count;
            Int32 total = 0;
            Int32 max = 0;
            Int32 sum;
            double avg = 0.0;

            //  Read file
            inReader = new StreamReader(file);

            //  While Loop to Split the records determined by comma delimiter, 
            //  Add data found at index {0} to Array List name,
            //  Add data found at index {1} to Array List grade, converting it to Int32
            while((record = inReader.ReadLine()) != null)
            {
                String[] records = record.Split(',');
                name.Add(records[0]);
                grade.Add(Int32.Parse(records[1]));
            }

            //  For loop that Display the name and grade for each record found in the text file,
            //  Total grades and convert to a string, and determine which grade is the highest
            for (count = 0; count < name.Count; count++)
            {
                Console.WriteLine(name[count] + "\t\t" + grade[count]);

                sum = Int32.Parse(grade[count].ToString());
                total += sum;

                if (count == 0)

                   max = sum;

                else if (sum > max)

                   max = sum;
            }

            //  Caluculate the average grade by dividing the total by the count of records
            avg = total / name.Count;

            //  Display the highest grade and the average grade
            Console.WriteLine("\nThe Highest Grade is " + max);
            Console.WriteLine("\nThe Average Grade is " + avg + "\n");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
