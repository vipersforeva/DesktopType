namespace DesktopType
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            RichTextBox1 = new RichTextBox();
            reloadText = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)reloadText).BeginInit();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.BackColor = Color.Black;
            RichTextBox1.BorderStyle = BorderStyle.None;
            RichTextBox1.CausesValidation = false;
            RichTextBox1.Font = new Font("Microsoft Sans Serif", 35F);
            RichTextBox1.Location = new Point(82, 274);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.ShortcutsEnabled = false;
            RichTextBox1.Size = new Size(1583, 387);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            RichTextBox1.KeyDown += MainTextBox_KeyDown;
            RichTextBox1.KeyPress += MainTextBox_KeyPress;
            // 
            // reloadText
            // 
            reloadText.Image = (Image)resources.GetObject("reloadText.Image");
            reloadText.Location = new Point(851, 689);
            reloadText.Name = "reloadText";
            reloadText.Size = new Size(75, 77);
            reloadText.TabIndex = 2;
            reloadText.TabStop = false;
            reloadText.Click += reloadText_Click;
            reloadText.MouseEnter += reloadText_MouseEnter_1;
            reloadText.MouseLeave += reloadText_MouseLeave;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainMenu;
            ClientSize = new Size(1904, 1041);
            Controls.Add(reloadText);
            Controls.Add(RichTextBox1);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "Desktop Type";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)reloadText).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RichTextBox1;
        private PictureBox reloadText;
    }
}