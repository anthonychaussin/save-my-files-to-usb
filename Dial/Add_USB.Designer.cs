namespace Save_My_Files_To_USB.Dial
{
    partial class Add_USB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_USB));
            this.M_Button_Add_USB = new System.Windows.Forms.Button();
            this.m_ComboBox_Drive_List = new System.Windows.Forms.ComboBox();
            this.m_Button_Refresh = new System.Windows.Forms.Button();
            this.m_GroupBox_Infi = new System.Windows.Forms.GroupBox();
            this.m_Label_Letter = new System.Windows.Forms.Label();
            this.m_Label_Volume_Name = new System.Windows.Forms.Label();
            this.m_Label_Free_Space = new System.Windows.Forms.Label();
            this.m_Label_Space = new System.Windows.Forms.Label();
            this.m_TableLayoutPanel_Info = new System.Windows.Forms.TableLayoutPanel();
            this.m_Label_Letter_Value = new System.Windows.Forms.Label();
            this.m_Label_Volume_Name_Value = new System.Windows.Forms.Label();
            this.m_Label_Free_Space_Value = new System.Windows.Forms.Label();
            this.m_Label_Space_Value = new System.Windows.Forms.Label();
            this.m_Button_Format = new System.Windows.Forms.Button();
            this.m_GroupBox_Infi.SuspendLayout();
            this.m_TableLayoutPanel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // M_Button_Add_USB
            // 
            this.M_Button_Add_USB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.M_Button_Add_USB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Button_Add_USB.Enabled = false;
            this.M_Button_Add_USB.Location = new System.Drawing.Point(387, 143);
            this.M_Button_Add_USB.Name = "M_Button_Add_USB";
            this.M_Button_Add_USB.Size = new System.Drawing.Size(112, 23);
            this.M_Button_Add_USB.TabIndex = 0;
            this.M_Button_Add_USB.Text = "Ajouter la clé";
            this.M_Button_Add_USB.UseVisualStyleBackColor = true;
            this.M_Button_Add_USB.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_ComboBox_Drive_List
            // 
            this.m_ComboBox_Drive_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ComboBox_Drive_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_ComboBox_Drive_List.FormattingEnabled = true;
            this.m_ComboBox_Drive_List.Location = new System.Drawing.Point(12, 12);
            this.m_ComboBox_Drive_List.Name = "m_ComboBox_Drive_List";
            this.m_ComboBox_Drive_List.Size = new System.Drawing.Size(455, 23);
            this.m_ComboBox_Drive_List.TabIndex = 1;
            this.m_ComboBox_Drive_List.SelectedIndexChanged += new System.EventHandler(this.M_ComboBox_Drive_List_SelectedIndexChanged);
            // 
            // m_Button_Refresh
            // 
            this.m_Button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_Button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.m_Button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_Button_Refresh.FlatAppearance.BorderSize = 0;
            this.m_Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Button_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("m_Button_Refresh.Image")));
            this.m_Button_Refresh.Location = new System.Drawing.Point(473, 10);
            this.m_Button_Refresh.Name = "m_Button_Refresh";
            this.m_Button_Refresh.Size = new System.Drawing.Size(26, 26);
            this.m_Button_Refresh.TabIndex = 2;
            this.m_Button_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.m_Button_Refresh.UseVisualStyleBackColor = false;
            this.m_Button_Refresh.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // m_GroupBox_Infi
            // 
            this.m_GroupBox_Infi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_GroupBox_Infi.Controls.Add(this.m_TableLayoutPanel_Info);
            this.m_GroupBox_Infi.Location = new System.Drawing.Point(14, 41);
            this.m_GroupBox_Infi.Name = "m_GroupBox_Infi";
            this.m_GroupBox_Infi.Size = new System.Drawing.Size(352, 124);
            this.m_GroupBox_Infi.TabIndex = 3;
            this.m_GroupBox_Infi.TabStop = false;
            this.m_GroupBox_Infi.Text = "Informations";
            // 
            // m_Label_Letter
            // 
            this.m_Label_Letter.AutoSize = true;
            this.m_Label_Letter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Letter.Location = new System.Drawing.Point(1, 1);
            this.m_Label_Letter.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Letter.Name = "m_Label_Letter";
            this.m_Label_Letter.Size = new System.Drawing.Size(106, 23);
            this.m_Label_Letter.TabIndex = 4;
            this.m_Label_Letter.Text = "Lettre du lecteur :";
            this.m_Label_Letter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Volume_Name
            // 
            this.m_Label_Volume_Name.AutoSize = true;
            this.m_Label_Volume_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Volume_Name.Location = new System.Drawing.Point(1, 26);
            this.m_Label_Volume_Name.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Volume_Name.Name = "m_Label_Volume_Name";
            this.m_Label_Volume_Name.Size = new System.Drawing.Size(106, 23);
            this.m_Label_Volume_Name.TabIndex = 5;
            this.m_Label_Volume_Name.Text = "Nom du volume :";
            this.m_Label_Volume_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Free_Space
            // 
            this.m_Label_Free_Space.AutoSize = true;
            this.m_Label_Free_Space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Free_Space.Location = new System.Drawing.Point(1, 51);
            this.m_Label_Free_Space.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Free_Space.Name = "m_Label_Free_Space";
            this.m_Label_Free_Space.Size = new System.Drawing.Size(106, 23);
            this.m_Label_Free_Space.TabIndex = 6;
            this.m_Label_Free_Space.Text = "Espace libre :";
            this.m_Label_Free_Space.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Space
            // 
            this.m_Label_Space.AutoSize = true;
            this.m_Label_Space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Space.Location = new System.Drawing.Point(1, 76);
            this.m_Label_Space.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Space.Name = "m_Label_Space";
            this.m_Label_Space.Size = new System.Drawing.Size(106, 25);
            this.m_Label_Space.TabIndex = 7;
            this.m_Label_Space.Text = "Espace total :";
            this.m_Label_Space.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_TableLayoutPanel_Info
            // 
            this.m_TableLayoutPanel_Info.ColumnCount = 2;
            this.m_TableLayoutPanel_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.47059F));
            this.m_TableLayoutPanel_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.52941F));
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Space_Value, 1, 3);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Free_Space_Value, 1, 2);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Volume_Name_Value, 1, 1);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Letter, 0, 0);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Space, 0, 3);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Volume_Name, 0, 1);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Free_Space, 0, 2);
            this.m_TableLayoutPanel_Info.Controls.Add(this.m_Label_Letter_Value, 1, 0);
            this.m_TableLayoutPanel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_TableLayoutPanel_Info.Location = new System.Drawing.Point(3, 19);
            this.m_TableLayoutPanel_Info.Name = "m_TableLayoutPanel_Info";
            this.m_TableLayoutPanel_Info.RowCount = 4;
            this.m_TableLayoutPanel_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.m_TableLayoutPanel_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.m_TableLayoutPanel_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.m_TableLayoutPanel_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.m_TableLayoutPanel_Info.Size = new System.Drawing.Size(346, 102);
            this.m_TableLayoutPanel_Info.TabIndex = 9;
            // 
            // m_Label_Letter_Value
            // 
            this.m_Label_Letter_Value.AutoSize = true;
            this.m_Label_Letter_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_Label_Letter_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Letter_Value.Location = new System.Drawing.Point(109, 1);
            this.m_Label_Letter_Value.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Letter_Value.Name = "m_Label_Letter_Value";
            this.m_Label_Letter_Value.Size = new System.Drawing.Size(236, 23);
            this.m_Label_Letter_Value.TabIndex = 8;
            this.m_Label_Letter_Value.Text = "...";
            this.m_Label_Letter_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Volume_Name_Value
            // 
            this.m_Label_Volume_Name_Value.AutoSize = true;
            this.m_Label_Volume_Name_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_Label_Volume_Name_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Volume_Name_Value.Location = new System.Drawing.Point(109, 26);
            this.m_Label_Volume_Name_Value.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Volume_Name_Value.Name = "m_Label_Volume_Name_Value";
            this.m_Label_Volume_Name_Value.Size = new System.Drawing.Size(236, 23);
            this.m_Label_Volume_Name_Value.TabIndex = 9;
            this.m_Label_Volume_Name_Value.Text = "...";
            this.m_Label_Volume_Name_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Free_Space_Value
            // 
            this.m_Label_Free_Space_Value.AutoSize = true;
            this.m_Label_Free_Space_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_Label_Free_Space_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Free_Space_Value.Location = new System.Drawing.Point(109, 51);
            this.m_Label_Free_Space_Value.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Free_Space_Value.Name = "m_Label_Free_Space_Value";
            this.m_Label_Free_Space_Value.Size = new System.Drawing.Size(236, 23);
            this.m_Label_Free_Space_Value.TabIndex = 10;
            this.m_Label_Free_Space_Value.Text = "...";
            this.m_Label_Free_Space_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Label_Space_Value
            // 
            this.m_Label_Space_Value.AutoSize = true;
            this.m_Label_Space_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_Label_Space_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Label_Space_Value.Location = new System.Drawing.Point(109, 76);
            this.m_Label_Space_Value.Margin = new System.Windows.Forms.Padding(1);
            this.m_Label_Space_Value.Name = "m_Label_Space_Value";
            this.m_Label_Space_Value.Size = new System.Drawing.Size(236, 25);
            this.m_Label_Space_Value.TabIndex = 11;
            this.m_Label_Space_Value.Text = "...";
            this.m_Label_Space_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_Button_Format
            // 
            this.m_Button_Format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Button_Format.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_Button_Format.Enabled = false;
            this.m_Button_Format.Location = new System.Drawing.Point(387, 111);
            this.m_Button_Format.Name = "m_Button_Format";
            this.m_Button_Format.Size = new System.Drawing.Size(112, 23);
            this.m_Button_Format.TabIndex = 4;
            this.m_Button_Format.Text = "Formater la clé";
            this.m_Button_Format.UseVisualStyleBackColor = true;
            this.m_Button_Format.Click += new System.EventHandler(this.M_Button_Click);
            // 
            // Add_USB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 178);
            this.Controls.Add(this.m_Button_Format);
            this.Controls.Add(this.m_GroupBox_Infi);
            this.Controls.Add(this.m_Button_Refresh);
            this.Controls.Add(this.m_ComboBox_Drive_List);
            this.Controls.Add(this.M_Button_Add_USB);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Add_USB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une nouvelle clé USB";
            this.Load += new System.EventHandler(this.Add_USB_Load);
            this.m_GroupBox_Infi.ResumeLayout(false);
            this.m_TableLayoutPanel_Info.ResumeLayout(false);
            this.m_TableLayoutPanel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button M_Button_Add_USB;
        private System.Windows.Forms.ComboBox m_ComboBox_Drive_List;
        private System.Windows.Forms.Button m_Button_Refresh;
        private System.Windows.Forms.GroupBox m_GroupBox_Infi;
        private System.Windows.Forms.Label m_Label_Letter;
        private System.Windows.Forms.Label m_Label_Volume_Name;
        private System.Windows.Forms.Label m_Label_Free_Space;
        private System.Windows.Forms.Label m_Label_Space;
        private System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel_Info;
        private System.Windows.Forms.Label m_Label_Space_Value;
        private System.Windows.Forms.Label m_Label_Free_Space_Value;
        private System.Windows.Forms.Label m_Label_Volume_Name_Value;
        private System.Windows.Forms.Label m_Label_Letter_Value;
        private System.Windows.Forms.Button m_Button_Format;
    }
}