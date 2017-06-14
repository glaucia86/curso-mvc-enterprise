using System.Data.Entity;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context()
            : base("Aula1Context")
        {
            
        }

        // Referência da Classe Client (contida no Models) para podermos trabalhar com o EF
        public DbSet<Client> Clients { get; set; }
    }
}