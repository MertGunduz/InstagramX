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
    public partial class InstagramX_MainMenuUserControl : UserControl
    {
        public InstagramX_MainMenuUserControl()
        {
            InitializeComponent();
        }

        // FollowerUserButton (Hover-NonHover)
        private void FollowUser_Button_MouseEnter(object sender, EventArgs e)
        {
            FollowUser_Button.Image = Resources.InstagramX_HoveredFollowerIcon;
            FollowUser_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void FollowUser_Button_MouseLeave(object sender, EventArgs e)
        {
            FollowUser_Button.Image = Resources.InstagramX_NFollowerIcon;
            FollowUser_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // LikePostsButton (Hover-NonHover)
        private void LikePosts_Button_MouseEnter(object sender, EventArgs e)
        {
            LikePosts_Button.Image = Resources.InstagramX_HoveredLikeIcon;
            LikePosts_Button.ForeColor = Color.FromArgb(19, 165, 254); 
        }

        private void LikePosts_Button_MouseLeave(object sender, EventArgs e)
        {
            LikePosts_Button.Image = Resources.InstagramX_NLikeIcon;
            LikePosts_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }

        // CommentButton (Hover-NonHover)
        private void Comment_Button_MouseEnter(object sender, EventArgs e)
        {
            Comment_Button.Image = Resources.InstagramX_HoveredCommentIcon;
            Comment_Button.ForeColor = Color.FromArgb(19, 165, 254);
        }

        private void Comment_Button_MouseLeave(object sender, EventArgs e)
        {
            Comment_Button.Image = Resources.InstagramX_NCommentIcon;
            Comment_Button.ForeColor = Color.FromArgb(4, 150, 239);
        }
    }
}
