using System;
using System.ComponentModel.DataAnnotations;

namespace ntpws.project.Model
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
    }
}
