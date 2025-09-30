using BiblioSportif;
using OutilsBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSportSio
{
    public partial class Modif_Add : Form
    {
        int mode = 0; // 0 = ajout, 1 = modif
        int idSportif = 0;

        private void closeForm()
        {
            SportSio frmSportSio = new SportSio();
            frmSportSio.MdiParent = this.MdiParent;
            frmSportSio.Dock = DockStyle.Fill;
            frmSportSio.StartPosition = FormStartPosition.Manual;
            frmSportSio.Location = new Point(0, 0);
            frmSportSio.Show();
            this.Close();
        }
        public Modif_Add()
        {
            InitializeComponent();
            titre.Text = "Ajout d'un nouveau sportif";
            mode = 0;
        }

        public Modif_Add(Sportif unSportif)
        {
            InitializeComponent();
            mode = 1;
            idSportif = unSportif.Id;
            titre.Text = $"Modification du sportif : {unSportif.Nom} {unSportif.Prenom}";
            txtName.Text = unSportif.Nom;
            txtPren.Text = unSportif.Prenom;
            dateTNaiss.Text = unSportif.DateNaissance.ToString();
            txtAdress.Text = unSportif.Rue;
            txtCp.Text = unSportif.CodePostal;
            txtVille.Text = unSportif.Ville;
            txtNiv.Text = unSportif.NiveauExperience.ToString();
            txtNomSport.Text = unSportif.IdSport;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Modif_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Adresse_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    BDD.updateData(new Sportif(idSportif, txtName.Text, txtPren.Text, DateTime.Parse(dateTNaiss.Text), txtAdress.Text, txtCp.Text, txtVille.Text, int.Parse(txtNiv.Text), txtNomSport.Text));
                    BDD.closeCnx();
                    closeForm();
                    break;
            }
        }
    }
}
