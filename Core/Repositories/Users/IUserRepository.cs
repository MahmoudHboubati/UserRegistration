using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Users
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
