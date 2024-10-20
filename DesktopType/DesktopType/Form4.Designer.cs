namespace DesktopType
{
    partial class DescMenu
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
            returnButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)returnButton).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Image = Properties.Resources._return;
            returnButton.Location = new Point(1767, 48);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(100, 100);
            returnButton.SizeMode = PictureBoxSizeMode.AutoSize;
            returnButton.TabIndex = 0;
            returnButton.TabStop = false;
            returnButton.Click += returnButton_Click;
            // 
            // DescMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.description;
            ClientSize = new Size(1904, 1041);
            Controls.Add(returnButton);
            DoubleBuffered = true;
            Name = "DescMenu";
            Text = "Form4";
            WindowState = FormWindowState.Maximized;
            FormClosed += DescMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)returnButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox returnButton;
    }
}