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
    public partial class FrmAddUpdateUser : Form
    {
        private int userID = 0;
        private UserService _usrService; 
        private String oldUsername;


        public FrmAddUpdateUser(UserService usr)
        {
            _usrService = usr;
            InitializeComponent();
        }


        internal void setFields(int userId, String username, String password, String name, String role)
        {

            this.userID = userId;

            txtUsername.Text = username;
            oldUsername = username;
            txtPassword.Text = password;
            txtName.Text = name;
            txtRole.Text = role;
            
        }

        private void btnAddUpdateUser_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String name = txtName.Text;
            String role = txtRole.Text;
            
            if (username == String.Empty || password == String.Empty || name == String.Empty ||
                role == String.Empty)
            {

                MessageBox.Show("All fields must be completed!", "Error.");
            }
            else {

                if (role != "Admin" && role !="Regular")
                {
                    MessageBox.Show("Role field must have Admin or Regular value!", "Error.");
                }
                else {
                    if(oldUsername!= username && _usrService.verifyUsername(username) != null){

                        MessageBox.Show("This username already exists in the database!", "Error.");

                    }else{
                        if (userID == 0)
                        {
                            _usrService.addUser(username, password, name, role);
                        }
                        else
                        {
                        
                            _usrService.updateUser(userID, username, password, name, role);
                            userID = 0;
                        }
                        this.Hide();
                    }
                }
            }

        }
    }
}
