using System;
using System.Collections.Generic;
using System.Text;

namespace ntpws.project.Repository
{
    public class UserRepository
    {
        private ProjectDbContext _context;

        public UserRepository(ProjectDbContext context)
        {
            _context = context;
        }
    }
}
