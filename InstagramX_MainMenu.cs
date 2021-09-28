using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramX.Properties;

namespace InstagramX
{
    public partial class InstagramX_MainMenu : Form
    {
        public InstagramX_MainMenu()
        {
            InitializeComponent();
        }

        // MainMenu Button (Hover-NonHover)
        private void MainMenu_Button_MouseEnter(object sender, EventArgs e)
        {
            MainMenu_Button.Image = Resources.InstagramX_HoveredHomeIcon;
            MainMenu_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void MainMenu_Button_MouseLeave(object sender, EventArgs e)
        {
            MainMenu_Button.Image = Resources.InstagramX_HomeIcon;
            MainMenu_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        //  Database Button (Hover-NonHover)
        private void Database_Button_MouseEnter(object sender, EventArgs e)
        {
            Database_Button.Image = Resources.InstagramX_HoveredDatabaseIcon;
            Database_Button.ForeColor  = Color.FromArgb(19, 165, 254); 
        }

        private void Database_Button_MouseLeave(object sender, EventArgs e)
        {
            Database_Button.Image = Resources.InstagramX_DatabaseIcon;
            Database_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // Statistics Button (Hover-NonHover)
        private void Statistics_Button_MouseEnter(object sender, EventArgs e)
        {
            Statistics_Button.Image = Resources.InstagramX_HoveredStatisticsIcon;
            Statistics_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void Statistics_Button_MouseLeave(object sender, EventArgs e)
        {
            Statistics_Button.Image = Resources.InstagramX_StatisticsIcon;
            Statistics_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // Settings Button (Hover-NonHover)
        private void Settings_Button_MouseEnter(object sender, EventArgs e)
        {
            Settings_Button.Image = Resources.InstagramX_HoveredSettingsIcon;
            Settings_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void Settings_Button_MouseLeave(object sender, EventArgs e)
        {
            Settings_Button.Image = Resources.InstagramX_SettingsIcon;
            Settings_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {

        }

        private void Database_Button_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUI(Button FirstButton, Button SecondButton, Button ThirdButton, Button FourthButton, Panel NavigationPanel)
        {

        }
    }
}
