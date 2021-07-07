using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;


namespace BookCover
{
    public partial class MainWindow : Form, IMessageFilter
    {
        //checks
        public static bool newWindow = true, isTextSelected = false;

        //book cover
        BookCover bc = new BookCover();

        //default colors
        Color bookCover = Color.LavenderBlush, textColor = Color.Black;

        //texts for author and title
        MainText titleMainText = new MainText(), authorMainText = new MainText();

        //selected text and rectangle
        RectangleF selectedTextRect = new RectangleF();
        AdditionalText selectedText = new AdditionalText();
        Point relativeRect = new Point();

        //additional texts
        public BindingList<AdditionalText> texts { get; set; } = new BindingList<AdditionalText>();

        public MainWindow()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }


        #region MenuStripFunctionality

        //File -> New
        private void newStripMenuItem_Click(object sender, EventArgs e)
        {
            New newBox = new New();
            newBox.ShowDialog();

            if (New.clickedOK)
            {
                bookCover = Color.LavenderBlush;
                textColor = Color.Black;

                bc.WidthBookCover = New.bc.WidthBookCover;
                bc.HeightBookCover = New.bc.HeightBookCover;
                bc.SpineWidthBookCover = New.bc.SpineWidthBookCover;
                bc.Scale();

                pictureBox.Image = bc.CreateBookCover(pictureBox.Width, pictureBox.Height, bookCover);

                texts.Clear();
                newWindow = true;
                titleTextBox.Clear();
                authorTextBox.Clear();
                titleMainText.aText = "";
                authorMainText.aText = "";
                titleTextBox.Focus();
                pictureBox.Refresh();
                New.clickedOK = false;
            }
        }


        //File -> Open
        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            texts.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "XML Files (*.xml) | *.xml| All files (*.*) | *.*",
                Title = "Open"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(openFileDialog.FileName);

                    bc.WidthBookCover = Convert.ToInt32(doc.SelectSingleNode("/BookCover/@Width").Value);
                    bc.HeightBookCover = Convert.ToInt32(doc.SelectSingleNode("/BookCover/@Height").Value);
                    bc.SpineWidthBookCover = Convert.ToInt32(doc.SelectSingleNode("/BookCover/@SpineWidth").Value);
                    titleMainText.aText = doc.SelectSingleNode("/BookCover/@Title").Value;
                    titleTextBox.Text = titleMainText.aText;
                    authorMainText.aText = doc.SelectSingleNode("/BookCover/@Author").Value;
                    authorTextBox.Text = authorMainText.aText;

                    int R = Convert.ToInt32(doc.SelectSingleNode("/BookCover/Background/@r").Value);
                    int G = Convert.ToInt32(doc.SelectSingleNode("/BookCover/Background/@g").Value);
                    int B = Convert.ToInt32(doc.SelectSingleNode("/BookCover/Background/@b").Value);
                    bookCover = Color.FromArgb(R, G, B);

                    R = Convert.ToInt32(doc.SelectSingleNode("/BookCover/TextColor/@r").Value);
                    G = Convert.ToInt32(doc.SelectSingleNode("/BookCover/TextColor/@g").Value);
                    B = Convert.ToInt32(doc.SelectSingleNode("/BookCover/TextColor/@b").Value);
                    textColor = Color.FromArgb(R, G, B);

                    XmlNodeList textlist = doc.SelectNodes("/BookCover/Text");
                    foreach (XmlNode t in textlist)
                    {
                        AdditionalText tmptext = new AdditionalText(); int x, y;
                        tmptext.aText = t.Attributes.GetNamedItem("Text").Value;
                        tmptext.FontSize = Convert.ToInt32(t.Attributes.GetNamedItem("Size").Value);
                        x = Convert.ToInt32(t.Attributes.GetNamedItem("x").Value);
                        y = Convert.ToInt32(t.Attributes.GetNamedItem("y").Value);
                        tmptext.BeginPoint = new Point(x, y);
                        tmptext.relativePos = new Point((pictureBox.Width / 2) - tmptext.BeginPoint.X, (pictureBox.Height / 2) - tmptext.BeginPoint.Y);
                        if (t.Attributes.GetNamedItem("Alignment").Value == "Left")
                            tmptext.Align = TextAlignment.Left;
                        else if (t.Attributes.GetNamedItem("Alignment").Value == "Right")
                            tmptext.Align = TextAlignment.Right;
                        else if (t.Attributes.GetNamedItem("Alignment").Value == "Center")
                            tmptext.Align = TextAlignment.Center;
                        texts.Add(tmptext);
                    }

                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error during file opening", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        //Creates XML File
        private XmlDocument CreateXmlFile()
        {
            XmlDocument tmp = new XmlDocument();
            XmlElement root = tmp.CreateElement("BookCover");
            root.SetAttribute("Width", Convert.ToString(bc.WidthBookCover));
            root.SetAttribute("Height", Convert.ToString(bc.HeightBookCover));
            root.SetAttribute("SpineWidth", Convert.ToString(bc.SpineWidthBookCover));
            root.SetAttribute("Title", titleMainText.aText);
            root.SetAttribute("Author", authorMainText.aText);
            XmlElement background = tmp.CreateElement("Background");
            background.SetAttribute("r", Convert.ToString(bookCover.R));
            background.SetAttribute("g", Convert.ToString(bookCover.G));
            background.SetAttribute("b", Convert.ToString(bookCover.B));
            XmlElement textforecolor = tmp.CreateElement("TextColor");
            textforecolor.SetAttribute("r", Convert.ToString(textColor.R));
            textforecolor.SetAttribute("g", Convert.ToString(textColor.G));
            textforecolor.SetAttribute("b", Convert.ToString(textColor.B));

            root.AppendChild(background);
            root.AppendChild(textforecolor);

            foreach (var t in texts)
            {
                XmlElement tmptext = tmp.CreateElement("Text");
                tmptext.SetAttribute("Text", t.aText);
                tmptext.SetAttribute("Size", Convert.ToString(t.FontSize));
                tmptext.SetAttribute("x", Convert.ToString(t.BeginPoint.X));
                tmptext.SetAttribute("y", Convert.ToString(t.BeginPoint.Y));
                tmptext.SetAttribute("Alignment", Convert.ToString(t.Align));
                root.AppendChild(tmptext);
            }

            tmp.AppendChild(root);
            return tmp;
        }

        //File -> Save
        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {

            XmlDocument tmp = CreateXmlFile();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml) | *.xml| All files (*.*) | *.*";
            saveFileDialog.Title = "Save as";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    tmp.Save(saveFileDialog.FileName);
                }

            }
        }

        //Functionality for changing languages
        private void ChangeLanguage(bool isEnglish)
        {
            if(isEnglish)
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en-EN");
                CultureInfo.CurrentCulture = new CultureInfo("en-EN");
            }
            else
            {
                CultureInfo.CurrentUICulture = new CultureInfo("pl-PL");
                CultureInfo.CurrentCulture = new CultureInfo("pl-PL");
            }

            Controls.Clear();
            Size beforeSize = new Size(Size.Width, Size.Height);
            string beforeTitle = titleTextBox.Text;
            string beforeAuthor = authorTextBox.Text;
            InitializeComponent();
            Size = new Size(beforeSize.Width, beforeSize.Height);
            titleTextBox.Text = beforeTitle;
            titleMainText.aText = beforeTitle;
            authorTextBox.Text = beforeAuthor;
            authorMainText.aText = beforeAuthor;

            if(isEnglish)
            {
                polishStripMenuItem.Checked = false;
                englishStripMenuItem.Checked = true;
            }
            else
            {
                polishStripMenuItem.Checked = true;
                englishStripMenuItem.Checked = false;
            }

        }

        //Settings -> English
        private void englishStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(true);
        }


        //Settings -> Polish
        private void polishStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(false);
        }

        #endregion

        #region Panel2Functionality

        //Title Functionality
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleMainText.aText = titleTextBox.Text;
            titleMainText.Tag = 'T';
            titleMainText.fontSize = 32;
            titleMainText.beginPoint = new Point(bc.titlePos.X, bc.titlePos.Y);
            pictureBox.Refresh();

        }

        //Author Functionality
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            authorMainText.aText = authorTextBox.Text;
            authorMainText.Tag = 'A';
            authorMainText.fontSize = 24;
            authorMainText.beginPoint = new Point(bc.titlePos.X, bc.titlePos.Y + bc.HeightBookCover / 3);
            pictureBox.Refresh();
        }



        //Adds additional text
        private void addTextButton_Click(object sender, EventArgs e)
        {
            TextFormat tf = new TextFormat();
            tf.ShowDialog();
            if (TextFormat.clickedOk)
            {
                texts.Add(new AdditionalText { aText = TextFormat.ad.aText, Align = TextFormat.ad.Align, FontSize = TextFormat.ad.FontSize });
            }
        }

        //Background and Text Functionality
        private void BackgroundTextButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (sender == backgroundButton)
                {
                    bookCover = colorDialog.Color;
                    pictureBox.Image = bc.CreateBookCover(pictureBox.Width, pictureBox.Height, bookCover);

                }
                else if (sender == colorTextButton)
                {
                    textColor = colorDialog.Color;
                }
                pictureBox.Refresh();
            }
        }

        #endregion

        #region PictureBox

        //adds text at corresponding points
        //Selects text by right clicking
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextFormat.clickedOk)
            {
                texts[texts.Count - 1].BeginPoint = new Point(e.X, e.Y);
                texts[texts.Count - 1].relativePos = new Point((pictureBox.Width / 2) - e.X, (pictureBox.Height / 2) - e.Y);
                Cursor = Cursors.Arrow;
                pictureBox.Refresh();
                TextFormat.clickedOk = false;
            }

            if (e.Button == MouseButtons.Right)
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                foreach (var t in texts)
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        SizeF tmp = g.MeasureString(t.aText, new Font("Arial", t.FontSize));
                        Rectangle tmpRect = new Rectangle(t.BeginPoint.X - ((int)tmp.Width / 2), t.BeginPoint.Y - ((int)tmp.Height / 2), (int)tmp.Width, (int)tmp.Height);
                        if (tmpRect.Contains(e.Location))
                        {
                            selectedTextRect = tmpRect;
                            relativeRect.X = (int)((pictureBox.Width / 2) - selectedTextRect.X);
                            relativeRect.Y = (int)((pictureBox.Height / 2) - selectedTextRect.Y);
                            selectedText = t;
                            isTextSelected = true;
                            break;
                        }
                        else
                        {
                            selectedText = null;
                        }

                    }
                }

                format.Dispose();
                pictureBox.Refresh();


            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < texts.Count; i++)
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        SizeF tmp = g.MeasureString(texts[i].aText, new Font("Arial", texts[i].FontSize));
                        Rectangle tmpRect = new Rectangle(texts[i].BeginPoint.X - ((int)tmp.Width / 2), texts[i].BeginPoint.Y - ((int)tmp.Height / 2), (int)tmp.Width, (int)tmp.Height);
                        if (tmpRect.Contains(e.Location))
                        {
                            TextFormat tmptf = new TextFormat();
                            tmptf.ShowTextBox(texts[i]);
                            texts[i].aText = TextFormat.ad.aText;
                            texts[i].Align = TextFormat.ad.Align;
                            texts[i].FontSize = TextFormat.ad.FontSize;
                            break;
                        }
                    }
                }
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            if (TextFormat.clickedOk)
            {
                Cursor = Cursors.Cross;
                tableLayoutPanel.Cursor = Cursors.Arrow;
                menuStrip.Cursor = Cursors.Arrow;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (selectedText != null)
                {
                    isTextSelected = true;
                    selectedText.BeginPoint = new Point(e.X, e.Y);
                    selectedText.relativePos = new Point((pictureBox.Width / 2) - e.X, (pictureBox.Height / 2) - e.Y);
                    selectedTextRect.X = selectedText.BeginPoint.X - (selectedTextRect.Width / 2);
                    selectedTextRect.Y = selectedText.BeginPoint.Y - (selectedTextRect.Height / 2);
                    relativeRect.X = (int)((pictureBox.Width / 2) - selectedTextRect.X);
                    relativeRect.Y = (int)((pictureBox.Height / 2) - selectedTextRect.Y);
                    pictureBox.Refresh();
                }
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (!newWindow)
            {
                titleMainText.MainText_Paint(e, titleMainText, bc, textColor);
                authorMainText.MainText_Paint(e, authorMainText, bc, textColor);

                foreach (var t in texts)
                {
                    SolidBrush drawBrush = new SolidBrush(textColor);
                    Font drawFont = new Font("Arial", t.FontSize);
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString(t.aText, drawFont, drawBrush, t.BeginPoint.X, t.BeginPoint.Y, format);

                    drawBrush.Dispose();
                    drawFont.Dispose();
                    format.Dispose();

                }
                if (isTextSelected)
                {
                    isTextSelected = false;
                    Pen tmpPen = new Pen(textColor);
                    e.Graphics.DrawRectangle(tmpPen, selectedTextRect.X, selectedTextRect.Y, selectedTextRect.Width, selectedTextRect.Height);

                    tmpPen.Dispose();
                }

            }
            else newWindow = false;

        }

        #endregion


        //Main Window Load
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Size = new Size((int)(1.0499 * Width), (int)(0.825 * Height));
            Location = new Point((Screen.FromControl(this).Bounds.Width / 2) - (Size.Width / 2), (Screen.FromControl(this).Bounds.Height - Size.Height) / 2);
            englishStripMenuItem.Checked = true;
        }

        //Main Window Resize
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            pictureBox.Width = splitContainer.Panel1.Width;
            pictureBox.Height = splitContainer.Panel1.Height;
        }

        //Split Container Paint
        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (bc.isDeafult)
            {
                bc.DefaultSettings();
                pictureBox.Image = bc.CreateBookCover(pictureBox.Width, pictureBox.Height, bookCover);
            }
            else
            {
                pictureBox.Image = bc.CreateBookCover(pictureBox.Width, pictureBox.Height, bookCover);
            }
            titleMainText.beginPoint = new Point(bc.titlePos.X, bc.titlePos.Y);
            authorMainText.beginPoint = new Point(bc.titlePos.X, bc.titlePos.Y + bc.HeightBookCover / 3);

            foreach (var t in texts)
            {
                t.BeginPoint = new Point(pictureBox.Width / 2 - (t.relativePos.X), pictureBox.Height / 2 - (t.relativePos.Y));
            }

            if (selectedText != null)
                isTextSelected = true;

            selectedTextRect.X = pictureBox.Width / 2 - relativeRect.X;
            selectedTextRect.Y = pictureBox.Height / 2 - relativeRect.Y;

            pictureBox.Refresh();
        }

        //Deleting texts in picture box by del key
        //Picture Box doesn't have focus so tracking every keyboard input to check whether it's del key or not
        public bool PreFilterMessage(ref Message m)
        {
            // WM_KEYDOWN
            if (m.Msg == 0x0100)
            {
                // Extract the keys being pressed
                Keys keys = ((Keys)((int)m.WParam.ToInt64()));

                if (keys == Keys.Delete)
                {
                    if (selectedText != null)
                    {
                        texts.Remove(selectedText);
                        selectedText = null;
                        pictureBox.Refresh();
                    }
                    return true; // Prevent message reaching destination
                }
            }
            return false;
        }
    }
}
