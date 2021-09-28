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

        // Exit Button (Hover-NonHover)
        private void ExitButton_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            ExitButton_PictureBox.Image = Resources.InstagramX_HoveredExitIcon;
        }

        private void ExitButton_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitButton_PictureBox.Image = Resources.InstagramX_ExitIcon;
        }

        // Minimize Button (Hover-NonHover)
        private void MinimizeButton_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton_PictureBox.Image = Resources.InstagramX_HoveredMinimzeIcon;
        }

        private void MinimizeButton_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton_PictureBox.Image = Resources.InstagramX_MinimzeIcon;
        }

        // UI Change When Clicks Are Method --> ButtonUI
        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(MainMenu_Button, Database_Button, Statistics_Button, Settings_Button, Navigation_Panel);
        }

        private void Database_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Database_Button, MainMenu_Button, Statistics_Button, Settings_Button, Navigation_Panel);
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Statistics_Button, MainMenu_Button, Database_Button, Settings_Button, Navigation_Panel);
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Settings_Button, MainMenu_Button, Database_Button, Statistics_Button, Navigation_Panel);
        }

        // Window State Controls
        private void ExitButton_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_PictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonUI(Button FirstButton, Button SecondButton, Button ThirdButton, Button FourthButton, Panel NavigationPanel)
        {
            // Sets The FirstButton As Clicked
            FirstButton.BackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.CheckedBackColor = Color.FromArgb(46, 51, 73);
            NavigationPanel.Top = FirstButton.Top;
            NavigationPanel.Left = FirstButton.Left;

            // Sets The Other Buttons Old Version
            SecondButton.BackColor = Color.FromArgb(24, 30, 54);
            SecondButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            SecondButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 54);
            SecondButton.FlatAppearance.CheckedBackColor = Color.FromArgb(24, 30, 54);

            ThirdButton.BackColor = Color.FromArgb(24, 30, 54);
            ThirdButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            ThirdButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 54);
            ThirdButton.FlatAppearance.CheckedBackColor = Color.FromArgb(24, 30, 54);

            FourthButton.BackColor = Color.FromArgb(24, 30, 54);
            FourthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            FourthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 54);
            FourthButton.FlatAppearance.CheckedBackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
