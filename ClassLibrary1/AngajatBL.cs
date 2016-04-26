using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BL_Layer
{
    public class AngajatBL
    {
        public string login { get; set; }
        public string parola { get; set; }
        public string nume { get; set; }
        public string rol { get; set; }



        public AngajatBL( string login, string parola, string nume, string rol ) {

            this.login = login;
            this.parola = parola;
            this.nume = nume;
            this.rol = rol;
        
        }

        public string inscriereBilet( int idSpec, int rand, int nr){

            
                 //inscriere bilet in db
            BileteDB biletDB = new BileteDB();

            return biletDB.inscriereBilet(idSpec, rand, nr); ;
        }
        ///Extragere Lista Spctacole
        public DataTable viewSpectacol()
        {
            DataTable dt = new DataTable();
            SpectacolDB Lista = new SpectacolDB();

            dt = Lista.viewSpectacolDB();

            return dt;
        }
        



    }
}
