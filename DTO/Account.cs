using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Joindate { get; set; }
        public string Role { get; set; }

        public Account() { }
        public Account(string username, string password, string fullname, string email, string joindate, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Fullname = fullname;
            this.Email = email;
            this.Joindate = joindate;
            this.Role = role;
        }
    }
}
