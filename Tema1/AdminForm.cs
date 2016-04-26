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
    public partial class AdminForm : Form
    {
        private string login;
        private string pass;
        private AdminBL adminBL = new AdminBL();
        public AdminForm( string login, string pass)
        {
            InitializeComponent();
            this.login = login;
            this.pass = pass;
            InitializeComponent();
            // Set to no text.
            passNewBox.Text = "";
            // The password character is an asterisk.
            passNewBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passNewBox.MaxLength = 14;
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }
        private void passNewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolNewBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            AngajatBL a = adminBL.creareAngjatNou(loginNewBox.Text, adminBL.getMd5Hash(passNewBox.Text), numeNewBox.Text, rolNewBoxCombo.Text );
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpectacolBL s = adminBL.inscriereSpectacol(titluBox.Text, regieBox.Text, distribBox.Text, Int32.Parse(nrLocuriBox.Text) , dateTimePicker1.Text );
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
