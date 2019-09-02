namespace MinecraftBedrockEZKit
{
    partial class items
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictImage = new System.Windows.Forms.PictureBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.lstComponents = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(551, 335);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.pictImage);
            this.metroTabPage1.Controls.Add(this.cbCategory);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtDName);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(543, 293);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Basic Info";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(391, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Click Image to Load";
            // 
            // pictImage
            // 
            this.pictImage.BackColor = System.Drawing.Color.Transparent;
            this.pictImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictImage.Location = new System.Drawing.Point(380, 18);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(149, 141);
            this.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictImage.TabIndex = 11;
            this.pictImage.TabStop = false;
            this.pictImage.Click += new System.EventHandler(this.PictImage_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Items.AddRange(new object[] {
            "Nature",
            "Construction",
            "Items",
            "Equipment"});
            this.cbCategory.Location = new System.Drawing.Point(129, 76);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 29);
            this.cbCategory.Style = MetroFramework.MetroColorStyle.Green;
            this.cbCategory.TabIndex = 7;
            this.cbCategory.UseSelectable = true;
            this.cbCategory.TextChanged += new System.EventHandler(this.CbCategory_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Category";
            // 
            // txtDName
            // 
            // 
            // 
            // 
            this.txtDName.CustomButton.Image = null;
            this.txtDName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtDName.CustomButton.Name = "";
            this.txtDName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDName.CustomButton.TabIndex = 1;
            this.txtDName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDName.CustomButton.UseSelectable = true;
            this.txtDName.CustomButton.Visible = false;
            this.txtDName.Lines = new string[0];
            this.txtDName.Location = new System.Drawing.Point(129, 47);
            this.txtDName.MaxLength = 32767;
            this.txtDName.Name = "txtDName";
            this.txtDName.PasswordChar = '\0';
            this.txtDName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDName.SelectedText = "";
            this.txtDName.SelectionLength = 0;
            this.txtDName.SelectionStart = 0;
            this.txtDName.ShortcutsEnabled = true;
            this.txtDName.Size = new System.Drawing.Size(205, 23);
            this.txtDName.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDName.TabIndex = 5;
            this.txtDName.UseSelectable = true;
            this.txtDName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDName.TextChanged += new System.EventHandler(this.TxtDName_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 47);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Display Name";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(129, 18);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(205, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Green;
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.btnEdit);
            this.metroTabPage2.Controls.Add(this.lstComponents);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(543, 293);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Components";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 253);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(341, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Select a component and press edit to make changes to it";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(399, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // lstComponents
            // 
            this.lstComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstComponents.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstComponents.FullRowSelect = true;
            this.lstComponents.Location = new System.Drawing.Point(3, 3);
            this.lstComponents.Name = "lstComponents";
            this.lstComponents.OwnerDraw = true;
            this.lstComponents.Size = new System.Drawing.Size(537, 237);
            this.lstComponents.Style = MetroFramework.MetroColorStyle.Green;
            this.lstComponents.TabIndex = 2;
            this.lstComponents.UseCompatibleStateImageBehavior = false;
            this.lstComponents.UseSelectable = true;
            this.lstComponents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Component";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 282;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(403, 29);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(167, 28);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Item";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 421);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "items";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "New Item";
            this.Load += new System.EventHandler(this.Items_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnCreate;
        private System.Windows.Forms.PictureBox pictImage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroListView lstComponents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}