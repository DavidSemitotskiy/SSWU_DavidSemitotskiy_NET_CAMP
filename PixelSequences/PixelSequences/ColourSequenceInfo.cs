namespace PixelSequences
{
    public class ColourSequenceInfo
    {
        public ColourSequenceInfo(int startSequence, int endSequence, int length, int colour)
        {
            StartSequence = startSequence;
            EndSequence = endSequence;
            Length = length;
            Colour = colour;
        }

        public int StartSequence { get; }

        public int EndSequence { get; }

        public int Length { get; }

        public int Colour { get; }

        public override string ToString()
        {
            return $"Start - {StartSequence}, End - {EndSequence}, Length - {Length}, Colour - {Colour}";
        }
    }
}
