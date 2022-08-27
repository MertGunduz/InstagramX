using System;
using System.Windows.Forms;

namespace InstagramX
{
    public partial class InstagramX_AwakeMenu : Form
    {
        int time = 0;

        public InstagramX_AwakeMenu()
        {
            InitializeComponent();
        }

        private void InstagramX_AwakeMenu_Load(object sender, EventArgs e)
        {
            AwakeMenu_Timer.Start();
        }

        private void AwakeMenu_Timer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time == 100)
            {
                AwakeMenu_Timer.Stop();
                InstagramX_MainMenu instagramX_MainMenu = new InstagramX_MainMenu();
                this.Hide();
                instagramX_MainMenu.Show();
            }
        }
    }
}
