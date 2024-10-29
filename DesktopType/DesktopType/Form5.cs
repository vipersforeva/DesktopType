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
    public partial class AccountMenu : Form
    {
        private LogMenu logmenu;
        private MainMenu mainmenu;

        public AccountMenu(LogMenu logmenu, MainMenu mainmenu, string userName)
        {
            InitializeComponent();

            this.logmenu = logmenu;
            this.mainmenu = mainmenu;

            helloLabel.BackColor = ColorTranslator.FromHtml("#131111");
            helloLabel.Text = "Привет, " + userName + "!";

            slovo1.BackColor = ColorTranslator.FromHtml("#131111");
            slovo2.BackColor = ColorTranslator.FromHtml("#131111");
            slovo3.BackColor = ColorTranslator.FromHtml("#131111");

            sec15.BackColor = ColorTranslator.FromHtml("#131111");
            sec30.BackColor = ColorTranslator.FromHtml("#131111");
            sec60.BackColor = ColorTranslator.FromHtml("#131111");

            rec1.BackColor = ColorTranslator.FromHtml("#131111");
            rec2.BackColor = ColorTranslator.FromHtml("#131111");
            rec3.BackColor = ColorTranslator.FromHtml("#131111");

            top1.BackColor = ColorTranslator.FromHtml("#131111");
            top2.BackColor = ColorTranslator.FromHtml("#131111");
            top3.BackColor = ColorTranslator.FromHtml("#131111");


            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string[] groupOfUsers;

                int[] rec1Ar = new int[2];
                int[] rec2Ar = new int[2];
                int[] rec3Ar = new int[2];

                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');

                    if (groupOfUsers[0].Equals(userName))
                    {
                        rec1.Text = groupOfUsers[2] + " симв/сек";
                        rec1Ar[0] = int.Parse(groupOfUsers[2]);
                        rec2.Text = groupOfUsers[3] + " симв/сек";
                        rec2Ar[0] = int.Parse(groupOfUsers[3]);
                        rec3.Text = groupOfUsers[4] + " симв/сек";
                        rec3Ar[0] = int.Parse(groupOfUsers[4]);
                        break;
                    }
                }

                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');

                    if (!groupOfUsers[0].Equals(userName))
                    {
                        if (int.Parse(groupOfUsers[2]) > rec1Ar[0])
                            rec1Ar[1]++;
                        if (int.Parse(groupOfUsers[3]) > rec2Ar[0])
                            rec2Ar[1]++;
                        if (int.Parse(groupOfUsers[4]) > rec3Ar[0])
                            rec3Ar[1]++;
                    }
                }
                
                top1.Text = (rec1Ar[1] + 1).ToString() + " место";
                top2.Text = (rec2Ar[1] + 1).ToString() + " место";
                top3.Text = (rec3Ar[1] + 1).ToString() + " место";
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            logmenu.Close();
        }

        //удалить
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
