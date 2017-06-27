using System.Data.Entity;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Infra.Data.Context
{
    public class AppEnterpriseContext : DbContext
    {
        public AppEnterpriseContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}