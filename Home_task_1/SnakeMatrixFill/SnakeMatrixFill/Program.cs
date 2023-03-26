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
            matrix.ClockWiseMatrixFill();
            matrix.PrintMatrixInConsole();
        }
    }
}