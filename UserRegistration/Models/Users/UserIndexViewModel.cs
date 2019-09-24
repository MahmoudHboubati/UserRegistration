using Core.Providers.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Entities;

namespace UserRegistration.Models.Users
{
    public class UserIndexViewModel
    {
        private readonly IUserProvider provider;
        public IEnumerable<User> Users { get; private set; }

        public UserIndexViewModel(IUserProvider provider)
        {
            this.provider = provider;

            LoadList();
        }

        public void LoadList()
        {
            this.Users = provider.GetAll();
        }
    }
}
