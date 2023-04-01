namespace PixelSequences
{
    public static class ColourMatrixExtensions
    {
        public static void FillMatrixWithColours(this int[,] colours)
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

        public static void PrintMatrixOfColoursInConsole(this int[,] colours)
        {
            for (int i = 0; i < colours.GetLength(0); i++)
            {
                for (int j = 0; j < colours.GetLength(1); j++)
                {
                    Console.Write($"{colours[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        public static ColourSequenceInfo FindLongestHorizontalSequence(this int[,] colours)
        {
            int rows = colours.GetLength(0);
            var longestColourSequencesByRows = new ColourSequenceInfo[rows];
            for (int i = 0; i < rows; i++)
            {
                longestColourSequencesByRows[i] = colours.FindLongestHorizontalSequenceByRow(i);
            }

            return longestColourSequencesByRows.MaxBy(sequence => sequence.Length);
        }

        public static ColourSequenceInfo FindLongestHorizontalSequenceByRow(this int[,] colours, int indexRow)
        {
            int startIndex = 0;
            int endIndex = 0;
            int length = 1;
            int colour = colours[indexRow, 0];

            int maxStartIndex = startIndex;
            int maxEndIndex = endIndex;
            int maxSequenceLength = length;
            int maxColour = colour;
            for (int i = 1; i < colours.GetLength(1); i++)
            {
                if (colours[indexRow, i] != colour)
                {
                    startIndex = i;
                    length = 1;
                    colour = colours[indexRow, i];
                }
                else
                {
                    length += 1;
                }

                endIndex = i;
                if (length > maxSequenceLength)
                {
                    maxStartIndex = startIndex;
                    maxEndIndex = endIndex;
                    maxColour = colour;
                    maxSequenceLength = length;
                }
            }
            // Не врховано, що найдовша лінія може бути в кінці стрічки.

            return new ColourSequenceInfo(indexRow, maxStartIndex, maxEndIndex, maxSequenceLength, maxColour);
        }
    }
}
