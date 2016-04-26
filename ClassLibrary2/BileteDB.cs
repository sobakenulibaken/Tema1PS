using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BileteDB
    {
        string connectionString = null;
        MySqlConnection cnn;
        MySqlCommand comand = new MySqlCommand();

        public BileteDB()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "teatru1");
            cnn = new MySqlConnection(connectionString);
        }
        /////Inscriere bilete in baza de date

        public string inscriereBilet(int idSpec, int rand, int loc ) {
            String sql = "INSERT into bilet( Rand, Numar, idSpec ) values ("
                            + rand + "," + loc + "," + idSpec + ")";
            String sql1 = "UPDATE teatru1.spectacol SET NumarBilet = NumarBilet - 1 WHERE idSpectacol = 1 and NumarBilet >0 ";
            String checkString="Inexistent";
            String check = "Select * from teatru1.bilet where Rand = '"+ rand+"' and Numar ='"+loc+"' and idSpec='"+idSpec+"'";
            try
            {
                cnn.Open();
                MySqlCommand cmd3 = new MySqlCommand(check, cnn);
                MySqlDataReader reader = cmd3.ExecuteReader();
                reader.Read();
                if (reader.HasRows){
                    checkString = reader.ToString();
                }
                cnn.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                cnn.Close();

            }

            if (!checkString.Equals("Inexistent"))
            {

                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, cnn);
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand cmd1 = new MySqlCommand(sql1, cnn);
                    cnn.Close();
                }

                catch (Exception s)
                {

                    Console.WriteLine(s.Message);
                    cnn.Close();

                }
            }
            else {
                checkString = "Existent";
            
            }

            return checkString;
        }



    }
}
