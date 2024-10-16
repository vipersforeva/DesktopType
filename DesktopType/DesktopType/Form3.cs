﻿using System;
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

            RichTextBox1.BackColor = ColorTranslator.FromHtml("#131111");

            this.logMenu = logMenu;

            RichTextBox1.SelectionStart = 0; // начальная позиция
            RichTextBox1.SelectionLength = RichTextBox1.Text.Length; // длина текста
            RichTextBox1.SelectionColor = ColorTranslator.FromHtml("#717171"); // красный цвет

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

            RichTextBox1.Text = text;
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


        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                i--;
                RichTextBox1.Select(i, 1);
                RichTextBox1.SelectionColor = ColorTranslator.FromHtml("#717171");
                e.Handled = true; // Помечаем событие как обработанное
                e.SuppressKeyPress = true; //Скажем НЕТ удалению!
                RichTextBox1.DeselectAll();
                return;
            }
            else
            {
                return;
            }
        }

        private void MainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                RichTextBox1.Select(i, 1);
                if (e.KeyChar == RichTextBox1.Text[i])
                {
                    RichTextBox1.SelectionColor = Color.Green;
                    i++;
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                    int currentPosition = RichTextBox1.SelectionStart;
                    RichTextBox1.Select(currentPosition + 1, 0);
                }
                else if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
                {
                    RichTextBox1.SelectionColor = Color.Red;
                    i++;
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                    int currentPosition = RichTextBox1.SelectionStart;
                    RichTextBox1.Select(currentPosition + 1, 0);
                }
                else
                {
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                }
            }
            catch
            {
                MessageBox.Show("Вы все написали!\n");
            }
        }

        //Анимации кнопки обновления текста
        private void reloadText_MouseEnter_1(object sender, EventArgs e)
        {
            reloadText.Image = Image.FromFile($"Pictures/ReloadText.png");
        }

        private void reloadText_MouseLeave(object sender, EventArgs e)
        {
            reloadText.Image = Image.FromFile($"Pictures/ReloadTextME.png");
        }

        // Обработка кнопки обновления текста
        private void reloadText_Click(object sender, EventArgs e)
        {
            getText();
            RichTextBox1.SelectionStart = 0; // начальная позиция
            RichTextBox1.SelectionLength = RichTextBox1.Text.Length; // длина текста
            RichTextBox1.SelectionColor = ColorTranslator.FromHtml("#717171"); // красный цвет
        }
    }
}