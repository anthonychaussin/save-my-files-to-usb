using System;
using System.Windows.Forms;

namespace Save_My_Files_To_USB.Dial
{
    /// <summary>
    /// Formulaire de connexion
    /// </summary>
    public partial class Connection : Form
    {
        /// <summary>
        /// Login
        /// </summary>
        public string M_s_Login { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string M_s_Password { get; set; }
        /// <summary>
        /// Constructeur
        /// </summary>
        public Connection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clique sur un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M_Button_Connexion_Click(object sender, EventArgs e)
        {
            M_s_Login = m_Label_Log.Text;
            M_s_Password = m_Label_Pass.Text;
            Close();
        }
    }
}
