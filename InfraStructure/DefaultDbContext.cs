using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfraStructure
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
