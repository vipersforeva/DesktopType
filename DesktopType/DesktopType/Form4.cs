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
    public partial class DescMenu : Form
    {
        private LogMenu logmenu;
        public DescMenu(LogMenu mainMenu)
        {
            InitializeComponent();

            this.logmenu = mainMenu;
        }

        private void DescMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logmenu.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            logmenu.Show();
            this.Hide();
        }
    }
}
