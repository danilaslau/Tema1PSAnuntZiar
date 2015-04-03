using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tema1PS3Layers.DAL;
using Tema1PS3Layers.BL.Entities;

using System.Security.Cryptography;

namespace Tema1PS3Layers.BL
{
    class AuthenticationService
    {
        public User loginUser(String username, String password)
        {
            String encryptedPassword = getMd5Hash(password);
            username.Replace("'", "\\'");


            using (Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities())
            {
                User user;
                try
                {
                    user = ctx.Users.Single(j => j.Username == username && j.Password == encryptedPassword);

                }
                catch (System.InvalidOperationException)
                {
                    user = null;
                }

                return user;
            }
        }

        public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
