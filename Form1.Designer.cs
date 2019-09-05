namespace Save_My_Files_To_USB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.m_PictureBox_User = new System.Windows.Forms.PictureBox();
            this.m_LinkLabel_User = new System.Windows.Forms.LinkLabel();
            this.m_Button_Add_Repository = new System.Windows.Forms.Button();
            this.m_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.m_Button_Save = new System.Windows.Forms.Button();
            this.m_Label_USB_Path = new System.Windows.Forms.Label();
            this.m_LinkLabel_USB_Path = new System.Windows.Forms.LinkLabel();
            this.m_Button_Add_USB = new System.Windows.Forms.Button();
            this.m_LinkLabel_Help = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // m_CheckedListBox
            // 
            this.m_CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_CheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_CheckedListBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_CheckedListBox.FormattingEnabled = true;
            this.m_CheckedListBox.Location = new System.Drawing.Point(13, 53);
            this.m_CheckedListBox.Name = "m_CheckedListBox";
            this.m_CheckedListBox.ScrollAlwaysVisible = true;
            this.m_CheckedListBox.Size = new System.Drawing.Size(152, 182);
            this.m_CheckedListBox.TabIndex = 0;
            this.m_CheckedListBox.ThreeDCheckBoxes = true;
            // 
            // m_PictureBox_User
            // 
            this.m_PictureBox_User.BackColor = System.Drawing.Color.Transparent;
            this.m_PictureBox_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_PictureBox_User.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureBox_User.Image")));
            this.m_PictureBox_User.Location = new System.Drawing.Point(13, 13);
            this.m_PictureBox_User.Name = "m_PictureBox_User";
            this.m_PictureBox_User.Size = new System.Drawing.Size(26, 24);
            this.m_PictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBox_User.TabIndex = 1;
            this.m_PictureBox_User.TabStop = false;
            this.m_PictureBox_User.Click += new System.EventHandler(this.LinkLabel_Click);
            // 
            // m_LinkLabel_User
            // 
            this.m_LinkLabel_User.AutoSize = true;
            this.m_LinkLabel_User.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LinkLabel_User.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_User.Location = new System.Drawing.Point(45, 24);
            this.m_LinkLabel_User.Name = "m_LinkLabel_User";
            this.m_LinkLabel_User.Size = new System.Drawing.Size(64, 15);
            this.m_LinkLabel_User.TabIndex = 2;
            this.m_LinkLabel_User.TabStop = true;
            this.m_LinkLabel_User.Text = "Utilisateur";
            this.m_LinkLabel_User.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_User.Click += new System.EventHandler(this.LinkLabel_Click);
            // 
            // m_Button_Add_Repository
            // 
            this.m_Button_Add_Repository.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_Button_Add_Repository.BackColor = System.Drawing.Color.Gainsboro;
            this.m_Button_Add_Repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_Add_Repository.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_Add_Repository.Image = ((System.Drawing.Image)(resources.GetObject("m_Button_Add_Repository.Image")));
            this.m_Button_Add_Repository.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_Button_Add_Repository.Location = new System.Drawing.Point(13, 244);
            this.m_Button_Add_Repository.Name = "m_Button_Add_Repository";
            this.m_Button_Add_Repository.Size = new System.Drawing.Size(152, 26);
            this.m_Button_Add_Repository.TabIndex = 3;
            this.m_Button_Add_Repository.Text = "Ajouter un repertoire";
            this.m_Button_Add_Repository.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_Button_Add_Repository.UseVisualStyleBackColor = false;
            this.m_Button_Add_Repository.Click += new System.EventHandler(this.Button_Click);
            // 
            // m_ProgressBar
            // 
            this.m_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ProgressBar.Location = new System.Drawing.Point(-2, 287);
            this.m_ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.m_ProgressBar.Name = "m_ProgressBar";
            this.m_ProgressBar.Size = new System.Drawing.Size(801, 23);
            this.m_ProgressBar.TabIndex = 4;
            // 
            // m_Button_Save
            // 
            this.m_Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_Save.BackColor = System.Drawing.Color.Gainsboro;
            this.m_Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_Save.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_Save.Image = ((System.Drawing.Image)(resources.GetObject("m_Button_Save.Image")));
            this.m_Button_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_Button_Save.Location = new System.Drawing.Point(688, 244);
            this.m_Button_Save.Name = "m_Button_Save";
            this.m_Button_Save.Size = new System.Drawing.Size(100, 26);
            this.m_Button_Save.TabIndex = 5;
            this.m_Button_Save.Text = "Saugarder";
            this.m_Button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_Button_Save.UseVisualStyleBackColor = false;
            this.m_Button_Save.Click += new System.EventHandler(this.Button_Click);
            // 
            // m_Label_USB_Path
            // 
            this.m_Label_USB_Path.AutoSize = true;
            this.m_Label_USB_Path.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_USB_Path.Location = new System.Drawing.Point(213, 53);
            this.m_Label_USB_Path.Name = "m_Label_USB_Path";
            this.m_Label_USB_Path.Size = new System.Drawing.Size(78, 15);
            this.m_Label_USB_Path.TabIndex = 6;
            this.m_Label_USB_Path.Text = "Destination :";
            // 
            // m_LinkLabel_USB_Path
            // 
            this.m_LinkLabel_USB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_LinkLabel_USB_Path.AutoSize = true;
            this.m_LinkLabel_USB_Path.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LinkLabel_USB_Path.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_USB_Path.Location = new System.Drawing.Point(297, 53);
            this.m_LinkLabel_USB_Path.Name = "m_LinkLabel_USB_Path";
            this.m_LinkLabel_USB_Path.Size = new System.Drawing.Size(16, 15);
            this.m_LinkLabel_USB_Path.TabIndex = 7;
            this.m_LinkLabel_USB_Path.TabStop = true;
            this.m_LinkLabel_USB_Path.Text = "...";
            this.m_LinkLabel_USB_Path.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_USB_Path.Click += new System.EventHandler(this.LinkLabel_Click);
            // 
            // m_Button_Add_USB
            // 
            this.m_Button_Add_USB.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_Add_USB.Image = ((System.Drawing.Image)(resources.GetObject("m_Button_Add_USB.Image")));
            this.m_Button_Add_USB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_Button_Add_USB.Location = new System.Drawing.Point(216, 79);
            this.m_Button_Add_USB.Name = "m_Button_Add_USB";
            this.m_Button_Add_USB.Size = new System.Drawing.Size(166, 24);
            this.m_Button_Add_USB.TabIndex = 8;
            this.m_Button_Add_USB.Text = "Ajouter une clé USB";
            this.m_Button_Add_USB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_Button_Add_USB.UseVisualStyleBackColor = true;
            this.m_Button_Add_USB.Click += new System.EventHandler(this.Button_Click);
            // 
            // m_LinkLabel_Help
            // 
            this.m_LinkLabel_Help.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_LinkLabel_Help.AutoSize = true;
            this.m_LinkLabel_Help.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LinkLabel_Help.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_Help.Location = new System.Drawing.Point(772, 9);
            this.m_LinkLabel_Help.Name = "m_LinkLabel_Help";
            this.m_LinkLabel_Help.Size = new System.Drawing.Size(17, 19);
            this.m_LinkLabel_Help.TabIndex = 9;
            this.m_LinkLabel_Help.TabStop = true;
            this.m_LinkLabel_Help.Text = "?";
            this.m_LinkLabel_Help.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.m_LinkLabel_Help);
            this.Controls.Add(this.m_Button_Add_USB);
            this.Controls.Add(this.m_LinkLabel_USB_Path);
            this.Controls.Add(this.m_Label_USB_Path);
            this.Controls.Add(this.m_Button_Save);
            this.Controls.Add(this.m_ProgressBar);
            this.Controls.Add(this.m_Button_Add_Repository);
            this.Controls.Add(this.m_LinkLabel_User);
            this.Controls.Add(this.m_PictureBox_User);
            this.Controls.Add(this.m_CheckedListBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save My Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox m_CheckedListBox;
        private System.Windows.Forms.PictureBox m_PictureBox_User;
        private System.Windows.Forms.LinkLabel m_LinkLabel_User;
        private System.Windows.Forms.Button m_Button_Add_Repository;
        private System.Windows.Forms.ProgressBar m_ProgressBar;
        private System.Windows.Forms.Button m_Button_Save;
        private System.Windows.Forms.Label m_Label_USB_Path;
        private System.Windows.Forms.LinkLabel m_LinkLabel_USB_Path;
        private System.Windows.Forms.Button m_Button_Add_USB;
        private System.Windows.Forms.LinkLabel m_LinkLabel_Help;
    }
}

