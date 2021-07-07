using System.Drawing;

namespace BookCover
{
    public enum TextAlignment
    {
        Left,
        Right,
        Center
    }

    public class AdditionalText
    {
        public int FontSize { get; set; }
        public string aText { get; set; }
        public Point BeginPoint { get; set; }
        public TextAlignment Align { get; set; }
        public Point relativePos { get; set; }

    }


}
