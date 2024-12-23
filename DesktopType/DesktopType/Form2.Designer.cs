﻿namespace DesktopType
{
    partial class RegMenu
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
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            RepeatPasswordBox = new TextBox();
            Warn = new Label();
            pictureBox1 = new PictureBox();
            LogLabel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogLabel).BeginInit();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.BackColor = Color.FromArgb(64, 64, 64);
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBox.ForeColor = Color.Silver;
            LoginBox.Location = new Point(687, 471);
            LoginBox.MaxLength = 20;
            LoginBox.Name = "LoginBox";
            LoginBox.PlaceholderText = "Логин";
            LoginBox.Size = new Size(544, 28);
            LoginBox.TabIndex = 1;
            LoginBox.KeyPress += LoginBox_KeyPress;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(64, 64, 64);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.Silver;
            PasswordBox.Location = new Point(687, 534);
            PasswordBox.MaxLength = 20;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Пароль";
            PasswordBox.Size = new Size(544, 28);
            PasswordBox.TabIndex = 2;
            PasswordBox.KeyPress += PasswordBox_KeyPress;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.BackColor = Color.FromArgb(64, 64, 64);
            RepeatPasswordBox.BorderStyle = BorderStyle.None;
            RepeatPasswordBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RepeatPasswordBox.ForeColor = Color.Silver;
            RepeatPasswordBox.Location = new Point(687, 596);
            RepeatPasswordBox.MaxLength = 20;
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PlaceholderText = "Подтвердите пароль";
            RepeatPasswordBox.Size = new Size(544, 28);
            RepeatPasswordBox.TabIndex = 3;
            RepeatPasswordBox.KeyPress += RepeatPasswordBox_KeyPress;
            // 
            // Warn
            // 
            Warn.AutoSize = true;
            Warn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Warn.ForeColor = Color.IndianRed;
            Warn.Image = Properties.Resources.Reg;
            Warn.Location = new Point(687, 643);
            Warn.Name = "Warn";
            Warn.Size = new Size(182, 21);
            Warn.TabIndex = 4;
            Warn.Text = "Пароли не совпадают!";
            Warn.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Registrarion;
            pictureBox1.Location = new Point(729, 736);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 57);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogLabel
            // 
            LogLabel.Image = Properties.Resources.LogLabel;
            LogLabel.Location = new Point(1053, 902);
            LogLabel.Name = "LogLabel";
            LogLabel.Size = new Size(217, 29);
            LogLabel.TabIndex = 9;
            LogLabel.TabStop = false;
            LogLabel.Click += LogLabel_Click;
            LogLabel.MouseEnter += LogLabel_MouseEnter;
            LogLabel.MouseLeave += LogLabel_MouseLeave;
            // 
            // RegMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Reg;
            ClientSize = new Size(1904, 1041);
            Controls.Add(LogLabel);
            Controls.Add(pictureBox1);
            Controls.Add(Warn);
            Controls.Add(RepeatPasswordBox);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            DoubleBuffered = true;
            Name = "RegMenu";
            Text = "Desktop Type";
            WindowState = FormWindowState.Maximized;
            FormClosed += RegMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogLabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private TextBox RepeatPasswordBox;
        private Label Warn;
        private PictureBox pictureBox1;
        private PictureBox LogLabel;
    }
}