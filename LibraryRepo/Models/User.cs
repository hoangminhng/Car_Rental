using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
