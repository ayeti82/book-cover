
namespace BookCover
{
    partial class TextFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFormat));
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.posGroupBox = new System.Windows.Forms.GroupBox();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.centerRadioButton = new System.Windows.Forms.RadioButton();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fontNumericUpDown)).BeginInit();
            this.posGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontLabel
            // 
            resources.ApplyResources(this.fontLabel, "fontLabel");
            this.fontLabel.Name = "fontLabel";
            // 
            // fontNumericUpDown
            // 
            resources.ApplyResources(this.fontNumericUpDown, "fontNumericUpDown");
            this.fontNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.fontNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.fontNumericUpDown.Name = "fontNumericUpDown";
            this.fontNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // posGroupBox
            // 
            resources.ApplyResources(this.posGroupBox, "posGroupBox");
            this.posGroupBox.Controls.Add(this.rightRadioButton);
            this.posGroupBox.Controls.Add(this.centerRadioButton);
            this.posGroupBox.Controls.Add(this.leftRadioButton);
            this.posGroupBox.Name = "posGroupBox";
            this.posGroupBox.TabStop = false;
            // 
            // rightRadioButton
            // 
            resources.ApplyResources(this.rightRadioButton, "rightRadioButton");
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.UseVisualStyleBackColor = true;
            this.rightRadioButton.CheckedChanged += new System.EventHandler(this.rightRadioButton_CheckedChanged);
            // 
            // centerRadioButton
            // 
            resources.ApplyResources(this.centerRadioButton, "centerRadioButton");
            this.centerRadioButton.Name = "centerRadioButton";
            this.centerRadioButton.TabStop = true;
            this.centerRadioButton.UseVisualStyleBackColor = true;
            this.centerRadioButton.CheckedChanged += new System.EventHandler(this.centerRadioButton_CheckedChanged);
            // 
            // leftRadioButton
            // 
            resources.ApplyResources(this.leftRadioButton, "leftRadioButton");
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.UseVisualStyleBackColor = true;
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.leftRadioButton_CheckedChanged);
            // 
            // addTextBox
            // 
            resources.ApplyResources(this.addTextBox, "addTextBox");
            this.addTextBox.Name = "addTextBox";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Okbutton
            // 
            resources.ApplyResources(this.Okbutton, "Okbutton");
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // TextFormat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.posGroupBox);
            this.Controls.Add(this.fontNumericUpDown);
            this.Controls.Add(this.fontLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextFormat";
            this.Load += new System.EventHandler(this.TextFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontNumericUpDown)).EndInit();
            this.posGroupBox.ResumeLayout(false);
            this.posGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.NumericUpDown fontNumericUpDown;
        private System.Windows.Forms.GroupBox posGroupBox;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.RadioButton leftRadioButton;
        private System.Windows.Forms.RadioButton centerRadioButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button Okbutton;
    }
}