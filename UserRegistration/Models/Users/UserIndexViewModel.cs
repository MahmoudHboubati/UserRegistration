﻿using Core.Providers.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistration.Models.Users
{
    public class UserIndexViewModel
    {
        private readonly IUserProvider provider;

        public UserIndexViewModel(IUserProvider provider)
        {
            this.provider = provider;

            LoadList();
        }

        public void LoadList()
        {

        }

        public IList<int> User { get; set; }

    }
}
