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
    }
}
