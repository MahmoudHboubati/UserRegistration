using Core.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Providers.Users
{
    public class UserProvider : IUserProvider
    {
        private readonly IUserRepository repository;

        public UserProvider(IUserRepository repository)
        {
            this.repository = repository;
        }

        public bool Add(User user)
        {
            //Todo: change this to unit of work design
            return repository.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}
