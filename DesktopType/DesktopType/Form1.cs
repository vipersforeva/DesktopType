namespace DesktopType
{
    public partial class LogMenu : Form
    {
        public LogMenu()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None; // Убирает границы окна
            //this.WindowState = FormWindowState.Maximized; // Разворачивает окно на весь экран
            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона логина
            LoginBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта логина

            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона пароля
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта пароля
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            RegMenu regmenu = new RegMenu();
            regmenu.Show();
        }

        private void LogMenu_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text.Equals("") || PasswordBox.Text.Equals(""))
            {
                IsExistPass.Visible = true;
            }
            else
            {
            }
        }
    }
}