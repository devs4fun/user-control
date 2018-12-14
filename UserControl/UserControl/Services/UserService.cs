using System;
using System.Collections.Generic;
using System.Text;
using UserControl.Models;

namespace UserControl.Services
{
    public class UserService
    {
        public User CreateUser()
        {
            return new User();
        }

        public User GetById(int id)
        {
            // algum código

            return new User();
        }
    }
}
