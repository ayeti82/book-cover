using System.Drawing;

namespace BookCover
{
    public class BookCover
    {
        public int WidthBookCover { get; set; }
        public int HeightBookCover { get; set; }
        public int SpineWidthBookCover { get; set; }
        public bool isDeafult = true;
        public Point titlePos;
        public void DefaultSettings()
        {
            WidthBookCover = 300;
            HeightBookCover = 500;
            SpineWidthBookCover = 30;
            isDeafult = false;
            Scale();
        }

        public void Scale()
        {
            WidthBookCover = (int)(WidthBookCover * 1.5);
            HeightBookCover = (int)(HeightBookCover * 1.5);
            SpineWidthBookCover = (int)(SpineWidthBookCover * 1.5);
        }

        public Bitmap CreateBookCover(int w, int h, Color bookCover)
        {
            titlePos = new Point((w / 2) + (SpineWidthBookCover / 2), ((h - HeightBookCover) / 2));
            Bitmap drawRect = new Bitmap(w, h);

            SolidBrush sb = new SolidBrush(bookCover);
            Pen grayPen = new Pen(Color.DarkGray, 3);

            using (Graphics g = Graphics.FromImage(drawRect))
            {
                g.FillRectangle(sb, new Rectangle((w / 2) - (SpineWidthBookCover / 2) - WidthBookCover, (h - HeightBookCover) / 2, (2 * WidthBookCover) + SpineWidthBookCover, HeightBookCover));
                g.DrawRectangle(grayPen, new Rectangle((w / 2) - (SpineWidthBookCover / 2) - WidthBookCover, (h - HeightBookCover) / 2, WidthBookCover + SpineWidthBookCover, HeightBookCover));
                g.DrawRectangle(grayPen, new Rectangle((w / 2) - (SpineWidthBookCover / 2), (h - HeightBookCover) / 2, WidthBookCover + SpineWidthBookCover, HeightBookCover));

            }

            sb.Dispose();
            grayPen.Dispose();

            return drawRect;
        }
    }
}
