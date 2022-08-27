using InstagramX.Icons;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InstagramX
{
    public partial class InstagramX_StatisticsMenuUserControl : UserControl
    {
        public InstagramX_StatisticsMenuUserControl()
        {
            InitializeComponent();
        }

        // Export Operation Statistics To HTML Button (Hover-NonHover)
        private void ExportOperationStatisticsToHTML_Button_MouseEnter(object sender, EventArgs e)
        {
            ExportOperationStatisticsToHTML_Button.Image = Resources.InstagramX_HoveredHTMLIcon;
            ExportOperationStatisticsToHTML_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void ExportOperationStatisticsToHTML_Button_MouseLeave(object sender, EventArgs e)
        {
            ExportOperationStatisticsToHTML_Button.Image = Resources.InstagramX_HTMLIcon;
            ExportOperationStatisticsToHTML_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // Export Operation Statistics To HTML Button (Hover-NonHover)
        private void ExportAccountStatisticsToHTML_TextBox_MouseEnter(object sender, EventArgs e)
        {
            ExportAccountStatisticsToHTML_TextBox.Image = Resources.InstagramX_HoveredHTMLIcon;
            ExportAccountStatisticsToHTML_TextBox.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void ExportAccountStatisticsToHTML_TextBox_MouseLeave(object sender, EventArgs e)
        {
            ExportAccountStatisticsToHTML_TextBox.Image = Resources.InstagramX_HTMLIcon;
            ExportAccountStatisticsToHTML_TextBox.ForeColor = Color.FromArgb(4, 150, 239);
        }
    }
}
