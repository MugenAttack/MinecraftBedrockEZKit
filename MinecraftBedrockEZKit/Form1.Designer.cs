namespace MinecraftBedrockEZKit
{
    partial class Form1
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
            this.cbProfiles = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblProfileError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbProfiles
            // 
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.ItemHeight = 23;
            this.cbProfiles.Location = new System.Drawing.Point(78, 400);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(168, 29);
            this.cbProfiles.TabIndex = 3;
            this.cbProfiles.UseSelectable = true;
            this.cbProfiles.SelectedIndexChanged += new System.EventHandler(this.CbProfiles_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 405);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Profile";
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(608, 400);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(113, 29);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Create Profile";
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(162, 63);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(133, 120);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Recipe";
            this.metroTile3.TileImage = global::MinecraftBedrockEZKit.Properties.Resources.RecipeIcon2;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Visible = false;
            this.metroTile3.Click += new System.EventHandler(this.MetroTile3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(133, 120);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Item";
            this.metroTile1.TileImage = global::MinecraftBedrockEZKit.Properties.Resources.ItemIcon1;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // lblProfileError
            // 
            this.lblProfileError.AutoSize = true;
            this.lblProfileError.BackColor = System.Drawing.Color.Red;
            this.lblProfileError.ForeColor = System.Drawing.Color.Red;
            this.lblProfileError.Location = new System.Drawing.Point(252, 405);
            this.lblProfileError.Name = "lblProfileError";
            this.lblProfileError.Size = new System.Drawing.Size(165, 19);
            this.lblProfileError.TabIndex = 6;
            this.lblProfileError.Text = "Select a profile to proceed";
            this.lblProfileError.UseCustomForeColor = true;
            this.lblProfileError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(748, 452);
            this.Controls.Add(this.lblProfileError);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbProfiles);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Minecraft Bedrock EZ Creation Kit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroComboBox cbProfiles;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnProfile;
        private MetroFramework.Controls.MetroLabel lblProfileError;
    }
}