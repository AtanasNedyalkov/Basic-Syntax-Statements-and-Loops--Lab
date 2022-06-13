using System;

namespace Basic_Syntax__Statements_and_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: {studentName}, Age: {studentAge}, Grade: {studentGrade}
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double stundetGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {stundetGrade:f2}");
        }
    }
}
