using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tema1PS3Layers.BL.Entities;
using Tema1PS3Layers.DAL;

namespace Tema1PS3Layers.BL
{
    class AdvertisementService
    {
        public List<Advertisement> getAllAdvertisements()
        {
            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                return ctx.Advertisements.ToList();
            }
        }

        public List<Advertisement> getUserAdvertisements(User user)
        {
            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                var userAdvertisements = ctx.Advertisements.Where(a => a.UserId == user.UserID);

                return userAdvertisements.ToList();
            }
        }



        public void updateUser(int adId, int occNo, String description, byte[] img1Bytes, byte[] img2Bytes, byte[] img3Bytes)
        {
            Advertisement ad;

            
            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                ad = ctx.Advertisements.Single(j => j.AdID == adId);

                ad.OccurrenceNo = occNo;
                ad.Description = description;
                ad.Picture1 = img1Bytes;
                ad.Picture2 = img2Bytes;
                ad.Picture3 = img3Bytes;
                
                ctx.SaveChanges();
                
            }

        }

        public void addAdvertisement(int occNo, String description, byte[] img1Bytes, byte[] img2Bytes, byte[] img3Bytes, int userId)
        {
            Advertisement ad = new Advertisement();

            ad.OccurrenceNo = occNo;
            ad.Description = description;
            ad.Picture1 = img1Bytes;
            ad.Picture2 = img2Bytes;
            ad.Picture3 = img3Bytes;
            ad.UserId = userId;

            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                
                ctx.Advertisements.Add(ad);
                ctx.SaveChanges();
            }
        }

        public void deleteAdvertisemnet(Advertisement deletedAd)
        {
            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                Advertisement ad = ctx.Advertisements.Single(j => j.AdID == deletedAd.AdID);
                ctx.Advertisements.Remove(ad);
                ctx.SaveChanges();
            }
        }    

    }
}
