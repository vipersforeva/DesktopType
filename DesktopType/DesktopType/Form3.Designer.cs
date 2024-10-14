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
            MainTextBox = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.BackColor = Color.Black;
            MainTextBox.BorderStyle = BorderStyle.None;
            MainTextBox.CausesValidation = false;
            MainTextBox.Font = new Font("Microsoft Sans Serif", 35F);
            MainTextBox.Location = new Point(82, 274);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.ShortcutsEnabled = false;
            MainTextBox.Size = new Size(1583, 387);
            MainTextBox.TabIndex = 0;
            MainTextBox.Text = "";
            MainTextBox.KeyDown += MainTextBox_KeyDown;
            MainTextBox.KeyPress += MainTextBox_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(1341, 680);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainMenu;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(MainTextBox);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "Desktop Type";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainMenu_FormClosed;
            KeyDown += MainMenu_KeyDown;
            KeyPress += MainMenu_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox MainTextBox;
        private Button button1;
    }
}