using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_My_Files_To_USB.Dial
{
    public partial class Add_Folder : Form
    {
        #region Member ---------------------------------------------------------------------------
        #endregion Member ---------------------------------------------------------------------------

        #region Properties ---------------------------------------------------------------------------
        public List<String> M_Folder_List { get; set; }
        #endregion Properties ---------------------------------------------------------------------------

        #region Function --------------------------------------------------------------------------------
        #region Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur
        /// </summary>
        public Add_Folder()
        {
            InitializeComponent();
            M_Folder_List = new List<string>();
        }
        #endregion Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Ajoute le nom du ficher au label pour voir la sélection
        /// </summary>
        /// <param name="a_DialogResult">Résultat de la boite de dialogue de sélection des dossiers</param>
        private void Put_Folder_To_Label(DialogResult a_DialogResult)
        {
            m_Label_Folder_Selected.Text = Get_Selected_Folder();
        }
        /// <summary>
        /// Récupère le chemin du fichier sélectionné
        /// </summary>
        /// <returns>Retourn le <see cref="string"/> du dossier sélectionné</returns>
        private string Get_Selected_Folder()
        {
            return m_FolderBrowserDialog.SelectedPath;
        }
        /// <summary>
        /// Réinitialise la sélection des fichiers
        /// </summary>
        private void Clear_Selected_Folder()
        {
            m_FolderBrowserDialog.SelectedPath = null;
            m_Label_Folder_Selected.Text = "...";
        }
        /// <summary>
        /// Ajoute un dossier à <see cref="m_ListBox_Folder"/> et à <see cref="M_Folder_List"/>
        /// </summary>
        private void Add_Folder_To_List()
        {
            m_ListBox_Folder.Items.Add(Get_Selected_Folder());
            M_Folder_List.Add(Get_Selected_Folder());
            Clear_Selected_Folder();
        }
        /// <summary>
        /// Supprime toutes les listes de sélection
        /// </summary>
        private void Clear_All_List()
        {
            if(M_Folder_List.Count > 0)
            {
                M_Folder_List.Clear();
                m_ListBox_Folder.Items.Clear();
                Clear_Selected_Folder();
            }
            else { MessageBox.Show("Aucun élément à supprimer."); }
        }
        /// <summary>
        /// Quitte le dialogue en vérifiant s'il n'y a pas de données non enregistrer
        /// </summary>
        private void Leave_Form()
        {
            if(!String.IsNullOrEmpty(this.Get_Selected_Folder()))
            {
                DialogResult l_DialogResult = MessageBox.Show("Attention ! Vous n'avez pas ajouter le dernier dossier sélectionné. Voulez-vous l'ajouter à la liste avant de fermer ?", "Quitter sans enregistrer le dernier ajout ?", MessageBoxButtons.YesNo);
                if(l_DialogResult == DialogResult.Yes)
                {
                    Add_Folder_To_List();
                }
            }
            this.Close();
        }
        #endregion Function --------------------------------------------------------------------------------

        #region Event ---------------------------------------------------------------------------------------
        /// <summary>
        /// Se déclanche au clique sur un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M_Button_Click(object sender, EventArgs e)
        {
            if (sender == m_Button_Add)
            {
                Add_Folder_To_List();
            }
            else if (sender == m_Button_Cancel)
            {
                this.Leave_Form();
            }
            else if (sender == m_Button_Clear)
            {
                Clear_All_List();
            }
            else if (sender == m_Button_Select_Folder)
            {
                this.Put_Folder_To_Label(this.m_FolderBrowserDialog.ShowDialog());
            }
            else if (sender == m_Button_valide)
            {
                this.Leave_Form();
            }
            else
            {
                throw new ArgumentException("Une erreure inconue c'est produite. Aucune action n'est associée");
            }
        }
        #endregion Event ---------------------------------------------------------------------------------------
    }
}
