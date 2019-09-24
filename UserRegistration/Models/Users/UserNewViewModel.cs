using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Providers.Users;
using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Models.Users
{
    public class UserNewViewModel
    {
        private IUserProvider provider;

        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

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