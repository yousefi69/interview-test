using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Interface
{
   public interface IUser
    {
        object getUserList();
        User getUserbyId(int Id);
        void addUser(Models.User model);
        void updateUser(Models.User model);
        void removeUser(int Id);
    }
}
