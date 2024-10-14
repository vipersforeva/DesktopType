using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopType
{
    public partial class MainMenu : Form
    {
        private LogMenu logMenu;
        private static int i = 0; //переменная счетчик для закрашивания введеного текста
        public MainMenu(LogMenu logMenu)
        {
            InitializeComponent();

            MainTextBox.BackColor = ColorTranslator.FromHtml("#131111");

            this.logMenu = logMenu;

            MainTextBox.SelectionStart = 0; // начальная позиция
            MainTextBox.SelectionLength = MainTextBox.Text.Length; // длина текста
            MainTextBox.SelectionColor = ColorTranslator.FromHtml("#717171"); // красный цвет

            getText();
        }

        //Функция проверяющая на пустой текст и отображения текста в основном меню
        private void getText()
        {
            string text = "";

            while (text.Length < 3)
            {
                text = randomText();
            }

            MainTextBox.Text = text;
        }

        //Функция осуществляющая выбор рандомного текста из файла
        private string randomText()
        {
            string filePath = "Texts.txt";
            string text;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                var random = new Random();
                text = lines[random.Next(lines.Length)];
                return text;
            }
            else
            {
                return null;
            }
        }

        //Обработка закрытия формы
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logMenu.Close();
        }

        //Временная кнопка обновления текста
        private void button1_Click(object sender, EventArgs e)
        {
            getText();
            MainTextBox.SelectionStart = 0; // начальная позиция
            MainTextBox.SelectionLength = MainTextBox.Text.Length; // длина текста
            MainTextBox.SelectionColor = ColorTranslator.FromHtml("#717171"); // красный цвет
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                i--;
                MainTextBox.Select(i, 1);
                MainTextBox.SelectionColor = ColorTranslator.FromHtml("#717171");
                e.Handled = true; // Помечаем событие как обработанное
                e.SuppressKeyPress = true; //Скажем НЕТ удалению!
                MainTextBox.DeselectAll();
                return;
            }
            else { 
                return; 
            }
        }

        private void MainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                MainTextBox.Select(i, 1);
                if (e.KeyChar == MainTextBox.Text[i])
                {
                    MainTextBox.SelectionColor = Color.Green;
                    i++;
                    e.Handled = true;
                    MainTextBox.DeselectAll();
                    int currentPosition = MainTextBox.SelectionStart;
                    MainTextBox.Select(currentPosition + 1, 0);
                }
                else if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
                {
                    MainTextBox.SelectionColor = Color.Red;
                    i++;
                    e.Handled = true;
                    MainTextBox.DeselectAll();
                    int currentPosition = MainTextBox.SelectionStart;
                    MainTextBox.Select(currentPosition + 1, 0);
                }
                else
                {
                    e.Handled = true;
                    MainTextBox.DeselectAll();
                }
            }
            catch
            {
                MessageBox.Show("Вы все написали!\n");
            }
        }
    }
}
