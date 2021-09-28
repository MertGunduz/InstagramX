
namespace InstagramX
{
    partial class InstagramX_MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstagramX_MainMenu));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.MainLogo_Panel = new System.Windows.Forms.Panel();
            this.MainHeaderLabel_Panel = new System.Windows.Forms.Panel();
            this.Statistics_Button = new System.Windows.Forms.Button();
            this.Database_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            this.MainLogo_Panel.SuspendLayout();
            this.MainHeaderLabel_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.Left_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(800, 500);
            this.Main_Panel.TabIndex = 0;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Left_Panel.Controls.Add(this.panel1);
            this.Left_Panel.Controls.Add(this.Statistics_Button);
            this.Left_Panel.Controls.Add(this.Database_Button);
            this.Left_Panel.Controls.Add(this.Settings_Button);
            this.Left_Panel.Controls.Add(this.MainMenu_Button);
            this.Left_Panel.Controls.Add(this.MainHeaderLabel_Panel);
            this.Left_Panel.Controls.Add(this.MainLogo_Panel);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(170, 500);
            this.Left_Panel.TabIndex = 0;
            // 
            // MainLogo_Panel
            // 
            this.MainLogo_Panel.Controls.Add(this.Logo_PictureBox);
            this.MainLogo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLogo_Panel.Location = new System.Drawing.Point(0, 0);
            this.MainLogo_Panel.Name = "MainLogo_Panel";
            this.MainLogo_Panel.Size = new System.Drawing.Size(170, 120);
            this.MainLogo_Panel.TabIndex = 0;
            // 
            // MainHeaderLabel_Panel
            // 
            this.MainHeaderLabel_Panel.Controls.Add(this.pictureBox1);
            this.MainHeaderLabel_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainHeaderLabel_Panel.Location = new System.Drawing.Point(0, 120);
            this.MainHeaderLabel_Panel.Name = "MainHeaderLabel_Panel";
            this.MainHeaderLabel_Panel.Size = new System.Drawing.Size(170, 30);
            this.MainHeaderLabel_Panel.TabIndex = 1;
            // 
            // Statistics_Button
            // 
            this.Statistics_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistics_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Button.FlatAppearance.BorderSize = 0;
            this.Statistics_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Statistics_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Statistics_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Statistics_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Statistics_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Statistics_Button.Image = global::InstagramX.Properties.Resources.InstagramX_StatisticsIcon;
            this.Statistics_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Statistics_Button.Location = new System.Drawing.Point(0, 240);
            this.Statistics_Button.Name = "Statistics_Button";
            this.Statistics_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Statistics_Button.Size = new System.Drawing.Size(170, 45);
            this.Statistics_Button.TabIndex = 5;
            this.Statistics_Button.Text = "Statistics";
            this.Statistics_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_Button.UseVisualStyleBackColor = true;
            this.Statistics_Button.Click += new System.EventHandler(this.Statistics_Button_Click);
            this.Statistics_Button.MouseEnter += new System.EventHandler(this.Statistics_Button_MouseEnter);
            this.Statistics_Button.MouseLeave += new System.EventHandler(this.Statistics_Button_MouseLeave);
            // 
            // Database_Button
            // 
            this.Database_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Database_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Database_Button.FlatAppearance.BorderSize = 0;
            this.Database_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Database_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Database_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Database_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Database_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Database_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Database_Button.Image = global::InstagramX.Properties.Resources.InstagramX_DatabaseIcon;
            this.Database_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Database_Button.Location = new System.Drawing.Point(0, 195);
            this.Database_Button.Name = "Database_Button";
            this.Database_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Database_Button.Size = new System.Drawing.Size(170, 45);
            this.Database_Button.TabIndex = 4;
            this.Database_Button.Text = "Database";
            this.Database_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Database_Button.UseVisualStyleBackColor = true;
            this.Database_Button.Click += new System.EventHandler(this.Database_Button_Click);
            this.Database_Button.MouseEnter += new System.EventHandler(this.Database_Button_MouseEnter);
            this.Database_Button.MouseLeave += new System.EventHandler(this.Database_Button_MouseLeave);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Settings_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.Settings_Button.Image = global::InstagramX.Properties.Resources.InstagramX_SettingsIcon;
            this.Settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.Location = new System.Drawing.Point(0, 455);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Settings_Button.Size = new System.Drawing.Size(170, 45);
            this.Settings_Button.TabIndex = 3;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            this.Settings_Button.MouseEnter += new System.EventHandler(this.Settings_Button_MouseEnter);
            this.Settings_Button.MouseLeave += new System.EventHandler(this.Settings_Button_MouseLeave);
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenu_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu_Button.FlatAppearance.BorderSize = 0;
            this.MainMenu_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainMenu_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainMenu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenu_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.MainMenu_Button.Image = global::InstagramX.Properties.Resources.InstagramX_HomeIcon;
            this.MainMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenu_Button.Location = new System.Drawing.Point(0, 150);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainMenu_Button.Size = new System.Drawing.Size(170, 45);
            this.MainMenu_Button.TabIndex = 2;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Button.UseVisualStyleBackColor = true;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            this.MainMenu_Button.MouseEnter += new System.EventHandler(this.MainMenu_Button_MouseEnter);
            this.MainMenu_Button.MouseLeave += new System.EventHandler(this.MainMenu_Button_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::InstagramX.Properties.Resources.InstagramX_HeaderSmallLabelIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_PictureBox.Image = global::InstagramX.Properties.Resources.InstagramX_LogoIcon;
            this.Logo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(170, 120);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 45);
            this.panel1.TabIndex = 1;
            // 
            // InstagramX_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstagramX_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstagramX";
            this.Main_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            this.MainLogo_Panel.ResumeLayout(false);
            this.MainHeaderLabel_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel MainLogo_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel MainHeaderLabel_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button MainMenu_Button;
        private System.Windows.Forms.Button Statistics_Button;
        private System.Windows.Forms.Button Database_Button;
        private System.Windows.Forms.Panel panel1;
    }
}