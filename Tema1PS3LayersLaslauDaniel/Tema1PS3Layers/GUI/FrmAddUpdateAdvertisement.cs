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


using System.IO;


namespace Tema1PS3Layers.GUI
{
    public partial class FrmAddUpdateAdvertisement : Form
    {
        private User _user;
        private AdvertisementService _adService = new AdvertisementService();
        private int adId = 0;
        private OpenFileDialog openFileDialog1;


        public FrmAddUpdateAdvertisement(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FrmAddUpdateAdvertisement_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";//|All files (*.*)|*.*";
        
        }

       
        private byte[] imgToByteArray(Image img)
        {
            if (img == null)
                return null;
           
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(img, typeof(byte[]));
            return xByte;
            
        }
       
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        internal void setFields(int adId, int occNo, String description, byte[] img1Bytes, byte[] img2Bytes, byte[] img3Bytes)
        {

            this.adId = adId;

            txtOccNo.Text = occNo.ToString();
            txtDescription.Text = description;
            
            pbPic1.Image = byteArrayToImage(img1Bytes);    
            pbPic2.Image = byteArrayToImage(img2Bytes); 
            pbPic3.Image = byteArrayToImage(img3Bytes);
            

        }


        private void btnPic1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse for Picture 1";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPic1.Text = openFileDialog1.FileName;
                    pbPic1.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse for Picture 2";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPic2.Text = openFileDialog1.FileName;
                    pbPic2.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnPic3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse for Picture 3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPic3.Text = openFileDialog1.FileName;
                    pbPic3.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btnAddUpdateAd_Click(object sender, EventArgs e)
        {
            int occNo;
            String adDesc = txtDescription.Text;
            Image img1 = null, img2 = null, img3 = null;
            
            
            try
            {
                occNo = Int32.Parse(txtOccNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number of occurrences!\n", "Error.");
                txtOccNo.Select();
                return;
            }

            if (adDesc == String.Empty) {
                MessageBox.Show("Enter a description for this advertisement!", "Error.");
                txtDescription.Select();
                return;
            }
            
        
            if (pbPic1.Image != null)
            {
                img1 = pbPic1.Image.GetThumbnailImage(80, 50, null, new System.IntPtr());
            }
            if (pbPic2.Image != null)
            {
                img2 = pbPic2.Image.GetThumbnailImage(80, 50, null, new System.IntPtr());
            }
            if (pbPic3.Image != null){
                img3 = pbPic3.Image.GetThumbnailImage(80, 50, null, new System.IntPtr());
            }

            if (adId == 0)
            {
                _adService.addAdvertisement(occNo, adDesc, imgToByteArray(img1), imgToByteArray(img2), imgToByteArray(img3), _user.UserID);

            }
            else {
                _adService.updateUser(adId, occNo, adDesc, imgToByteArray(img1), imgToByteArray(img2), imgToByteArray(img3));
                adId = 0;
            }

            this.Hide();

       }
    }
}
