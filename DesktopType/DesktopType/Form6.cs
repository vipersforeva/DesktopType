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
    public partial class resultMenu : Form
    {
        private LogMenu logmenu;
        private MainMenu mainmenu;
        private int speedOfType;
        private int accuracy;
        private int time;

        public resultMenu(LogMenu logmenu, MainMenu mainmenu, int speedOfType, int accuracy, int time)
        {
            InitializeComponent();
            
            this.logmenu = logmenu;
            this.mainmenu = mainmenu;

            speed.Text = speedOfType.ToString();
            acc.Text = accuracy.ToString() + "%";
            times.Text = time.ToString() + " сек";

            speed.BackColor = ColorTranslator.FromHtml("#892199");
            acc.BackColor = ColorTranslator.FromHtml("#29A9B7");
            times.BackColor = ColorTranslator.FromHtml("#28CCA4");
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            logmenu.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            mainmenu.Show();
            this.Hide();
        }
    }
}
