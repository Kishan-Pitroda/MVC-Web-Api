using ProductApi.Models;
using ProductApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Services
{

    public class UserService : IUserService
    {
        public readonly UserDbContext dbContext;

        public UserService(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public User GetUser(int id)
        {
            User user = dbContext.Users.Find(id);
            return user;
        }

        public User AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            dbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            User user = dbContext.Users.Find(id);
            dbContext.Remove(user);
            dbContext.SaveChanges();
            return user;
        }
    }

}