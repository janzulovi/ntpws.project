using ntpws.project.Model;
using ntpws.project.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ntpws.project.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<User> getUsers()
        {
            return _userRepository.getUsers();
        }

        public User saveNewUser(User user)
        {
            return _userRepository.saveNewUser(user);
        }

        public User updateUser(User user)
        {
            return _userRepository.updateUser(user);
        }

        public void deleteUser(User user)
        {
            _userRepository.deleteUser(user);
        }
    }
}
