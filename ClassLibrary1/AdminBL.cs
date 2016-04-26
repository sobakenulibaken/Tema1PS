using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Security.Cryptography;
using System.Data;
using System.IO;

namespace BL_Layer
{
    public class AdminBL
    {

       
        private UserDB user = new UserDB();

        public AdminBL( ) {
      
        }

        public AngajatBL creareAngjatNou(string log, string pass, string name, string role) {
            AngajatBL angajat = new AngajatBL ( log,  getMd5Hash(pass), name, role);
           
            //Inscriere angajat in DB
            user.inscriereAngajatDB(angajat.login, angajat.parola,angajat.nume,angajat.rol);
            return angajat;
        }

        

      public string checkExistUser(string login, string parola) {
        
            //Check angajat in DB
            string rol = user.checkUser(login, parola);

            return rol;
        }

        public  SpectacolBL inscriereSpectacol(string titlu, string regie , string distributia, int nrBilete, DateTime dataPrimiera ) {

            SpectacolBL spc = new SpectacolBL(titlu, regie, distributia, nrBilete, dataPrimiera);
            
            //Inscriere in DB
            SpectacolDB admin = new SpectacolDB();
            admin.inscriereSpectacolDB(spc.titlu, spc.regie, spc.distributia, spc.nrBilete, spc.dataPrimiera);
            return spc;
        }


        public string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));

            }
            return sBuilder.ToString();

        }

        ////Extrage USer din DB

        public AngajatBL extragUserBL(string login, string pass ){
            AngajatBL angajatBL;
            UserDB u = new UserDB();

            string[] user = new string[]{};
            user = u.extrageUser(login, pass);
            angajatBL = new AngajatBL(user[0], user[1], user[2], user[3]);

            return angajatBL;
        }

        ///Generare parola Random
        public string generareParola() {
            
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
        
        //Inscriere parola noua
        public void inscrieParolaNoua(string login, string pass) { 
            //inscrier parola noua in Db
            String parola = getMd5Hash(pass);  
            UserDB u = new UserDB();
            
            u.inscriereParolaNoua(login, pass);
        
        }

    }
}
