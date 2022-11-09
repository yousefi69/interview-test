using interview.Interface;
using interview.Models;
using interview.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Service
{
    public class UserService : IUser
    {
        private readonly Models.interviewContext _context;
        public UserService(Models.interviewContext context)
        {
            _context = context;

        }

        public object getUserList()
        {
            var List = _context.Users.Select(s => new { s.Id, s.Name, s.Email }).ToList();
            var res = new List<UserViewModel>();
            return (List);
        }

        public User getUserbyId(int Id)
        {
            var userInfo = _context.Users.Where(w => w.Id == Id).FirstOrDefault();
            return userInfo;
        }

        public void addUser(Models.User model)
        {
            var newUser = new User { Id = model.Id, Name = model.Name, Email = model.Email };
            _context.Users.Add(model);
            _context.SaveChanges();
        }
        public void updateUser(Models.User model)
        {
            var userInfo = _context.Users.Where(w => w.Id == model.Id).FirstOrDefault();
            userInfo.Name = model.Name;
            userInfo.Email = model.Email;

            _context.SaveChanges();

        }

        public void removeUser(int Id)
        {
            var userInfo = _context.Users.Where(w => w.Id == Id).FirstOrDefault();
            var res = _context.Remove(userInfo);
            _context.SaveChanges();
        }

    }
}
