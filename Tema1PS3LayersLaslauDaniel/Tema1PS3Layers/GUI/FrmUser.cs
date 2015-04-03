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
    public partial class FrmUser : Form
    {

        private AdvertisementService _adService;
        private User _user;


        public FrmUser(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            _adService = new AdvertisementService();
            advertisementBindingSource.DataSource = _adService.getUserAdvertisements(_user);   
        }

        private void btnAddAdv_Click(object sender, EventArgs e)
        {
            FrmAddUpdateAdvertisement frmAddAdv = new FrmAddUpdateAdvertisement(_user);

            frmAddAdv.ShowDialog();
            advertisementBindingSource.DataSource = _adService.getUserAdvertisements(_user);
        }

        private void btnUpdateAd_Click(object sender, EventArgs e)
        {
            int adId, occNo;
            String adDesc;
            byte[] img1Bytes, img2Bytes, img3Bytes;

            if (this.advertisementDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("You cannot update more than one advertisement at a time!", "Error.");
            }
            else
            {
                foreach (DataGridViewRow row in this.advertisementDataGridView.SelectedRows)
                { 
                    if (row != null)
                    {

                        adId = int.Parse(row.Cells["dgvColAdID"].Value.ToString());
                        occNo = int.Parse(row.Cells["dgvColOccurrenceNo"].Value.ToString());
                        adDesc = row.Cells["dgvColDescription"].Value.ToString();

                        img1Bytes = (Byte[])(row.Cells["dgvColPicture1"].Value);
                        img2Bytes = (Byte[])(row.Cells["dgvColPicture2"].Value);
                        img3Bytes = (Byte[])(row.Cells["dgvColPicture3"].Value);

                        FrmAddUpdateAdvertisement frmAddUpdateAd = new FrmAddUpdateAdvertisement(null);

                        frmAddUpdateAd.setFields(adId, occNo, adDesc, img1Bytes, img2Bytes, img3Bytes);

                        frmAddUpdateAd.ShowDialog();
                        advertisementBindingSource.DataSource = _adService.getUserAdvertisements(_user);
                    }
                }
            }


        }

        private void btnDeleteAd_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult;

            if (this.advertisementDataGridView.SelectedRows.Count > 0)
            {
                dlgResult = MessageBox.Show("Do you want to delete selected records?", "Confirmation", MessageBoxButtons.OKCancel);
                if (dlgResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in this.advertisementDataGridView.SelectedRows)
                    {
                        if (row != null)
                        {
                            Advertisement ad = (Advertisement)row.DataBoundItem;
                            _adService.deleteAdvertisemnet(ad);
                        }

                    }
                    advertisementBindingSource.DataSource = _adService.getUserAdvertisements(_user);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
