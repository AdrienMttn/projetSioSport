using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSportif
{
    public class Sportif
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string rue;
        private string codePostal;
        private string ville;
        private int niveauExperience;
        private string idSport;

        public Sportif(int id, string nom, string prenom, DateTime dateNaissance, string rue, string codePostal, string ville, int niveauExperience, string idSport)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.niveauExperience = niveauExperience;
            this.idSport = idSport;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Rue { get => rue; set => rue = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }
        public int NiveauExperience { get => niveauExperience; set => niveauExperience = value; }
        public string IdSport { get => idSport; set => idSport = value; }
    }
}
