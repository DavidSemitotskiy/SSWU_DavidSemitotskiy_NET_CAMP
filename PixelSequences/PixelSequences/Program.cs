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
            FillMatrixColours(colours);
            PrintMatrixColours(colours);
            ColourSequenceInfo[] colourSequences = new ColourSequenceInfo[rows];
            for (int i = 0; i < rows; i++)
            {
                colourSequences[i] = FindLongestHorizontalSequence(colours, i);
                Console.WriteLine(colourSequences[i]);
            }

            Console.WriteLine(colourSequences.MaxBy(horizontalColourSequence => horizontalColourSequence.Length));
        }

        public static void FillMatrixColours(int[,] colours)
        {
            Random random = new Random();
            for (int i = 0; i < colours.GetLength(0); i++)
            {
                for (int j = 0; j < colours.GetLength(1); j++)
                {
                    colours[i, j] = random.Next(0, 16);
                }
            }
        }

        public static void PrintMatrixColours(int[,] matrix)
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

        public static ColourSequenceInfo FindLongestHorizontalSequence(int[,] matrix, int row)
        {
            int startIndex = 0;
            int endIndex = 0;
            int length = 1;
            int colour = matrix[row, 0];

            int maxStartIndex = 0;
            int maxEndIndex = 0;
            int maxSequenceLength = 0;
            int maxColour = -1;
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i] == colour)
                {
                    length++;
                }

                endIndex = i;
                if (length > maxSequenceLength)
                {
                    maxSequenceLength = length;
                    maxStartIndex = startIndex;
                    maxEndIndex = endIndex;
                    maxColour = colour;
                }

                if (matrix[row, i] != colour)
                {
                    colour = matrix[row, i];
                    startIndex = i;
                    length = 1;
                }
            }

            return new ColourSequenceInfo
            {
                StartSequence = maxStartIndex,
                EndSequence = maxEndIndex,
                Length = maxSequenceLength,
                Colour = maxColour
            };
        }
    }
}
