using BiblioSportif;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using OutilsBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appSportSio
{
    public partial class SportSio : Form
    {
        List<Sportif> sportifs;
        List<Sportif> filteredSportifs;
        public SportSio()
        {
            InitializeComponent();
            initValue();
        }

        private void initValue()
        {
            MySqlDataReader reader = BDD.initData();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);
                listSportif.Columns.Add(columnName);
                filterSelect.Items.Add(columnName);
            }
            listSportif.FullRowSelect = true;
            listSportif.GridLines = true;
            listSportif.AllowColumnReorder = true;
            initListSportif(reader); 
        }

        private void filter()
        {
            string query = searchInput.Text.ToLower();
            if (query != "")
            {
                switch (filterSelect.Text)
                {
                    case "id":
                        filteredSportifs = sportifs.Where(sportif => sportif.Id.ToString().Contains(query)).ToList();
                        break;
                    case "nom":
                        filteredSportifs = sportifs.Where(sportif => sportif.Nom.ToLower().Contains(query)).ToList();
                        break;
                    case "prenom":
                        filteredSportifs = sportifs.Where(sportif => sportif.Prenom.ToLower().Contains(query)).ToList();
                        break;
                    case "dateNaissance":
                        filteredSportifs = sportifs.Where(sportif => sportif.DateNaissance.ToString("yyyy-MM-dd").ToLower().Contains(query)).ToList();
                        break;
                    case "rue":
                        filteredSportifs = sportifs.Where(sportif => sportif.Rue.ToLower().Contains(query)).ToList();
                        break;
                    case "codePostal":
                        filteredSportifs = sportifs.Where(sportif => sportif.CodePostal.ToLower().Contains(query)).ToList();
                        break;
                    case "ville":
                        filteredSportifs = sportifs.Where(sportif => sportif.Ville.ToLower().Contains(query)).ToList();
                        break;
                    case "niveauExperience":
                        filteredSportifs = sportifs.Where(sportif => sportif.NiveauExperience.ToString() == query).ToList();
                        break;
                    case "idSport":
                        filteredSportifs = sportifs.Where(sportif => sportif.IdSport.ToLower().Contains(query)).ToList();
                        break;
                    default:
                        filteredSportifs = sportifs.Where(sportif => sportif.Nom.ToLower().Contains(query) ||
                           sportif.Prenom.ToLower().Contains(query) ||
                           sportif.Id.ToString().Contains(query) ||
                           sportif.DateNaissance.ToString("yyyy-MM-dd").ToLower().Contains(query) ||
                           sportif.Rue.ToLower().Contains(query) ||
                           sportif.CodePostal.ToLower().Contains(query) ||
                           sportif.Ville.ToLower().Contains(query) ||
                           sportif.NiveauExperience.ToString() == query ||
                           sportif.IdSport.ToLower().Contains(query)
                       ).ToList();
                        break;
                }
            }
            else
            {
                filteredSportifs = sportifs;
            }
            
            initSportifViewList(filteredSportifs);
        }

        private void Delete()
        {
            ListViewItem item = listSportif.SelectedItems[0];
            DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer : { item.SubItems[1].Text} {item.SubItems[2].Text}", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                BDD.deleteData(item.Text);
                BDD.closeCnx();
                sportifs = sportifs.Where(sportif => sportif.Id.ToString() != listSportif.SelectedItems[0].Text).ToList();
                filter();
            }
        }

        private void initListSportif(MySqlDataReader reader) {
            sportifs = new List<Sportif>();
            filteredSportifs = new List<Sportif>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nom = Convert.ToString(reader["nom"]);
                string prenom = Convert.ToString(reader["prenom"]);
                DateTime dateNaissanse = Convert.ToDateTime(reader["dateNaissance"]);
                string rue = Convert.ToString(reader["rue"]);
                string codePostal = Convert.ToString(reader["codePostal"]);
                string ville = Convert.ToString(reader["ville"]);
                int niveauExperience = Convert.ToInt32(reader["niveauExperience"]);
                string idSport = Convert.ToString(reader["idSport"]);
                sportifs.Add(new Sportif(id, nom, prenom, dateNaissanse, rue, codePostal, ville, niveauExperience, idSport));
                filteredSportifs.Add(new Sportif(id, nom, prenom, dateNaissanse, rue, codePostal, ville, niveauExperience, idSport));
            }
            reader.Close();
            BDD.closeCnx();
            initSportifViewList(filteredSportifs);
            
        }
        private void initSportifViewList(List<Sportif> lesSportifs)
        {
            listSportif.Items.Clear();
            foreach (Sportif s in lesSportifs)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(s.Id), s.Nom);
                item.SubItems.Add(s.Nom);
                item.SubItems.Add(s.Prenom);
                item.SubItems.Add(s.DateNaissance.ToString("yyyy-MM-dd"));
                item.SubItems.Add(s.Rue);
                item.SubItems.Add(s.CodePostal);
                item.SubItems.Add(s.Ville);
                item.SubItems.Add(Convert.ToString(s.NiveauExperience));
                item.SubItems.Add(s.IdSport);
                listSportif.Items.Add(item);
            }
            foreach (ColumnHeader col in listSportif.Columns)
            {
                col.Width = -2; // -2 = ajuste à la taille du contenu
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void listSportif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listSportif_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editSportif.Show(Cursor.Position);
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Delete();
        }

        private void listSportif_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void filterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void SportSio_Load(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sportifToEdit = sportifs.Where(sportif => sportif.Id.ToString() == listSportif.SelectedItems[0].SubItems[0].Text).ToList()[0];
            Modif_Add modifAdd = new Modif_Add((Sportif)sportifToEdit);
            modifAdd.MdiParent = this.MdiParent;
            modifAdd.StartPosition = FormStartPosition.Manual;
            modifAdd.Location = new Point(0, 0);
            modifAdd.Dock = DockStyle.Fill;
            modifAdd.Show();
            this.Close();
        }
    }
}
