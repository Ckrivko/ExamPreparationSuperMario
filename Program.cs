using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            
            int rows= int.Parse(Console.ReadLine());


            char[][] matrix = new char[rows][];


            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();

                matrix[i] = new char[input.Length];
                
               
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
