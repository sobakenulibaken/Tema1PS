using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Layer;
using DAO;

namespace Forms
{
    public partial class UserForm : Form
    {
        private string login;
        private string pass;
        
        public UserForm( string login, string pass)
        {
            InitializeComponent();
            this.login = login;
            this.pass = pass;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AdminBL adminBL = new AdminBL();

                AngajatBL angajat = adminBL.extragUserBL(login, pass);
                DataTable dt = new DataTable();
                dt = angajat.viewSpectacol();

                dataGridViewSpectacole.DataSource=dt;


            }



        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminBL adminBL = new AdminBL();

                AngajatBL angajat = adminBL.extragUserBL(login, pass);

                string mesaj = angajat.inscriereBilet(Int32.Parse(IDbox.Text), Int32.Parse(randBox.Text), Int32.Parse(nrLocBox.Text));

                MessageBox.Show(mesaj, "Sistem Bilete");
            }
            catch (Exception s) {
                
            }


        }
    }
}
