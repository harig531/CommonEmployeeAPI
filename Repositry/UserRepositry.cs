using CommonEmployeeAPI.CommonEmployeeApi.Database;
using CommonEmployeeAPI.Interfaces;
using CommonEmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonEmployeeAPI.Repositry
{
    public class UserRepositry : IUserInterface
    {
        private readonly CommonEmployeeDbContext _commonEmployeeAPIContext;

        public UserRepositry(CommonEmployeeDbContext commonEmployeeAPIContext)
        {
            this._commonEmployeeAPIContext = commonEmployeeAPIContext;
        }


        public Users DeletUsers(int Id)
        {
            Users objectusers = this._commonEmployeeAPIContext.Users.Find(Id);
            if (objectusers != null)
            {
                this._commonEmployeeAPIContext.Users.Remove(objectusers);
                this._commonEmployeeAPIContext.SaveChanges();
            }
            return objectusers;
        }

        public Users GetUsers(int Id)
        {
            return this._commonEmployeeAPIContext.Users.Find(Id);
        }

        public bool IsUsersExists(int id)
        {
            return this._commonEmployeeAPIContext.Users.Any(e => e.Id == id);
        }

        public IEnumerable<Users> ListUsers()
        {
            return this._commonEmployeeAPIContext.Users;
        }

        public Users SaveUsers(Users UserModel)
        {
            this._commonEmployeeAPIContext.Users.Add(UserModel);
            this._commonEmployeeAPIContext.SaveChanges();
            return UserModel;
        }

        public Users UpdateUsers(Users UserModel)
        {
            var userObject = this._commonEmployeeAPIContext.Users.Attach(UserModel);
            if (userObject != null)
            {
                userObject.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this._commonEmployeeAPIContext.SaveChanges();
            }
            return UserModel;
        }
    }
}
