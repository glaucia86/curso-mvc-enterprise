using System.Data.Entity;

namespace Aula1AspNetMVC.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context()
            : base("Aula1Context")
        {
            
        }
    }
}