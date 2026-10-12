using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace DAL
{
    public class UserRepository
    {
        private LoginDbContext db;

        public UserRepository()
        {
            db = new LoginDbContext();
        }

        public bool Login(string username, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return user != null;
        }
    }
}