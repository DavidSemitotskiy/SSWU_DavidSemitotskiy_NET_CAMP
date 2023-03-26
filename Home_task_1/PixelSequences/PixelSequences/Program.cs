namespace PixelSequences
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of cols: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] colours = new int[rows, columns];
            colours.FillMatrixWithColours();
            colours.PrintMatrixOfColoursInConsole();
            Random random = new Random();
            var longestSequenceByRow = colours.FindLongestHorizontalSequenceByRow(random.Next(0, rows));
            var longestSequence = colours.FindLongestHorizontalSequence();
            Console.WriteLine($"Max sequence of colours by row {longestSequenceByRow.IndexRow}: {longestSequenceByRow}");
            Console.WriteLine($"Max sequence of colours in a whole matrix: {longestSequence}");
        }
    }
}
