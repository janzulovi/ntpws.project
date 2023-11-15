using ntpws.project.Model;
using System.Collections.Generic;
using System.Linq;

namespace ntpws.project.Repository
{
    public class UserRepository
    {
        private ProjectDbContext _context;

        public UserRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public List<User> getUsers()
        {
            return _context.Users.ToList();
        }

        public User saveNewUser(User user) 
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return _context.Users.Where(u => u.Username == u.Username).FirstOrDefault();
        }

        public User updateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();

            return _context.Users.Where(u => u.Username == u.Username).FirstOrDefault();
        }

        public void deleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
