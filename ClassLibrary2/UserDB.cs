
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDB
    {
        public MySqlDataReader reader1;
        string connectionString = null;
        MySqlConnection cnn;
        MySqlCommand comand = new MySqlCommand();

        public UserDB()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "teatru1");
            cnn = new MySqlConnection(connectionString);
        }

        
        ///Check User DB

        public string checkUser(string login, string pass)
        {

            string u = "";
            try
            {
                String sql = "SELECT `Rol` from teatru1.user WHERE User='" + login + "' AND Password='" + pass + "'";
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = reader["Rol"].ToString();
                    
                    
                }
                else {
                    u = "Nu exista asa User";
                
                
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                cnn.Close();

            }

            return u;
        }


        ///// Inscriere angajat 
        public void inscriereAngajatDB( string login, string pass, string nume, string rol ){
            String sql = "INSERT into user (User, Password, Nume, rol ) values ("
                            + login + "," + pass + "," + nume + "," + rol + ")";
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


        ////Extragere User din DB

        public string[] extrageUser(string login, string pass) {

            string[] user = new string[]{};
            try
            {
                String sql = "SELECT User, Password, Nume, Rol from teatru1.user WHERE User='" + login + "' AND Password='" + pass + "'";
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows) {
                    user[0] = reader1["User"].ToString();
                    user[1] = reader1["Password"].ToString();
                    user[2] = reader1["Nume"].ToString();
                    user[3] = reader1["Rol"].ToString();
               
                
                }
                cnn.Close();
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                cnn.Close();

            }

            return user;
        
        
        
        }







        //Inscriere parola noua

        public void inscriereParolaNoua(string login, string pass)
        {
            String sql1 = "UPDATE teatru1.user SET Parola ='" + pass + "' where User='" + login + "' ";
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(sql1, cnn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                cnn.Close();

            }
        }
    }
}
