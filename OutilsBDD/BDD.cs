using BiblioSportif;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutilsBDD
{
    public class BDD
    {
        private static MySqlConnection CNX = null;

        private static MySqlConnection createMySqlCnx()
        {
            string chConnexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            return new MySqlConnection(chConnexion);
        }

        public static MySqlDataReader initData() {

            CNX = createMySqlCnx();
            CNX.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif", CNX);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static void deleteData(string id)
        {
            CNX = createMySqlCnx();
            CNX.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Sportif WHERE id = @id", CNX);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void updateData(Sportif unSportif)
        {
            CNX = createMySqlCnx();
            CNX.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE Sportif SET nom = @nom, prenom = @prenom, dateNaissance = @dateNaissance, rue = @rue, codePostal = @codePostal, ville = @ville, niveauExperience = @niveauExperience, idSport = @idSport WHERE id = @id", CNX);
            cmd.Parameters.AddWithValue("@id", unSportif.Id);
            cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
            cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
            cmd.Parameters.AddWithValue("@dateNaissance", unSportif.DateNaissance);
            cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
            cmd.Parameters.AddWithValue("@codePostal", unSportif.CodePostal);
            cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
            cmd.Parameters.AddWithValue("@niveauExperience", unSportif.NiveauExperience);
            cmd.Parameters.AddWithValue("@idSport", unSportif.IdSport);
            cmd.ExecuteNonQuery();
        }

        public static void insertData(Sportif unSportif)
        {
            CNX = createMySqlCnx();
            CNX.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Sportif (nom, prenom, dateNaissance, rue, codePostal, ville, niveauExperience, idSport) VALUES (@nom, @prenom, @dateNaissance, @rue, @codePostal, @ville, @niveauExperience, @idSport)", CNX);
            cmd.Parameters.AddWithValue("@nom", unSportif.Nom);
            cmd.Parameters.AddWithValue("@prenom", unSportif.Prenom);
            cmd.Parameters.AddWithValue("@dateNaissance", unSportif.DateNaissance);
            cmd.Parameters.AddWithValue("@rue", unSportif.Rue);
            cmd.Parameters.AddWithValue("@codePostal", unSportif.CodePostal);
            cmd.Parameters.AddWithValue("@ville", unSportif.Ville);
            cmd.Parameters.AddWithValue("@niveauExperience", unSportif.NiveauExperience);
            cmd.Parameters.AddWithValue("@idSport", unSportif.IdSport);
            cmd.ExecuteNonQuery();
        }

        public static void closeCnx()
        {
            if (CNX != null)
            {
                CNX.Close();
            }
        }
    }
}
