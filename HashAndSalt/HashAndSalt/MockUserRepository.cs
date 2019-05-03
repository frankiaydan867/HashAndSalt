﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HashAndSalt
{
    class MockUserRepository
    {
        List<User> users = new List<User>();

        // Function to add the user to im memory dummy DB
        public void AddUser(User user)
        {
            users.Add(user);
        }

        // Function to retrieve the user based on user id
        public User GetUser(string userid)
        {
            return users.Single(u => u.UserId == userid);
        }

    }
}
