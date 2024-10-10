using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            }
            else if (PasswordBox.Text.Equals(RepeatPasswordBox.Text))
            {
                IsEqualPassword.Visible = false;

                string filePath = "Users.txt";
                string content = LoginBox.Text.ToLower() + "$" + PasswordBox.Text.ToLower() + "$" + 0 + "$" + 0 + "$" + 0;

                // Запись текста в файл
                File.AppendAllText(filePath, content + Environment.NewLine);
            }
            else
            {
                IsEqualPassword.Visible = true;
            }

        }

        private void RegMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logMenu.Close();
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
    }
}