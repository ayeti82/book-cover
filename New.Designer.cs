
namespace BookCover
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            this.newTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.spineWidthLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spineWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newTableLayoutPanel
            // 
            resources.ApplyResources(this.newTableLayoutPanel, "newTableLayoutPanel");
            this.newTableLayoutPanel.Controls.Add(this.widthLabel, 0, 0);
            this.newTableLayoutPanel.Controls.Add(this.heightLabel, 0, 1);
            this.newTableLayoutPanel.Controls.Add(this.spineWidthLabel, 0, 2);
            this.newTableLayoutPanel.Controls.Add(this.cancelButton, 0, 3);
            this.newTableLayoutPanel.Controls.Add(this.OkButton, 1, 3);
            this.newTableLayoutPanel.Controls.Add(this.widthNumericUpDown, 1, 0);
            this.newTableLayoutPanel.Controls.Add(this.spineWidthNumericUpDown, 1, 2);
            this.newTableLayoutPanel.Controls.Add(this.heightNumericUpDown, 1, 1);
            this.newTableLayoutPanel.Name = "newTableLayoutPanel";
            // 
            // widthLabel
            // 
            resources.ApplyResources(this.widthLabel, "widthLabel");
            this.widthLabel.Name = "widthLabel";
            // 
            // heightLabel
            // 
            resources.ApplyResources(this.heightLabel, "heightLabel");
            this.heightLabel.Name = "heightLabel";
            // 
            // spineWidthLabel
            // 
            resources.ApplyResources(this.spineWidthLabel, "spineWidthLabel");
            this.spineWidthLabel.Name = "spineWidthLabel";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // widthNumericUpDown
            // 
            resources.ApplyResources(this.widthNumericUpDown, "widthNumericUpDown");
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // spineWidthNumericUpDown
            // 
            resources.ApplyResources(this.spineWidthNumericUpDown, "spineWidthNumericUpDown");
            this.spineWidthNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spineWidthNumericUpDown.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spineWidthNumericUpDown.Name = "spineWidthNumericUpDown";
            this.spineWidthNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // heightNumericUpDown
            // 
            resources.ApplyResources(this.heightNumericUpDown, "heightNumericUpDown");
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // New
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New";
            this.newTableLayoutPanel.ResumeLayout(false);
            this.newTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel newTableLayoutPanel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label spineWidthLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown spineWidthNumericUpDown;
    }
}