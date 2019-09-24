using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Providers.Users;

namespace UserRegistration.Models.Users
{
    public class UserNewViewModel
    {
        private IUserProvider provider;
        public UserNewViewModel()
        {
        }

        public UserNewViewModel(IUserProvider provider)
        {
            this.provider = provider;
        }

        internal void Save(IUserProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}