using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SpectacolDB
    {
         string connectionString = null;
        MySqlConnection cnn;
        MySqlCommand comand = new MySqlCommand();
        MySqlDataAdapter sda;
        public SpectacolDB()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "teatru1");
            cnn = new MySqlConnection(connectionString);
        }
        
        /// Iscriere Spectacol in DB
        public void inscriereSpectacolDB(string titlu, string regie, string distributia, int nrBilete, DateTime dataPrimiera)
        {
            String sql = "INSERT into spectacol(Titlu, Regia, DataPriemiera, NumarBilet ) values ("
                            + titlu + "," + regie + "," + nrBilete + "," + dataPrimiera.ToString() + ")";

            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                cnn.Close();
            }

            catch (Exception s) 
            { 
         
                Console.WriteLine(s.Message);
                cnn.Close();

            }


        }
        
        ///Extrag Lista Spectacole
        ///
        public DataTable viewSpectacolDB()
        {
            DataTable dt = new DataTable();
           
            try
            {
                cnn.Open();
                 sda= new MySqlDataAdapter("SELECT idSpectacol, Titlu , Regia , Distributia , DataPremiera , NumarBilet  FROM teatru1.spectacol ", cnn);

                sda.Fill(dt);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                cnn.Close();
                return null;
            }

            return dt;
        }

    }
}
