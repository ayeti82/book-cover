
namespace BookCover
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.addTextButton = new System.Windows.Forms.Button();
            this.additionalTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.colorTextButton = new System.Windows.Forms.Button();
            this.colorSettingLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel1_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.authorLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.titleTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.authorTextBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.addTextButton, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.additionalTextLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.colorSettingLabel, 0, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // authorTextBox
            // 
            resources.ApplyResources(this.authorTextBox, "authorTextBox");
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // addTextButton
            // 
            resources.ApplyResources(this.addTextButton, "addTextButton");
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // additionalTextLabel
            // 
            resources.ApplyResources(this.additionalTextLabel, "additionalTextLabel");
            this.additionalTextLabel.Name = "additionalTextLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.backgroundLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.backgroundButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorTextButton, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // backgroundLabel
            // 
            resources.ApplyResources(this.backgroundLabel, "backgroundLabel");
            this.backgroundLabel.Name = "backgroundLabel";
            // 
            // textLabel
            // 
            resources.ApplyResources(this.textLabel, "textLabel");
            this.textLabel.Name = "textLabel";
            // 
            // backgroundButton
            // 
            resources.ApplyResources(this.backgroundButton, "backgroundButton");
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.BackgroundTextButton_Click);
            // 
            // colorTextButton
            // 
            resources.ApplyResources(this.colorTextButton, "colorTextButton");
            this.colorTextButton.Name = "colorTextButton";
            this.colorTextButton.UseVisualStyleBackColor = true;
            this.colorTextButton.Click += new System.EventHandler(this.BackgroundTextButton_Click);
            // 
            // colorSettingLabel
            // 
            resources.ApplyResources(this.colorSettingLabel, "colorSettingLabel");
            this.colorSettingLabel.Name = "colorSettingLabel";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.settingStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripMenuItem,
            this.openStripMenuItem,
            this.saveStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            resources.ApplyResources(this.fileStripMenuItem, "fileStripMenuItem");
            // 
            // newStripMenuItem
            // 
            this.newStripMenuItem.Name = "newStripMenuItem";
            resources.ApplyResources(this.newStripMenuItem, "newStripMenuItem");
            this.newStripMenuItem.Click += new System.EventHandler(this.newStripMenuItem_Click);
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            resources.ApplyResources(this.openStripMenuItem, "openStripMenuItem");
            this.openStripMenuItem.Click += new System.EventHandler(this.openStripMenuItem_Click);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            resources.ApplyResources(this.saveStripMenuItem, "saveStripMenuItem");
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // settingStripMenuItem
            // 
            this.settingStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageStripMenuItem});
            this.settingStripMenuItem.Name = "settingStripMenuItem";
            resources.ApplyResources(this.settingStripMenuItem, "settingStripMenuItem");
            // 
            // languageStripMenuItem
            // 
            this.languageStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishStripMenuItem,
            this.polishStripMenuItem});
            this.languageStripMenuItem.Name = "languageStripMenuItem";
            resources.ApplyResources(this.languageStripMenuItem, "languageStripMenuItem");
            // 
            // englishStripMenuItem
            // 
            this.englishStripMenuItem.CheckOnClick = true;
            this.englishStripMenuItem.Name = "englishStripMenuItem";
            resources.ApplyResources(this.englishStripMenuItem, "englishStripMenuItem");
            this.englishStripMenuItem.Click += new System.EventHandler(this.englishStripMenuItem_Click);
            // 
            // polishStripMenuItem
            // 
            this.polishStripMenuItem.CheckOnClick = true;
            this.polishStripMenuItem.Name = "polishStripMenuItem";
            resources.ApplyResources(this.polishStripMenuItem, "polishStripMenuItem");
            this.polishStripMenuItem.Click += new System.EventHandler(this.polishStripMenuItem_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishStripMenuItem;
        private System.Windows.Forms.Label additionalTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button colorTextButton;
        private System.Windows.Forms.Label colorSettingLabel;
    }
}