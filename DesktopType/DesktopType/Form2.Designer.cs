namespace DesktopType
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
            IsEqualPassword = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            LoginBox.Size = new Size(544, 28);
            LoginBox.TabIndex = 1;
            LoginBox.Text = "Логин";
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
            PasswordBox.Size = new Size(544, 28);
            PasswordBox.TabIndex = 2;
            PasswordBox.Text = "Пароль";
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
            RepeatPasswordBox.Size = new Size(544, 28);
            RepeatPasswordBox.TabIndex = 3;
            RepeatPasswordBox.Text = "Подтвердите пароль";
            RepeatPasswordBox.KeyPress += RepeatPasswordBox_KeyPress;
            // 
            // IsEqualPassword
            // 
            IsEqualPassword.AutoSize = true;
            IsEqualPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IsEqualPassword.ForeColor = Color.IndianRed;
            IsEqualPassword.Image = Properties.Resources.Reg;
            IsEqualPassword.Location = new Point(687, 643);
            IsEqualPassword.Name = "IsEqualPassword";
            IsEqualPassword.Size = new Size(182, 21);
            IsEqualPassword.TabIndex = 4;
            IsEqualPassword.Text = "Пароли не совпадают!";
            IsEqualPassword.Visible = false;
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
            // RegMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Reg;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(IsEqualPassword);
            Controls.Add(RepeatPasswordBox);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            DoubleBuffered = true;
            Name = "RegMenu";
            Text = "RegMenu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private TextBox RepeatPasswordBox;
        private Label IsEqualPassword;
        private PictureBox pictureBox1;
    }
}