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

namespace Tema1PS3Layers.GUI
{
    public partial class FrmAllAdvertisements : Form
    {
        private AdvertisementService _adService;

        public FrmAllAdvertisements()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAllAdvertisements_Load(object sender, EventArgs e)
        {

            _adService = new AdvertisementService();
            advertisementBindingSource.DataSource = _adService.getAllAdvertisements();
        } 
    }
}
