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

        public static void closeCnx()
        {
            if (CNX != null)
            {
                CNX.Close();
            }
        }
    }
}
