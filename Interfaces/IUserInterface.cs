using CommonEmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonEmployeeAPI.Interfaces
{
    public interface IUserInterface
    {
        Users GetUsers(int Id);
        IEnumerable<Users> ListUsers();

        Users SaveUsers(Users UserModel);

        Users DeletUsers(int Id);
        Users UpdateUsers(Users UserModel);

        bool IsUsersExists(int id);
  
    }
}
