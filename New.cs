using System;
using System.Windows.Forms;

namespace BookCover
{
    public partial class New : Form
    {
        public static bool clickedOK = false;
        public static BookCover bc = new BookCover();
        public New()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clickedOK = false;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            clickedOK = true;
            bc.WidthBookCover = (int)widthNumericUpDown.Value;
            bc.HeightBookCover = (int)heightNumericUpDown.Value;
            bc.SpineWidthBookCover = (int)spineWidthNumericUpDown.Value;
            Close();
        }
    }
}
