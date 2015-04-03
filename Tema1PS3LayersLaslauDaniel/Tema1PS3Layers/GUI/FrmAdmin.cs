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
    public partial class FrmAdmin : Form
    {
        private UserService _userService;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            _userService = new UserService();
            userBindingSource.DataSource = _userService.getAllUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int _userID;

            if (this.userDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("You cannot update more than one user at a time!", "Error.");
            }
            else
            {
                foreach (DataGridViewRow row in this.userDataGridView.SelectedRows)
                {
                    if (row != null)
                    {

                        _userID = int.Parse(row.Cells["dgvColUserID"].Value.ToString());

                        FrmAddUpdateUser _frmAddUpdateUser = new FrmAddUpdateUser(_userService);

                        _frmAddUpdateUser.setFields(_userID, row.Cells["dgvColUsername"].Value.ToString(), row.Cells["dgvColPassword"].Value.ToString(),
                                                    row.Cells["dgvColName"].Value.ToString(), row.Cells["dgvColRole"].Value.ToString());

                        _frmAddUpdateUser.ShowDialog();
                       
                        userDataGridView.Refresh();
                        advertisementsDataGridView.Refresh();
                    }
                }
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser frmAddUpdate = new FrmAddUpdateUser(_userService);

            frmAddUpdate.ShowDialog();
            
            userDataGridView.Refresh();
            advertisementsDataGridView.Refresh();
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult;

            if (this.userDataGridView.SelectedRows.Count > 0)
            {
                dlgResult = MessageBox.Show("Do you want to delete selected records?", "Confirmation", MessageBoxButtons.OKCancel);
                if (dlgResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in this.userDataGridView.SelectedRows)
                    {
                        if (row != null)
                        {
                            User user = (User)row.DataBoundItem;
                            _userService.deleteUser(user);
                        }
                    }
                    
                    userDataGridView.Refresh();
                    advertisementsDataGridView.Refresh();
                }
            }
            
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            _userService.dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _userService.dispose();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            _userService.save();
            userDataGridView.Refresh();
            advertisementsDataGridView.Refresh();
        }

        private void btnShowAllAds_Click(object sender, EventArgs e)
        {
            FrmAllAdvertisements _frmAllAds = new FrmAllAdvertisements();
            this.Hide();
            _frmAllAds.ShowDialog();
            this.Show();
        }
    }
}
