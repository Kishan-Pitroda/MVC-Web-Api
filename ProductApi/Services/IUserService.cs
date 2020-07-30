using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public User AddUser(User productItem);
        public User UpdateUser(User productItem);
        public User DeleteUser(int id);
    }
}
