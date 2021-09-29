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
        }

        private void FollowUser_Button_MouseLeave(object sender, EventArgs e)
        {
            FollowUser_Button.Image = Resources.InstagramX_NFollowerIcon;
        }

        // LikePostsButton (Hover-NonHover)
        private void LikePosts_Button_MouseEnter(object sender, EventArgs e)
        {
            LikePosts_Button.Image = Resources.InstagramX_HoveredLikeIcon;
        }

        private void LikePosts_Button_MouseLeave(object sender, EventArgs e)
        {
            LikePosts_Button.Image = Resources.InstagramX_NLikeIcon;
        }

        // CommentButton (Hover-NonHover)
        private void Comment_Button_MouseEnter(object sender, EventArgs e)
        {
            Comment_Button.Image = Resources.InstagramX_HoveredCommentIcon;
        }

        private void Comment_Button_MouseLeave(object sender, EventArgs e)
        {
            Comment_Button.Image = Resources.InstagramX_NCommentIcon;
        }
    }
}
