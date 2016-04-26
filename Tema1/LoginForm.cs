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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminBL admin = new AdminBL();
            string criptare = admin.getMd5Hash(textPass.Text);
            String Rol = admin.checkExistUser(textLogin.Text, criptare );
            MessageBox.Show(Rol, "Rolul");
            switch (Rol) { 
                case "Admin":
                    this.Hide();
                    AdminForm adminForm = new AdminForm(textLogin.Text, criptare );
                    adminForm.Show();
                    


                    break;
                case "User":
                    this.Hide();
                    UserForm userForm = new UserForm(textLogin.Text, criptare);
                    userForm.Show();
                    


                    break;
                case "Nu exista asa User":
                    
                    break;
                default:
                    MessageBox.Show(" Fail", "Sistema");
                    break;
            }



            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            ForgotPassword fp = new ForgotPassword(textLogin.Text);
            fp.Show();
        }
    }
}
