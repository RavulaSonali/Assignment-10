using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create jagged array for student scores
                int[][] studentScores = new int[3][];

                studentScores[0] = new int[3] { 85, 92, 78 };
                studentScores[1] = new int[4] { 90, 87, 93, 89 };
                studentScores[2] = new int[2] { 76, 88 };
            

            // Print scores of each student using nested loops
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1} Scores: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"{studentScores[i][j]} ");
                }
                Console.WriteLine();
            }

            // Calculate and print the average score for each student
            
            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = sum / studentScores[i].Length;
                Console.WriteLine($"Average score for Student {i + 1}: {average:F2}");
            }

            // Calculate and print the average score for all students combined
            double totalSum = 0;
            int totalScores = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalScores++;
                }
            }

            double totalAverage = totalSum / totalScores;
            Console.WriteLine($"Average score for all students combined: {totalAverage:f2}");

            Console.ReadKey();
        }
    }

}
   

