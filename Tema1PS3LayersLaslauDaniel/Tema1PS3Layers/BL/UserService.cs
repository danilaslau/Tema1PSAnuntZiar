using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tema1PS3Layers.DAL;
using Tema1PS3Layers.BL.Entities;

using System.Data.Entity;
using System.ComponentModel;

namespace Tema1PS3Layers.BL
{
    public class UserService
    {
        private Tema1PSAnuntZiarEntities ctx = new Tema1PSAnuntZiarEntities();
        public BindingList<User> getAllUsers()
        {
            
            ctx.Users.Load();
            return ctx.Users.Local.ToBindingList();
            
        }

        public User verifyUsername(String username)
        {
            username.Replace("'", "\\'");

            User user;
            try
            {
                user = ctx.Users.Single(j => j.Username == username);
            }
            catch (System.InvalidOperationException)
            {
                user = null;
            }

            return user;
        }


        public void updateUser(int id, String username, String password, String name, String role)
        {
            User user;
         
            String encryptedPassword = AuthenticationService.getMd5Hash(password);
            username.Replace("'", "\\'");

            user = ctx.Users.Single(j => j.UserID == id);

            user.Username = username;
            user.Password = encryptedPassword;
            user.Name = name;
            user.Role = role;

            ctx.SaveChanges();
            
        }
        public void addUser(String username, String password, String name, String role)
        {
            User user = new User();
            String encryptedPassword = AuthenticationService.getMd5Hash(password);
            username.Replace("'", "\\'");

            user.Username = username;
            user.Password = encryptedPassword;
            user.Name = name;
            user.Role = role;

            ctx.Users.Add(user);
            ctx.SaveChanges();
            ctx.Users.Load();
           
        }

        public void deleteUser(User deletedUser)
        {
            User user = ctx.Users.Single(j => j.UserID == deletedUser.UserID);
            ctx.Users.Remove(user);
            ctx.SaveChanges();
        }

        public void save() {
            ctx.SaveChanges();
        }
        public void dispose() {
            ctx.Dispose();
        }
    }
}
