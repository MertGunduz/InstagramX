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
    public partial class InstagramX_DatabaseMenuUserControl : UserControl
    {
        public InstagramX_DatabaseMenuUserControl()
        {
            InitializeComponent();
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
    }
}
