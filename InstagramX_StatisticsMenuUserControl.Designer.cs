
namespace InstagramX
{
    partial class InstagramX_StatisticsMenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.LeftMargin_Panel = new System.Windows.Forms.Panel();
            this.RightMargin_Panel = new System.Windows.Forms.Panel();
            this.BottomMargin_Panel = new System.Windows.Forms.Panel();
            this.TopMargin_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.LeftMargin_Panel);
            this.Main_Panel.Controls.Add(this.RightMargin_Panel);
            this.Main_Panel.Controls.Add(this.BottomMargin_Panel);
            this.Main_Panel.Controls.Add(this.TopMargin_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(630, 475);
            this.Main_Panel.TabIndex = 0;
            // 
            // LeftMargin_Panel
            // 
            this.LeftMargin_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMargin_Panel.Location = new System.Drawing.Point(0, 10);
            this.LeftMargin_Panel.Name = "LeftMargin_Panel";
            this.LeftMargin_Panel.Size = new System.Drawing.Size(10, 455);
            this.LeftMargin_Panel.TabIndex = 11;
            // 
            // RightMargin_Panel
            // 
            this.RightMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMargin_Panel.Location = new System.Drawing.Point(620, 10);
            this.RightMargin_Panel.Name = "RightMargin_Panel";
            this.RightMargin_Panel.Size = new System.Drawing.Size(10, 455);
            this.RightMargin_Panel.TabIndex = 10;
            // 
            // BottomMargin_Panel
            // 
            this.BottomMargin_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMargin_Panel.Location = new System.Drawing.Point(0, 465);
            this.BottomMargin_Panel.Name = "BottomMargin_Panel";
            this.BottomMargin_Panel.Size = new System.Drawing.Size(630, 10);
            this.BottomMargin_Panel.TabIndex = 9;
            // 
            // TopMargin_Panel
            // 
            this.TopMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMargin_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopMargin_Panel.Name = "TopMargin_Panel";
            this.TopMargin_Panel.Size = new System.Drawing.Size(630, 10);
            this.TopMargin_Panel.TabIndex = 8;
            // 
            // InstagramX_StatisticsMenuUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "InstagramX_StatisticsMenuUserControl";
            this.Size = new System.Drawing.Size(630, 475);
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel LeftMargin_Panel;
        private System.Windows.Forms.Panel RightMargin_Panel;
        private System.Windows.Forms.Panel BottomMargin_Panel;
        private System.Windows.Forms.Panel TopMargin_Panel;
    }
}
