using System;
using System.Windows.Forms;

namespace BookCover
{
    public partial class TextFormat : Form
    {
        public static bool clickedOk;
        public static AdditionalText ad = new AdditionalText();
        private bool isDefault = true;
        private bool fromShowTextBox = false;
        public TextFormat()
        {
            InitializeComponent();
        }
        public void ShowTextBox(AdditionalText t)
        {
            isDefault = false;
            fromShowTextBox = true;

            addTextBox.Text = t.aText;

            if (t.FontSize > 0) fontNumericUpDown.Value = t.FontSize;
            else fontNumericUpDown.Value = 16;

            switch (t.Align)
            {
                case TextAlignment.Right:
                    rightRadioButton.Checked = true;
                    addTextBox.TextAlign = HorizontalAlignment.Right;
                    break;
                case TextAlignment.Left:
                    leftRadioButton.Checked = true;
                    addTextBox.TextAlign = HorizontalAlignment.Left;
                    break;
                case TextAlignment.Center:
                    centerRadioButton.Checked = true;
                    addTextBox.TextAlign = HorizontalAlignment.Center;
                    break;
            }

            ShowDialog();
        }
        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (!fromShowTextBox) clickedOk = true;
            else clickedOk = false;

            ad.FontSize = (int)fontNumericUpDown.Value;

            ad.aText = addTextBox.Text;

            if (leftRadioButton.Checked)
            {
                ad.Align = TextAlignment.Left;
            }
            else if (rightRadioButton.Checked)
            {
                ad.Align = TextAlignment.Right;
            }
            else if (centerRadioButton.Checked)
            {
                ad.Align = TextAlignment.Center;
            }

            addTextBox.Clear();
            addTextBox.Focus();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextFormat_Load(object sender, EventArgs e)
        {
            if (isDefault)
            {
                leftRadioButton.Checked = true;
                isDefault = false;
            }
        }

        private void leftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (leftRadioButton.Checked)
            {
                addTextBox.TextAlign = HorizontalAlignment.Left;
                addTextBox.Refresh();
            }
        }

        private void centerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (centerRadioButton.Checked)
            {
                addTextBox.TextAlign = HorizontalAlignment.Center;
                addTextBox.Refresh();
            }
        }

        private void rightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rightRadioButton.Checked)
            {
                addTextBox.TextAlign = HorizontalAlignment.Right;
                addTextBox.Refresh();
            }
        }

    }
}
