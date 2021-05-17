using System;

namespace M
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());


            char[][] matrix = new char[rows][];

            int[] positionMario = new int[2];


            for (int row = 0; row < rows; row++)   //зареждам матрицата
            {
                string input = Console.ReadLine();

                matrix[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];
                }

            }

            for (int row = 0; row < matrix.Length; row++)    //намирам Марио
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'M')
                    {
                        positionMario[0] = row;
                        positionMario[1] = col;
                    }

                }

            }


            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = commands[0];
                int monsterRow = int.Parse(commands[1]);
                int monsterCol = int.Parse(commands[2]);

                matrix[monsterRow][monsterCol] = 'B';

                int lastRow= positionMario[0];
                int lastCol = positionMario[1];
               
                matrix[lastRow][lastCol] = '-';
               
                positionMario = GetMove(positionMario, direction);
                marioLives -= 1;


                if (positionMario[0] < 0 || positionMario[0] >= matrix.Length || positionMario[1] < 0 || positionMario[1] >= matrix[0].Length)
                {
                    positionMario[0] = lastRow;
                    positionMario[1] = lastCol;
                    
                    matrix[lastRow][lastCol] = 'M';
              
                }

                else
                {
                    if (matrix[positionMario[0]][positionMario[1]] == 'P')
                    {

                        matrix[positionMario[0]][positionMario[1]] = '-';
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                        break;
                    }

                    else if (matrix[positionMario[0]][positionMario[1]] == 'B')
                    {
                        marioLives -= 2;
                        if (marioLives > 0)
                        {

                        }
                        else
                        {
                            matrix[positionMario[0]][positionMario[1]] = 'X';
                            Console.WriteLine($"Mario died at {positionMario[0]};{positionMario[1]}.");
                            break;
                        }
                    }

                    if (marioLives <= 0)
                    {
                        matrix[positionMario[0]][positionMario[1]] = 'X';
                        Console.WriteLine($"Mario died at {positionMario[0]};{positionMario[1]}.");
                        break;
                    }

                    matrix[positionMario[0]][positionMario[1]] = 'M';
                  //  matrix[lastPositionM[0]][lastPositionM[1]] = '-';
                }
                             
            
            
            }


            Print(matrix);

        }

        public static void Print(char[][] matrix)
        {

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);

                }
                Console.WriteLine();

            }
        }

        public static int[] GetMove(int[] position, string direction)
        {

            if (direction == "W")  //up
            {
                position[0] -= 1;
            }
            else if (direction == "S")     //down
            {
                position[0] += 1;
            }

            else if (direction == "A")    //left
            {
                position[1] -= 1;
            }
            else if (direction == "D")   //right
            {
                position[1] += 1;
            }


            return position;
        }

        public static bool IsInvalid(char[][] matrix, int[] position)
        {

            if (position[0] < 0 && position[0] >= matrix.Length && position[1] < 0 && position[1] >= matrix[0].Length)
            {
                return true;
            }
            return false;
        }


    }
}
