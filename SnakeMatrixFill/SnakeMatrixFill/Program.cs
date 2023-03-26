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

            Direction currentDirection = Direction.Bottom;

            int leftOffset = 0;

            int rightOffset = 0;

            int topOffset = 0;

            int bottomOffset = 0;

            while (count < matrix.Length)
            {
                switch (currentDirection)
                {
                    case Direction.Left:
                        {
                            for (int i = cols - leftOffset - 1; i >= rightOffset; i--)
                            {
                                matrix[bottomOffset, i] = count;
                                count += 1;
                            }

                            bottomOffset += 1;
                            currentDirection = Direction.Bottom;
                            break;
                        }
                    case Direction.Right:
                        {
                            for (int i = rightOffset; i < cols - leftOffset; i++)
                            {
                                matrix[rows - topOffset - 1, i] = count;
                                count += 1;
                            }

                            topOffset += 1;
                            currentDirection = Direction.Top;
                            break;
                        }
                    case Direction.Top:
                        {
                            for (int i = rows - topOffset - 1; i >= bottomOffset; i--)
                            {
                                matrix[i, cols - leftOffset - 1] = count;
                                count += 1;
                            }

                            leftOffset += 1;
                            currentDirection = Direction.Left;
                            break;
                        }
                    case Direction.Bottom:
                        {
                            for (int i = bottomOffset; i < rows - topOffset; i++)
                            {
                                matrix[i, rightOffset] = count;
                                count += 1;
                            }

                            rightOffset += 1;
                            currentDirection = Direction.Right;
                            break;
                        }
                }
            }
        }
    }
}
