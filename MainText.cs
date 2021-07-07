using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BookCover
{
    class MainText
    {
        public int fontSize { get; set; }
        public char Tag { get; set; }
        public string aText { get; set; }
        public Point beginPoint { get; set; }

        public RectangleF GetRect(MainText mt, Size s)
        {
            RectangleF tmp = new RectangleF();
            switch (mt.Tag)
            {
                case 'A':
                    tmp.X = mt.beginPoint.X;
                    tmp.Y = mt.beginPoint.Y;
                    tmp.Width = s.Width;
                    tmp.Height = s.Height / 6;
                    break;
                case 'T':
                    tmp.X = mt.beginPoint.X;
                    tmp.Y = mt.beginPoint.Y;
                    tmp.Width = s.Width;
                    tmp.Height = s.Height / 3;
                    break;

            }
            return tmp;
        }

        public string Trim(string s)
        {
            Regex trimmer = new Regex(@"\s\s+");
            return trimmer.Replace(s, " ");
        }
        public void MainText_Paint(PaintEventArgs e, MainText mt, BookCover bc, Color tc)
        {
            if (mt.fontSize > 0)
            {
                Font f1 = new Font("Arial", mt.fontSize);

                SolidBrush drawBrush = new SolidBrush(tc);

                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                RectangleF drawRect = GetRect(mt, new Size(bc.WidthBookCover, bc.HeightBookCover));

                while (bc.WidthBookCover < e.Graphics.MeasureString(mt.aText, f1).Width)
                {
                    f1 = new Font(f1.FontFamily, f1.Size - 0.1f);
                }

                e.Graphics.DrawString(mt.aText, f1, drawBrush, drawRect, format);

                mt.aText = Trim(mt.aText);
                Font f2 = f1;
                while ((bc.HeightBookCover / 2) < e.Graphics.MeasureString(mt.aText, f2).Width || bc.SpineWidthBookCover < e.Graphics.MeasureString(mt.aText, f2).Height)
                {
                    f2 = new Font(f2.FontFamily, f2.Size - 0.1f);
                }

                if (mt.Tag == 'A')
                {
                    e.Graphics.TranslateTransform(mt.beginPoint.X - bc.SpineWidthBookCover, mt.beginPoint.Y + (bc.HeightBookCover / 6));
                }
                else
                {
                    e.Graphics.TranslateTransform(mt.beginPoint.X - bc.SpineWidthBookCover, mt.beginPoint.Y + bc.HeightBookCover);
                }

                e.Graphics.RotateTransform(-90.0F);
                e.Graphics.DrawString(mt.aText, f2, drawBrush, new RectangleF(0, 0, bc.HeightBookCover / 2, bc.SpineWidthBookCover), format);
                e.Graphics.ResetTransform();

                f1.Dispose();
                f2.Dispose();
                drawBrush.Dispose();
                format.Dispose();
            }

        }

    }
}
