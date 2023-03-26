namespace PixelSequences
{
    public class ColourSequenceInfo
    {
        public int StartSequence { get; set; }

        public int EndSequence { get; set; }

        public int Length { get; set; }

        public int Colour { get; set; }

        public override string ToString()
        {
            return $"Start - {StartSequence}, End - {EndSequence}, Length - {Length}, Colour - {Colour}";
        }
    }
}
