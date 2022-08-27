using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using InstagramX.Icons;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using TwoCaptcha.Captcha;

namespace InstagramX
{
    public partial class InstagramX_DatabaseMenuUserControl : UserControl
    {
        public InstagramX_DatabaseMenuUserControl()
        {
            InitializeComponent();
        }

        private void InstagramX_DatabaseMenuUserControl_Load(object sender, EventArgs e)
        {
            
        }

        // CreateAccountsButton (Hover-NonHover)
        private void CreateAccounts_Button_MouseEnter(object sender, EventArgs e)
        {
            CreateAccounts_Button.Image = Resources.InstagramX_HoveredCreateAccountsIcon;
            CreateAccounts_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void CreateAccounts_Button_MouseLeave(object sender, EventArgs e)
        {
            CreateAccounts_Button.Image = Resources.InstagramX_CreateAccountsIcon;
            CreateAccounts_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        private void CreateAccountsAccountQty_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreateAccountsAccountQty_TextBox.Text == "  Account Qty:")
            {
                CreateAccountsAccountQty_TextBox.Clear();
            }
        }

        private void CreateAccountsSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CreateAccountsSpeed_TextBox.Text == "  Speed (1000-3000):")
            {
                CreateAccountsSpeed_TextBox.Clear();
            }   
        }
    }
}