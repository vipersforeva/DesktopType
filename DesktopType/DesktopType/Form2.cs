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
        public RegMenu()
        {
            InitializeComponent();

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