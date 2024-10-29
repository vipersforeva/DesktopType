using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopType
{
    public partial class LogMenu : Form
    {
        public LogMenu _instance;

        public LogMenu()
        {
            InitializeComponent();
            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона логина
            LoginBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта логина

            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D"); // Цвет фона пароля
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#808080"); // Цвет шрифта пароля

            _instance = this;
        }

        //Обработка вводных данных в поле логина
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

        //Обработка вводных данных в поле пароля
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
                if (correctData(LoginBox.Text.ToLower(), PasswordBox.Text))
                {
                    MainMenu mainMenu = new MainMenu(_instance, LoginBox.Text.ToLower());
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Проверьте введеные вами данные!");
                }
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

        //Анимации кнопки "Зарегистрироваться"
        private void RegLabel_MouseEnter(object sender, EventArgs e)
        {
            RegLabel.Image = Image.FromFile($"Pictures/RegLabelME.png");
        }

        private void RegLabel_MouseLeave(object sender, EventArgs e)
        {
            RegLabel.Image = Image.FromFile($"Pictures/RegLabel.png");
        }

        //Логика перехода на форму регистрации
        private void RegLabel_Click(object sender, EventArgs e)
        {
            RegMenu regMenu = new RegMenu(_instance);
            regMenu.Show();
            this.Hide();
        }

        private bool correctData(string login, string password)
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
                        if (login.Equals(groupOfUsers[0]) && password.Equals(groupOfUsers[1]))
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
                return false;
            }
        }
    }
}