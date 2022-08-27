using System;
using System.Drawing;
using InstagramX.Icons;
using System.Windows.Forms;

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

        // Text Cleaning Algorithms (TextBoxes)
        private void FollowerBotInstagramUser_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FollowerBotInstagramUser_TextBox.Text == "  Instagram User:")
            {
                FollowerBotInstagramUser_TextBox.Clear();
            }
        }

        private void FollowerBotFollowerQty_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FollowerBotFollowerQty_TextBox.Text == "  Follower Qty:")
            {
                FollowerBotFollowerQty_TextBox.Clear();
            }
        }

        private void FollowerBotSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FollowerBotSpeed_TextBox.Text == "  Speed (1000-3000):")
            {
                FollowerBotSpeed_TextBox.Clear();
            }
        }

        private void LikeBotInstagramUser_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LikeBotInstagramUser_TextBox.Text == "  Instagram User:")
            {
                LikeBotInstagramUser_TextBox.Clear();
            }
        }

        private void LikeBotLikeQty_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LikeBotLikeQty_TextBox.Text == "  Like Qty:")
            {
                LikeBotLikeQty_TextBox.Clear();
            }
        }

        private void LikeBotSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LikeBotSpeed_TextBox.Text == "  Speed (1000-3000):")
            {
                LikeBotSpeed_TextBox.Clear();
            }
        }

        private void CommentBotInstagramUser_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CommentBotInstagramUser_TextBox.Text == "  Instagram User:")
            {
                CommentBotInstagramUser_TextBox.Clear();
            }
        }

        private void CommentBotCommentQty_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CommentBotCommentQty_TextBox.Text == "  Comment Qty:")
            {
                CommentBotCommentQty_TextBox.Clear();
            }
        }

        private void CommentBotSpeed_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CommentBotSpeed_TextBox.Text == "  Speed (1000-3000):")
            {
                CommentBotSpeed_TextBox.Clear();
            }
        }
    }
}
