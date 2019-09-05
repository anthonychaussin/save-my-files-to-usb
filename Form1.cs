using Save_My_Files_To_USB.Dial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_My_Files_To_USB
{
    /// <summary>
    /// Formulaire principal
    /// </summary>
    public partial class Form1 : Form
    {
        #region Member ---------------------------------------------------------------------------
        #endregion Member ---------------------------------------------------------------------------

        #region Properties ---------------------------------------------------------------------------
        #endregion Properties ---------------------------------------------------------------------------

        #region Function --------------------------------------------------------------------------------
        #region Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Affiche le fichier d'aide
        /// </summary>
        public void Call_Help()
        {

        }
        /// <summary>
        /// Affiche le form de connection d'admin
        /// </summary>
        public void Connect_Admin()
        {
            Connection l_form = new Connection();
            l_form.ShowDialog();
            /*if (Check_Admin(l_form.M_s_Login, l_form.M_s_Password))
            {

            }*/
        }
        /// <summary>
        /// Ouvre la clé USB
        /// </summary>
        public void Open_USB_Key()
        {

        }
        /// <summary>
        /// Ouvre le formulaire d'ajout de répertoir
        /// </summary>
        public void Add_Repository()
        {
            Add_Folder l_Form = new Add_Folder();
            l_Form.ShowDialog();
            m_CheckedListBox.Items.AddRange(l_Form.M_Folder_List.ToArray());
        }
        /// <summary>
        /// Ouvre le formulaire d'ajout de clé usb
        /// </summary>
        public void Add_USB()
        {
            Add_USB l_Form = new Add_USB();
            l_Form.ShowDialog();
        }
        /// <summary>
        /// Lance le threat de sauvgarde
        /// </summary>
        public void Save_Files()
        {

        }
        #endregion Function --------------------------------------------------------------------------------

        #region Event ---------------------------------------------------------------------------------------
        /// <summary>
        /// Actions liée à l'appuie sur un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender == m_Button_Add_Repository)
                Add_Repository();
            else if (sender == m_Button_Add_USB)
                Add_USB();
            else if (sender == m_Button_Save)
                Save_Files();
        }
        /// <summary>
        /// Actions liées à l'appuis sur un lien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel_Click(object sender, EventArgs e)
        {
            if (sender == m_LinkLabel_Help)
                Call_Help();
            else if (sender == m_LinkLabel_User || sender == m_PictureBox_User)
                Connect_Admin();
            else if (sender == m_LinkLabel_USB_Path)
                Open_USB_Key();
        }
        #endregion Event ---------------------------------------------------------------------------------------
        /// <summary>
        /// Chargement du controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.First_Time)
                Properties.Settings.Default.First_Time = !Properties.Settings.Default.First_Time;
        }
    }
}
