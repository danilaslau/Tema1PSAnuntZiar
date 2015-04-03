using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tema1PS3Layers.BL;
using Tema1PS3Layers.BL.Entities;

namespace Tema1PS3Layers.GUI
{
    public partial class FrmLogin : Form
    {

        private AuthenticationService _userService = new AuthenticationService();

        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User u = _userService.loginUser(txtUsername.Text, txtPassword.Text);

            if (u == null)
            {
                MessageBox.Show("Login incorrect", "Error.");
            }
            else{
                
                if (u.Role == "Admin")
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    this.Hide();
                    frmAdmin.ShowDialog();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Show();
                    
                }
                else if (u.Role == "Regular")
                {
                    FrmUser frmUser = new FrmUser(u);
                    this.Hide();
                    frmUser.ShowDialog();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Show();
                }
            }
        }
    }
}
