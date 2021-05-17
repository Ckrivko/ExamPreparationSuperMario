using System;

namespace MArio
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());


            char[][] matrix = new char[rows][];


            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                matrix[row] = new char[input.Length];
               
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];
                }

            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);

                }
                Console.WriteLine();

            }
        }
    }
}
