using System;

namespace GradeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            string answer , letterGrade;
            Console.WriteLine("Please enter in your grade:");
            answer = Console.ReadLine();
            do
            {
                while (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine("You did not enter in a number. Please try agian!");
                    answer = Console.ReadLine();
                }
                letterGrade = GradeConverstion(grade);
                Console.WriteLine($"Congrats you have a {letterGrade}");
                Console.WriteLine("Do you want to convert another grade yes or no");
                answer = Console.ReadLine();
            } while (answer[0] == 'y');

        }

        /// <summary>
        /// Converts a number grade to a letter grade
        /// </summary>
        /// <param name="grade"> A double reprsenting the grade </param>
        /// <returns>
        /// The letter grade associated with the grade and N/A if the grade is below 0
        /// </returns>
        static string GradeConverstion(double grade)
        {
            string letter = "";
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else if (grade >= 0)
            {
                letter = "F";
            }
            else
            {
                letter = "N/A";
            }
            return letter;
        }
    }
}
