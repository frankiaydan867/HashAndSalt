using System;
using System.Collections.Generic;
using System.Text;

namespace HashAndSalt
{
    class User
    {
        public string UserId { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

    }
}
