namespace Save_My_Files_To_USB.Dial
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.m_Label_Title = new System.Windows.Forms.Label();
            this.m_Label_Log = new System.Windows.Forms.Label();
            this.m_Label_Pass = new System.Windows.Forms.Label();
            this.m_TextBox_MDP = new System.Windows.Forms.TextBox();
            this.m_TextBox_Log = new System.Windows.Forms.TextBox();
            this.m_Button_Connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_Label_Title
            // 
            this.m_Label_Title.AutoSize = true;
            this.m_Label_Title.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Title.Location = new System.Drawing.Point(33, 9);
            this.m_Label_Title.Name = "m_Label_Title";
            this.m_Label_Title.Size = new System.Drawing.Size(216, 15);
            this.m_Label_Title.TabIndex = 0;
            this.m_Label_Title.Text = "Connection à l\'espace administrateur";
            // 
            // m_Label_Log
            // 
            this.m_Label_Log.AutoSize = true;
            this.m_Label_Log.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Log.Location = new System.Drawing.Point(33, 54);
            this.m_Label_Log.Name = "m_Label_Log";
            this.m_Label_Log.Size = new System.Drawing.Size(44, 15);
            this.m_Label_Log.TabIndex = 1;
            this.m_Label_Log.Text = "Login :";
            // 
            // m_Label_Pass
            // 
            this.m_Label_Pass.AutoSize = true;
            this.m_Label_Pass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Pass.Location = new System.Drawing.Point(10, 87);
            this.m_Label_Pass.Name = "m_Label_Pass";
            this.m_Label_Pass.Size = new System.Drawing.Size(70, 15);
            this.m_Label_Pass.TabIndex = 2;
            this.m_Label_Pass.Text = "Password :";
            // 
            // m_TextBox_MDP
            // 
            this.m_TextBox_MDP.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TextBox_MDP.Location = new System.Drawing.Point(86, 79);
            this.m_TextBox_MDP.Name = "m_TextBox_MDP";
            this.m_TextBox_MDP.PasswordChar = '*';
            this.m_TextBox_MDP.Size = new System.Drawing.Size(163, 23);
            this.m_TextBox_MDP.TabIndex = 3;
            // 
            // m_TextBox_Log
            // 
            this.m_TextBox_Log.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TextBox_Log.Location = new System.Drawing.Point(86, 46);
            this.m_TextBox_Log.Name = "m_TextBox_Log";
            this.m_TextBox_Log.Size = new System.Drawing.Size(163, 23);
            this.m_TextBox_Log.TabIndex = 4;
            // 
            // m_Button_Connexion
            // 
            this.m_Button_Connexion.BackColor = System.Drawing.Color.LightGray;
            this.m_Button_Connexion.Location = new System.Drawing.Point(174, 108);
            this.m_Button_Connexion.Name = "m_Button_Connexion";
            this.m_Button_Connexion.Size = new System.Drawing.Size(75, 23);
            this.m_Button_Connexion.TabIndex = 5;
            this.m_Button_Connexion.Text = "Connexion";
            this.m_Button_Connexion.UseVisualStyleBackColor = false;
            this.m_Button_Connexion.Click += new System.EventHandler(this.M_Button_Connexion_Click);
            // 
            // Connection
            // 
            this.AcceptButton = this.m_Button_Connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 159);
            this.Controls.Add(this.m_Button_Connexion);
            this.Controls.Add(this.m_TextBox_Log);
            this.Controls.Add(this.m_TextBox_MDP);
            this.Controls.Add(this.m_Label_Pass);
            this.Controls.Add(this.m_Label_Log);
            this.Controls.Add(this.m_Label_Title);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save My Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_Label_Title;
        private System.Windows.Forms.Label m_Label_Log;
        private System.Windows.Forms.Label m_Label_Pass;
        private System.Windows.Forms.TextBox m_TextBox_MDP;
        private System.Windows.Forms.TextBox m_TextBox_Log;
        private System.Windows.Forms.Button m_Button_Connexion;
    }
}