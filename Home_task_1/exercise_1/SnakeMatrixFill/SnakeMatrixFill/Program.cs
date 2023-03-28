namespace SnakeMatrixFill
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input rows number: ");
            bool parsingRowsResult = int.TryParse(Console.ReadLine(), out int rows);
            Console.WriteLine("Input cols number: ");
            bool parsingColsResult = int.TryParse(Console.ReadLine(), out int cols);
            if (!parsingRowsResult || !parsingColsResult || rows <= 1 || cols <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[,] matrix = new int[rows, cols];
            matrix.ClockWiseMatrixFill();
            matrix.PrintMatrixInConsole();
        }
    }
}