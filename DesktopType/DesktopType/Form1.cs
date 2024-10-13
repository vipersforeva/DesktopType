using System.Runtime.CompilerServices;

namespace DesktopType
{
    public partial class LogMenu : Form
    {
        public LogMenu _instance;

        public LogMenu()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None; // Убирает границы окна
            this.WindowState = FormWindowState.Maximized; // Разворачивает окно на весь экран
            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона логина
            LoginBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта логина

            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона пароля
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта пароля

            _instance = this;
        }

        //Обработка вводных данных в поле логина
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

        //Обработка вводных данных в поле пароля
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


        //Обработка нажатия на кнопку входа
        private void LogMenu_Click(object sender, EventArgs e)
        {
            //Проверка корректности значений
            if (LoginBox.Text.Equals("") || PasswordBox.Text.Equals(""))
            {
                IsExistPass.Visible = true;
            }
            else
            {
                IsExistPass.Visible = false;
                //Логика входа в программу

            }
        }


        //Логика работы глаза пароля
        private void PassEye_Click(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == '●')
            {
                PasswordBox.PasswordChar = '\0';
                CloseEye.Visible = false;
                OpenEye.Visible = true;
            }
            else
            {
                PasswordBox.PasswordChar = '●';
                CloseEye.Visible = true;
                OpenEye.Visible = false;
            }
        }

        //Анимация кнопки зарегистрироваться 
        private void RegLabel_MouseEnter(object sender, EventArgs e)
        {
            RegLabel.Image = Image.FromFile($"C:/Users/user/Desktop/tmp/DesktopType/DesktopType/DesktopType/Resources/RegLabelME.png");
        }

        private void RegLabel_MouseLeave(object sender, EventArgs e)
        {
            RegLabel.Image = Image.FromFile($"C:/Users/user/Desktop/tmp/DesktopType/DesktopType/DesktopType/Resources/RegLabel.png");
        }

        //Логика перехода на форму регистрации

        private void RegLabel_Click(object sender, EventArgs e)
        {
            //RegMenu regmenu = new RegMenu(_instance);
            //regmenu.Show();
            //this.Hide();

            //Попытка убрать мерцание
            using (RegMenu regmenu = new RegMenu(_instance))
            {
                this.Hide();
                regmenu.ShowDialog();
                this.Show();
            }
        }
    }
}