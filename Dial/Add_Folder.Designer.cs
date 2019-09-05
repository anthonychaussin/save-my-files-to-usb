namespace Save_My_Files_To_USB.Dial
{
    partial class Add_Folder
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.m_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.m_Button_Select_Folder = new System.Windows.Forms.Button();
            this.m_Label_Folder_Selected = new System.Windows.Forms.Label();
            this.m_ListBox_Folder = new System.Windows.Forms.ListBox();
            this.m_Button_Cancel = new System.Windows.Forms.Button();
            this.m_Button_valide = new System.Windows.Forms.Button();
            this.m_Button_Clear = new System.Windows.Forms.Button();
            this.m_Button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // m_Button_Select_Folder
            // 
            this.m_Button_Select_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_Select_Folder.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_Select_Folder.Location = new System.Drawing.Point(14, 43);
            this.m_Button_Select_Folder.Name = "m_Button_Select_Folder";
            this.m_Button_Select_Folder.Size = new System.Drawing.Size(196, 27);
            this.m_Button_Select_Folder.TabIndex = 0;
            this.m_Button_Select_Folder.Text = "Selectionner un dossier";
            this.m_Button_Select_Folder.UseVisualStyleBackColor = true;
            this.m_Button_Select_Folder.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_Label_Folder_Selected
            // 
            this.m_Label_Folder_Selected.AutoSize = true;
            this.m_Label_Folder_Selected.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Folder_Selected.Location = new System.Drawing.Point(217, 47);
            this.m_Label_Folder_Selected.Name = "m_Label_Folder_Selected";
            this.m_Label_Folder_Selected.Size = new System.Drawing.Size(20, 17);
            this.m_Label_Folder_Selected.TabIndex = 1;
            this.m_Label_Folder_Selected.Text = "...";
            // 
            // m_ListBox_Folder
            // 
            this.m_ListBox_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ListBox_Folder.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ListBox_Folder.FormattingEnabled = true;
            this.m_ListBox_Folder.ItemHeight = 15;
            this.m_ListBox_Folder.Location = new System.Drawing.Point(14, 95);
            this.m_ListBox_Folder.Name = "m_ListBox_Folder";
            this.m_ListBox_Folder.Size = new System.Drawing.Size(905, 214);
            this.m_ListBox_Folder.TabIndex = 2;
            // 
            // m_Button_Cancel
            // 
            this.m_Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_Button_Cancel.BackColor = System.Drawing.Color.SandyBrown;
            this.m_Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_Cancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.m_Button_Cancel.Location = new System.Drawing.Point(15, 332);
            this.m_Button_Cancel.Name = "m_Button_Cancel";
            this.m_Button_Cancel.Size = new System.Drawing.Size(87, 27);
            this.m_Button_Cancel.TabIndex = 3;
            this.m_Button_Cancel.Text = "Annuler";
            this.m_Button_Cancel.UseVisualStyleBackColor = false;
            this.m_Button_Cancel.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_Button_valide
            // 
            this.m_Button_valide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_valide.BackColor = System.Drawing.Color.LightGreen;
            this.m_Button_valide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_valide.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Button_valide.Location = new System.Drawing.Point(832, 332);
            this.m_Button_valide.Name = "m_Button_valide";
            this.m_Button_valide.Size = new System.Drawing.Size(87, 27);
            this.m_Button_valide.TabIndex = 4;
            this.m_Button_valide.Text = "Valider";
            this.m_Button_valide.UseVisualStyleBackColor = false;
            this.m_Button_valide.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_Button_Clear
            // 
            this.m_Button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_Clear.Location = new System.Drawing.Point(844, 43);
            this.m_Button_Clear.Name = "m_Button_Clear";
            this.m_Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.m_Button_Clear.TabIndex = 5;
            this.m_Button_Clear.Text = "Effacer";
            this.m_Button_Clear.UseVisualStyleBackColor = true;
            this.m_Button_Clear.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_Button_Add
            // 
            this.m_Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_Add.Location = new System.Drawing.Point(763, 43);
            this.m_Button_Add.Name = "m_Button_Add";
            this.m_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.m_Button_Add.TabIndex = 6;
            this.m_Button_Add.Text = "Ajouter";
            this.m_Button_Add.UseVisualStyleBackColor = true;
            this.m_Button_Add.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // Add_USB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 366);
            this.Controls.Add(this.m_Button_Add);
            this.Controls.Add(this.m_Button_Clear);
            this.Controls.Add(this.m_Button_valide);
            this.Controls.Add(this.m_Button_Cancel);
            this.Controls.Add(this.m_ListBox_Folder);
            this.Controls.Add(this.m_Label_Folder_Selected);
            this.Controls.Add(this.m_Button_Select_Folder);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Add_USB";
            this.Text = "Ajouter un fichier à sauvgarder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog m_FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button m_Button_Select_Folder;
        private System.Windows.Forms.Label m_Label_Folder_Selected;
        private System.Windows.Forms.ListBox m_ListBox_Folder;
        private System.Windows.Forms.Button m_Button_Cancel;
        private System.Windows.Forms.Button m_Button_valide;
        private System.Windows.Forms.Button m_Button_Clear;
        private System.Windows.Forms.Button m_Button_Add;
    }
}