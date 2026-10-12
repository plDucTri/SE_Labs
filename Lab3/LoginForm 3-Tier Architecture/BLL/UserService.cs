using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserService
    {
        UserRepository repo;
        public UserService()
        {
            repo = new UserRepository();
        }

        public bool Login(string username, string password)
        {
            return repo.Login(username, password);
        }
    }
}
