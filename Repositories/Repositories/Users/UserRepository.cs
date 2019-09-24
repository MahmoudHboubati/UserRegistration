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
            //return context.Users.ToList();

            return new List<User>()
            {
                new User { Id = 1, UserName = "MahmoudHboubati", Email = "mhmoud.21830@gmail.com" },
                new User { Id = 2, UserName = "MahmoudHboubati", Email = "mhmoud.21830@gmail.com" },
                new User { Id = 3, UserName = "MahmoudHboubati", Email = "mhmoud.21830@gmail.com" },
                new User { Id = 4, UserName = "MahmoudHboubati", Email = "mhmoud.21830@gmail.com" },
                new User { Id = 5, UserName = "MahmoudHboubati", Email = "mhmoud.21830@gmail.com" },
            };
        }
    }
}
