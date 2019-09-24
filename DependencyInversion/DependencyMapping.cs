using Core.Providers.Users;
using Core.Repositories.Users;
using Ninject;
using Repositories.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public static class DependencyMapping
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUserProvider>().To<UserProvider>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
