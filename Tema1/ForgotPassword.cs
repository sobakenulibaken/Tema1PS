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

namespace Forms
{
    public partial class ForgotPassword : Form
    {
        string login;
        public ForgotPassword(string log )
        {
            InitializeComponent();
            this.login = log;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminBL admin = new AdminBL();
            String parola = admin.generareParola();
            afisareNouaParolaLabel.Text = parola;

            admin.inscrieParolaNoua(login, parola);

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
