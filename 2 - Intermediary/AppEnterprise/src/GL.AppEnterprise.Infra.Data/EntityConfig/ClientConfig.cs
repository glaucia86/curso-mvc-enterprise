using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Infra.Data.EntityConfig
{
    public class ClientConfig : EntityTypeConfiguration<Client>
    {
        /// <summary>
        /// Método responsável por tratar as configurações dos campos da classe 'Client' de acordo
        /// com o DB
        /// </summary>
        public ClientConfig()
        {
            HasKey(c => c.ClientId);
            //HasKey(c => new {c.ClientId, c.Cpf}); //em casos de chave composta

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(c => c.BirthDate)
                .IsRequired();

            Property(c => c.CreatedDate)
                .IsRequired();

            ToTable("Clients");

        }
    }
}