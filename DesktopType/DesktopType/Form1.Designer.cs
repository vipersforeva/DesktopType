namespace DesktopType
{
    partial class LogMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogMenu));
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            IsExistPass = new Label();
            CloseEye = new PictureBox();
            OpenEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenEye).BeginInit();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.AccessibleDescription = "";
            LoginBox.BackColor = Color.FromArgb(64, 64, 64);
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.Font = new Font("Microsoft Sans Serif", 18F);
            LoginBox.ForeColor = Color.Silver;
            LoginBox.Location = new Point(687, 470);
            LoginBox.MaxLength = 20;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(544, 28);
            LoginBox.TabIndex = 0;
            LoginBox.KeyPress += LoginBox_KeyPress;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(64, 64, 64);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.Silver;
            PasswordBox.Location = new Point(687, 563);
            PasswordBox.MaxLength = 20;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '●';
            PasswordBox.Size = new Size(544, 28);
            PasswordBox.TabIndex = 1;
            PasswordBox.KeyPress += PasswordBox_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(1051, 849);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Autorization;
            pictureBox1.Location = new Point(755, 688);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 57);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += LogMenu_Click;
            // 
            // IsExistPass
            // 
            IsExistPass.AutoSize = true;
            IsExistPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IsExistPass.ForeColor = Color.IndianRed;
            IsExistPass.Image = Properties.Resources.Reg;
            IsExistPass.Location = new Point(687, 610);
            IsExistPass.Name = "IsExistPass";
            IsExistPass.Size = new Size(193, 21);
            IsExistPass.TabIndex = 5;
            IsExistPass.Text = "Не все поля заполнены!";
            IsExistPass.Visible = false;
            // 
            // CloseEye
            // 
            CloseEye.Image = (Image)resources.GetObject("CloseEye.Image");
            CloseEye.Location = new Point(1154, 537);
            CloseEye.Name = "CloseEye";
            CloseEye.Size = new Size(88, 80);
            CloseEye.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseEye.TabIndex = 6;
            CloseEye.TabStop = false;
            CloseEye.Click += PassEye_Click;
            // 
            // OpenEye
            // 
            OpenEye.Image = Properties.Resources.PassEyeOpen;
            OpenEye.Location = new Point(1154, 537);
            OpenEye.Name = "OpenEye";
            OpenEye.Size = new Size(88, 80);
            OpenEye.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenEye.TabIndex = 7;
            OpenEye.TabStop = false;
            OpenEye.Visible = false;
            OpenEye.Click += PassEye_Click;
            // 
            // LogMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_9__1_;
            ClientSize = new Size(1904, 1041);
            Controls.Add(OpenEye);
            Controls.Add(CloseEye);
            Controls.Add(IsExistPass);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogMenu";
            Text = "LogMenu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button button1;
        private PictureBox pictureBox1;
        private Label IsExistPass;
        private PictureBox CloseEye;
        private PictureBox OpenEye;
    }
}
