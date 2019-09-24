using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Providers.Users
{
    public interface IUserProvider
    {
        IEnumerable<User> GetAll();
        bool Add(User user);
    }
}
