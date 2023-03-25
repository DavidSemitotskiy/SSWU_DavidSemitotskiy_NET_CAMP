namespace SnakeMatrixFill
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input rows number: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Input cols number: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            PrintMatrix(matrix);
            Console.WriteLine();
            ClockWiseMatrixFill(matrix);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        public static void ClockWiseMatrixFill(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int count = 0;

            bool leftDirection = false;
            int leftOffset = 0;

            bool rightDirection = false;
            int rightOffset = 0;

            bool topDirection = false;
            int topOffset = 0;

            bool bottomDirection = true;
            int bottomOffset = 0;

            while (count < matrix.Length)
            {
                if (leftDirection)
                {
                    for (int i = cols - leftOffset - 1; i >= rightOffset; i--)
                    {
                        matrix[bottomOffset, i] = count;
                        count += 1;
                    }

                    bottomOffset += 1;
                    leftDirection = false;
                    bottomDirection = true;
                }

                else if (rightDirection)
                {
                    for (int i = rightOffset; i < cols - leftOffset; i++)
                    {
                        matrix[rows - topOffset - 1, i] = count;
                        count += 1;
                    }

                    topOffset += 1;
                    rightDirection = false;
                    topDirection = true;
                }

                else if (topDirection)
                {
                    for (int i = rows - topOffset - 1; i >= bottomOffset; i--)
                    {
                        matrix[i, cols - leftOffset - 1] = count;
                        count += 1;
                    }

                    leftOffset += 1;
                    topDirection = false;
                    leftDirection = true;
                }

                else if (bottomDirection)
                {
                    for (int i = bottomOffset; i < rows - topOffset; i++)
                    {
                        matrix[i, rightOffset] = count;
                        count += 1;
                    }

                    rightOffset += 1;
                    bottomDirection = false;
                    rightDirection = true;
                }
            }
        }
    }
}
