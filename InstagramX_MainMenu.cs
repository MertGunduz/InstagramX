using InstagramX.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            Database_Button.ForeColor = Color.FromArgb(19, 165, 254);
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

        // Operations Button (Hover-NonHover)
        private void Operations_Button_MouseEnter(object sender, EventArgs e)
        {
            Operations_Button.Image = Resources.InstagramX_HoveredOperationsIcon;
            Operations_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void Operations_Button_MouseLeave(object sender, EventArgs e)
        {
            Operations_Button.Image = Resources.InstagramX_OperationsIcon;
            Operations_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // About Button (Hover-NonHover)
        private void About_Button_MouseEnter(object sender, EventArgs e)
        {
            About_Button.Image = Resources.InstagramX_HoveredAboutIcon;
            About_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void About_Button_MouseLeave(object sender, EventArgs e)
        {
            About_Button.Image = Resources.InstagramX_AboutIcon;
            About_Button.ForeColor = Color.FromArgb(4, 150, 239);
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
            ButtonUI(MainMenu_Button, Database_Button, Statistics_Button, Operations_Button, About_Button, Navigation_Panel, InstagramX_MainMenuUserControlIns);
        }

        private void Database_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Database_Button, MainMenu_Button, Statistics_Button, Operations_Button, About_Button, Navigation_Panel, InstagramX_DatabaseMenuUserControlIns);
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Statistics_Button, MainMenu_Button, Database_Button, Operations_Button, About_Button, Navigation_Panel, InstagramX_StatisticsMenuUserControlIns);
        }

        private void Operations_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Operations_Button, MainMenu_Button, Database_Button, Statistics_Button, About_Button, Navigation_Panel, InstagramX_OperationsUserControlIns);
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(About_Button, MainMenu_Button, Database_Button, Statistics_Button, Operations_Button, Navigation_Panel, InstagramX_AboutMenuUserControlIns);
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

        private void ButtonUI(Button FirstButton, Button SecondButton, Button ThirdButton, Button FourthButton, Button FifthButton, Panel NavigationPanel, UserControl UserControl)
        {
            // Sets The FirstButton As Clicked
            FirstButton.BackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 51, 73);
            FirstButton.FlatAppearance.CheckedBackColor = Color.FromArgb(46, 51, 73);
            NavigationPanel.Top = FirstButton.Top;
            NavigationPanel.Left = FirstButton.Left;
            UserControl.BringToFront();

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

            FifthButton.BackColor = Color.FromArgb(24, 30, 54);
            FifthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 30, 54);
            FifthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 30, 54);
            FifthButton.FlatAppearance.CheckedBackColor = Color.FromArgb(24, 30, 54);
        }
    }
}