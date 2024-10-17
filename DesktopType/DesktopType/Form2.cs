using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopType
{
    public partial class RegMenu : Form
    {
        private LogMenu logMenu;

        public RegMenu(LogMenu logMenu)
        {
            InitializeComponent();

            this.logMenu = logMenu;

            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона логина
            LoginBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта логина

            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона пароля
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта пароля

            RepeatPasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона пароля
            RepeatPasswordBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта пароля
        }

        // Обработка вводных данных в поле логина
        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешение ввода чисел, букв и символа backspace
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                // Запрет на ввод любых других символов
                e.Handled = true;
            }
        }

        // Обработка вводных данных в поле пароля
        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешение ввода чисел, букв и символа backspace
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                // Запрет на ввод любых других символов
                e.Handled = true;
            }
        }

        // Обработка вводных данных в поле повторение пароля
        private void RepeatPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешение ввода чисел, букв и символа backspace
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                // Запрет на ввод любых других символов
                e.Handled = true;
            }
        }

        // Обработка нажатия на кнопку "Зарегистрироваться"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Проверка, что все поля заполнены.
            if (LoginBox.Text.Equals("") || PasswordBox.Text.Equals("") || RepeatPasswordBox.Text.Equals(""))
            {
                Warn.Text = "Не все поля заполнены!";
                Warn.Visible = true;
            }
            // Проверка, что пароли совпадают.
            else if (PasswordBox.Text.Equals(RepeatPasswordBox.Text))
            {
                // Проверка, существует ли уже аккаунт с таким логином.
                if (!isExist(LoginBox.Text.ToLower()))
                {
                    Warn.Visible = false;

                    string filePath = "Users.txt";
                    string content = LoginBox.Text.ToLower() + "$" + PasswordBox.Text.ToLower() + "$" + 0 + "$" + 0 + "$" + 0;

                    // Запись текста в файл
                    File.AppendAllText(filePath, content + Environment.NewLine);

                    MessageBox.Show("Вы успешно зарегстрированы!");
                    logMenu.Show();
                    this.Hide();
                }
                else
                {
                    Warn.Text = "Аккаунт с таким логином уже существует!";
                    Warn.Visible = true;
                }
            }
            else
            {
                Warn.Text = "Пароли не совпадают!";
                Warn.Visible = true;
            }
        }
        
        // Обработка закрытия формы
        private void RegMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logMenu.Close();
        }

        // Анимации кнопки "Авторизоваться"
        private void LogLabel_MouseEnter(object sender, EventArgs e)
        {
            LogLabel.Image = Image.FromFile($"Pictures/LogLabelME.png");
        }

        private void LogLabel_MouseLeave(object sender, EventArgs e)
        {
            LogLabel.Image = Image.FromFile($"Pictures/LogLabel.png");
        }

        // Логика перехода на форму авторизации
        private void LogLabel_Click(object sender, EventArgs e)
        {
            logMenu.Show();
            this.Hide();
        }

        // Проверка, существует ли пользователь с заданным userName.
        public static bool isExist(string userName)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Users.txt"))
                {
                    string line;
                    string[] groupOfUsers;
                    while ((line = sr.ReadLine()) != null)
                    {
                        groupOfUsers = line.Split('$');
                        if (userName.Equals(groupOfUsers[0]))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }
    }
}