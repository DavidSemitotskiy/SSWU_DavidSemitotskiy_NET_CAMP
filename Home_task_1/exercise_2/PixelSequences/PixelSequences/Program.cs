namespace PixelSequences
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input number of rows: ");
            bool parsingRowsResult = int.TryParse(Console.ReadLine(), out int rows);
            Console.WriteLine("Input number of cols: ");
            bool parsingColsResult = int.TryParse(Console.ReadLine(), out int cols);
            if (!parsingRowsResult || !parsingColsResult || rows <= 1 || cols <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[,] colours = new int[rows, cols];
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
