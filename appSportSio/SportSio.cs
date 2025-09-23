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
        private MySqlConnection createMySqlCnx()
        {
            string chConnexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            return new MySqlConnection(chConnexion);
        }
        public SportSio()
        {
            InitializeComponent();
            initValue();
        }

        private void initValue()
        {
            
            //MySqlConnection cnx = createMySqlCnx();
            MySqlConnection cnx = BDD.createMySqlCnx();
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif", cnx);
            MySqlDataReader reader = cmd.ExecuteReader();
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
            cnx.Close();
        }

        private void filter()
        {
            string query = searchInput.Text.ToLower();
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
            initSportifViewList(filteredSportifs);
        }

        private void Delete()
        {
            MySqlConnection cnx = createMySqlCnx();
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Sportif WHERE id = @id", cnx);
            cmd.Parameters.AddWithValue("@id", listSportif.SelectedItems[0].Text);
            cmd.ExecuteNonQuery();
            cnx.Close();
            sportifs = sportifs.Where(sportif => sportif.Id.ToString() != listSportif.SelectedItems[0].Text).ToList();
            filter();
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
    }
}
