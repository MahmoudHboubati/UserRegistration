using Repositories.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories.Users;
using Core.Entities;
using InfraStructure;

namespace Repositories.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly DefaultDbContext context = new DefaultDbContext();

        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
