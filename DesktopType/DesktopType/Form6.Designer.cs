namespace DesktopType
{
    partial class resultMenu
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
            speed = new Label();
            acc = new Label();
            times = new Label();
            ((System.ComponentModel.ISupportInitialize)returnButton).BeginInit();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Image = Properties.Resources._return;
            returnButton.Location = new Point(1766, 42);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(100, 100);
            returnButton.SizeMode = PictureBoxSizeMode.AutoSize;
            returnButton.TabIndex = 14;
            returnButton.TabStop = false;
            returnButton.Click += returnButton_Click;
            // 
            // speed
            // 
            speed.AutoSize = true;
            speed.BackColor = SystemColors.ActiveCaptionText;
            speed.Font = new Font("Segoe UI Semibold", 45F, FontStyle.Bold);
            speed.ForeColor = SystemColors.ButtonHighlight;
            speed.Location = new Point(380, 697);
            speed.Name = "speed";
            speed.Size = new Size(134, 81);
            speed.TabIndex = 16;
            speed.Text = "300";
            // 
            // acc
            // 
            acc.AutoSize = true;
            acc.BackColor = SystemColors.ActiveCaptionText;
            acc.Font = new Font("Segoe UI Semibold", 45F, FontStyle.Bold);
            acc.ForeColor = SystemColors.ButtonHighlight;
            acc.Location = new Point(909, 697);
            acc.Name = "acc";
            acc.Size = new Size(151, 81);
            acc.TabIndex = 17;
            acc.Text = "95%";
            // 
            // times
            // 
            times.AutoSize = true;
            times.BackColor = SystemColors.ActiveCaptionText;
            times.Font = new Font("Segoe UI Semibold", 45F, FontStyle.Bold);
            times.ForeColor = SystemColors.ButtonHighlight;
            times.Location = new Point(1430, 697);
            times.Name = "times";
            times.Size = new Size(199, 81);
            times.TabIndex = 18;
            times.Text = "15 сек";
            // 
            // resultMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.record;
            ClientSize = new Size(1904, 1041);
            Controls.Add(times);
            Controls.Add(acc);
            Controls.Add(speed);
            Controls.Add(returnButton);
            DoubleBuffered = true;
            Name = "resultMenu";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form6_FormClosed;
            ((System.ComponentModel.ISupportInitialize)returnButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox returnButton;
        private Label speed;
        private Label acc;
        private Label times;
    }
}