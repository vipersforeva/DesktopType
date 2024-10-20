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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            RichTextBox1 = new RichTextBox();
            reloadText = new PictureBox();
            Timer15 = new PictureBox();
            Timer30 = new PictureBox();
            Timer60 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            TimeLabel = new Label();
            descriptionButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)reloadText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Timer15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Timer30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Timer60).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descriptionButton).BeginInit();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.BackColor = Color.Black;
            RichTextBox1.BorderStyle = BorderStyle.None;
            RichTextBox1.CausesValidation = false;
            RichTextBox1.Font = new Font("Microsoft Sans Serif", 35F);
            RichTextBox1.Location = new Point(82, 349);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.ShortcutsEnabled = false;
            RichTextBox1.Size = new Size(1583, 300);
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
            // Timer15
            // 
            Timer15.Image = Properties.Resources._15_gray;
            Timer15.Location = new Point(796, 271);
            Timer15.Name = "Timer15";
            Timer15.Size = new Size(50, 50);
            Timer15.TabIndex = 3;
            Timer15.TabStop = false;
            Timer15.Click += Timer15_Click;
            Timer15.MouseEnter += Timer15_MouseEnter;
            Timer15.MouseLeave += Timer15_MouseLeave;
            // 
            // Timer30
            // 
            Timer30.Image = Properties.Resources._30_gray;
            Timer30.Location = new Point(876, 271);
            Timer30.Name = "Timer30";
            Timer30.Size = new Size(50, 50);
            Timer30.TabIndex = 4;
            Timer30.TabStop = false;
            Timer30.Click += Timer30_Click;
            Timer30.MouseEnter += Timer30_MouseEnter;
            Timer30.MouseLeave += Timer30_MouseLeave;
            // 
            // Timer60
            // 
            Timer60.Image = Properties.Resources._60_gray;
            Timer60.Location = new Point(955, 271);
            Timer60.Name = "Timer60";
            Timer60.Size = new Size(50, 50);
            Timer60.TabIndex = 5;
            Timer60.TabStop = false;
            Timer60.Click += Timer60_Click;
            Timer60.MouseEnter += Timer60_MouseEnter;
            Timer60.MouseLeave += Timer60_MouseLeave;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = SystemColors.Desktop;
            TimeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TimeLabel.ForeColor = SystemColors.ButtonFace;
            TimeLabel.Location = new Point(82, 293);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(95, 37);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "Время";
            // 
            // descriptionButton
            // 
            descriptionButton.Image = Properties.Resources.descriptionButton;
            descriptionButton.Location = new Point(1814, 321);
            descriptionButton.Name = "descriptionButton";
            descriptionButton.Size = new Size(55, 55);
            descriptionButton.SizeMode = PictureBoxSizeMode.AutoSize;
            descriptionButton.TabIndex = 7;
            descriptionButton.TabStop = false;
            descriptionButton.Click += descriptionButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainMenu;
            ClientSize = new Size(1904, 1041);
            Controls.Add(descriptionButton);
            Controls.Add(TimeLabel);
            Controls.Add(Timer60);
            Controls.Add(Timer30);
            Controls.Add(Timer15);
            Controls.Add(reloadText);
            Controls.Add(RichTextBox1);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "Desktop Type";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)reloadText).EndInit();
            ((System.ComponentModel.ISupportInitialize)Timer15).EndInit();
            ((System.ComponentModel.ISupportInitialize)Timer30).EndInit();
            ((System.ComponentModel.ISupportInitialize)Timer60).EndInit();
            ((System.ComponentModel.ISupportInitialize)descriptionButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RichTextBox1;
        private PictureBox reloadText;
        private PictureBox Timer15;
        private PictureBox Timer30;
        private PictureBox Timer60;
        private System.Windows.Forms.Timer timer1;
        private Label TimeLabel;
        private PictureBox descriptionButton;
    }
}