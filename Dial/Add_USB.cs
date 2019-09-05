using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_My_Files_To_USB.Dial
{
    public partial class Add_USB : Form
    {
        #region Member ---------------------------------------------------------------------------
        #endregion Member ---------------------------------------------------------------------------

        #region Properties ---------------------------------------------------------------------------
        public List<DriveInfo> M_li_DriveInfo { get; set; }
        public List<String> M_li_DriveName
        {
            get
            {
                List<String> l_li_DriveName = new List<string>();
                foreach (DriveInfo l_DriveInfo in M_li_DriveInfo)
                {
                    l_li_DriveName.Add(l_DriveInfo.Name + " " + l_DriveInfo.VolumeLabel);
                }
                return l_li_DriveName;
            }
        }
        public DriveInfo M_DriveInfo { get; set; }
        #endregion Properties ---------------------------------------------------------------------------

        #region Function --------------------------------------------------------------------------------
        #region Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur
        /// </summary>
        public Add_USB()
        {
            InitializeComponent();
        }
        #endregion Constructor --------------------------------------------------------------------------------
        /// <summary>
        /// Charge les éléments du controle
        /// </summary>
        private void Loader()
        {
            M_li_DriveInfo = DriveInfo.GetDrives().ToList<DriveInfo>();
            M_li_DriveInfo.RemoveAll(x => !x.IsReady || x.DriveType != DriveType.Removable);
            this.Update_ComboList();
        }
        /// <summary>
        /// Met à jour la liste des drives présent dans le combobox
        /// </summary>
        private void Update_ComboList()
        {
            m_ComboBox_Drive_List.Items.Clear();
            m_ComboBox_Drive_List.Items.AddRange(M_li_DriveName.ToArray());
        }
        /// <summary>
        /// Met à jour la clé USB sélectionné
        /// </summary>
        private void Update_Selected_Drive()
        {
            M_DriveInfo = M_li_DriveInfo[m_ComboBox_Drive_List.SelectedIndex];
        }
        /// <summary>
        /// Met à jour les informations affichés à l'utilisateur
        /// </summary>
        private void Update_Labels_Drive_Infos()
        {
            m_Label_Free_Space_Value.Text = Make_Storage_Unite_Lisible(M_DriveInfo.AvailableFreeSpace);
            m_Label_Letter_Value.Text = M_DriveInfo.Name;
            m_Label_Space_Value.Text = Make_Storage_Unite_Lisible(M_DriveInfo.TotalSize);
            m_Label_Volume_Name_Value.Text = M_DriveInfo.VolumeLabel;

        }
        public static bool IsFileSystemValid(string fileSystem)
        {
            if (fileSystem == null)
            {
                return false;
            }

            switch (fileSystem)
            {
                case "FAT":
                case "FAT32":
                case "EXFAT":
                case "NTFS":
                case "UDF":
                    return true;
                default:
                    return false;
            }
        }
        private void Format_Drive()
        {
            Char l_c_Letter = M_DriveInfo.Name.ToList<Char>()[0];
            String fileSystem = M_DriveInfo.DriveFormat;
            if (MessageBox.Show("Attention ! Cette action est irréverssible !" + "\n\n" +
                "Cette action va supprimer toutes les données sur le volume sélectionné.\n\n" +
                "Etes-vous sûr de vouloir supprimer toutes ces données ?\n\n"
                , "Attention action irréverssible !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!Char.IsLetter(l_c_Letter) || !IsFileSystemValid(fileSystem))
                {
                    MessageBox.Show("Le formatage à échoué à cause d'une erreure logiciel. Raison : Fichier système invalide");
                }
                string drive = l_c_Letter + ":";
                try
                {
                    var di = new DriveInfo(drive);
                    var psi = new ProcessStartInfo();
                    psi.FileName = "format.com";
                    psi.WorkingDirectory = Environment.SystemDirectory;
                    psi.Arguments = "/FS:" + fileSystem +
                                                 " /Y" +
                                                 " /V:" + M_DriveInfo.VolumeLabel +
                                                 " /Q" +
                                                 " /A:8192" +
                                                 " " + drive;
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardInput = true;
                    var formatProcess = Process.Start(psi);
                    var swStandardInput = formatProcess.StandardInput;
                    swStandardInput.WriteLine();
                    formatProcess.WaitForExit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void Ennable_Button()
        {
            if(m_ComboBox_Drive_List.SelectedIndex >= 0)
            {
                M_Button_Add_USB.Enabled = true;
                m_Button_Format.Enabled = true;
            }
            else
            {
                M_Button_Add_USB.Enabled = false;
                m_Button_Format.Enabled = false;
            }
        }
        /// <summary>
        /// Convertie une valeur en octet en valeur adapté à la lisibilité utilisateur de précision 000,00 Xo
        /// </summary>
        /// <param name="a_bi_Storage_Volume">Valeur en octet à convertir</param>
        /// <returns>Chaine de charactère comprenant la valeur avec l'unité adaptée suivi de l'unité</returns>
        private String Make_Storage_Unite_Lisible(Int64 a_bi_Storage_Volume)
        {
            string l_s_Storage_volume = "";
            long l_bi_Length = a_bi_Storage_Volume.ToString().Length;
            if (l_bi_Length <= 3)
                l_s_Storage_volume = a_bi_Storage_Volume + " o";
            else if (l_bi_Length >= 3 && l_bi_Length <= 6)
                l_s_Storage_volume = ((a_bi_Storage_Volume + 0.0) / 1000).ToString("### ###.##") + " Ko";
            else if (l_bi_Length >= 6 && l_bi_Length <= 9)
                l_s_Storage_volume = ((a_bi_Storage_Volume + 0.0) / Math.Pow(1000,2)).ToString("### ###.##") + " Mo";
            else if (l_bi_Length >= 9 && l_bi_Length <= 12)
                l_s_Storage_volume = ((a_bi_Storage_Volume + 0.0) / Math.Pow(1000, 3)).ToString("### ###.##") + " Go";
            else if (l_bi_Length >= 12 && l_bi_Length <= 15)
                l_s_Storage_volume = ((a_bi_Storage_Volume + 0.0) / Math.Pow(1000, 4)).ToString("### ###.##") + " To";
            else if (l_bi_Length >= 15 && l_bi_Length <= 18)
                l_s_Storage_volume = ((a_bi_Storage_Volume + 0.0) / Math.Pow(1000, 5)).ToString("### ###.##") + " Po";
            return l_s_Storage_volume;
        }
        #endregion Function --------------------------------------------------------------------------------

        #region Event ---------------------------------------------------------------------------------------

        #endregion Event ---------------------------------------------------------------------------------------
        /// <summary>
        /// Activé au chargement du controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_USB_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Loader();
            Cursor = Cursors.Default;
        }
        /// <summary>
        /// Activé au clique sur un bouton du controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M_Button_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (sender == m_Button_Refresh)
            {
                Loader();
                Update_Selected_Drive();
                Update_Labels_Drive_Infos();
                Ennable_Button();
            }
            else if(sender == M_Button_Add_USB)
            {
                Close();
            }
            else if(sender == m_Button_Format)
            {
                Format_Drive();
                Update_Selected_Drive();
                Update_Labels_Drive_Infos();
                Ennable_Button();

            }
            Cursor = Cursors.Default;
        }
        /// <summary>
        /// Activé au changement de l'item sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M_ComboBox_Drive_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Update_Selected_Drive();
            Update_Labels_Drive_Infos();
            Ennable_Button();
            Cursor = Cursors.Default;
        }
    }
}
