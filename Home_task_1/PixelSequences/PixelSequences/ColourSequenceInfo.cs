namespace PixelSequences
{
    public class ColourSequenceInfo
    {
        public ColourSequenceInfo(int row, int startSequence, int endSequence, int length, int colour)
        {
            IndexRow = row;
            StartSequence = startSequence;
            EndSequence = endSequence;
            Length = length;
            Colour = colour;
        }

        public int StartSequence { get; }

        public int EndSequence { get; }

        public int IndexRow { get; set; }

        public int Length { get; }

        public int Colour { get; }

        public override string ToString()
        {
            return $"Start - {IndexRow}{StartSequence}, End - {IndexRow}{EndSequence}, Length - {Length}, Colour - {Colour}";
        }
    }
}
