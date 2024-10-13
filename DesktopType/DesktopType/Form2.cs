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
            //IsEqualPassword.Visible = IsEqual();

            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RepeatPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsEqualPassword.Visible = IsEqual();

            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text.Equals("") || PasswordBox.Text.Equals("") || RepeatPasswordBox.Text.Equals(""))
            {
                Warn.Text = "Не все поля заполнены!";
                Warn.Visible = true;
            }
            else if (PasswordBox.Text.Equals(RepeatPasswordBox.Text))
            {
                if (!isExist(LoginBox.Text.ToLower()))
                {
                    Warn.Visible = false;

                    string filePath = "Users.txt";
                    string content = LoginBox.Text.ToLower() + "$" + PasswordBox.Text.ToLower() + "$" + 0 + "$" + 0 + "$" + 0;

                    // Запись текста в файл
                    File.AppendAllText(filePath, content + Environment.NewLine);
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
        

        //Обработка закрытия формы
        private void RegMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logMenu.Close();
        }

        //Анимация кнопки авторизации
        private void LogLabel_MouseEnter(object sender, EventArgs e)
        {
            LogLabel.Image = Image.FromFile($"C:/Users/user/Desktop/tmp/DesktopType/DesktopType/DesktopType/Resources/LogLabelME.png");
        }

        private void LogLabel_MouseLeave(object sender, EventArgs e)
        {
            LogLabel.Image = Image.FromFile($"C:/Users/user/Desktop/tmp/DesktopType/DesktopType/DesktopType/Resources/LogLabel.png");
        }

        private void LogLabel_Click(object sender, EventArgs e)
        {
            logMenu.Show();
            this.Hide();
        }

        //public bool IsEqual()
        //{
        //    if (PasswordBox.Text.Equals(RepeatPasswordBox.Text))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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