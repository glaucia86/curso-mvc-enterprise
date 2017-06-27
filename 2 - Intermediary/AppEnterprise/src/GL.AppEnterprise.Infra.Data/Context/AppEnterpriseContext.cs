using System.Data.Entity;

namespace GL.AppEnterprise.Infra.Data.Context
{
    public class AppEnterpriseContext : DbContext
    {
        public AppEnterpriseContext()
            : base("DefaultConnection")
        {
            
        }
    }
}