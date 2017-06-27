using System.Data.Entity.ModelConfiguration;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Infra.Data.EntityConfig
{
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        /// <summary>
        /// Método responsável por tratar as configurações dos campos da classe 'Address' de acordo
        /// com o DB
        /// </summary>
        public AddressConfig()
        {
            HasKey(a => a.AddressId);

            Property(a => a.PublicPlace)
                .IsRequired()
                .HasMaxLength(150);

            Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.AddressComplement)
                .HasMaxLength(100);

            Property(a => a.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.State)
                .IsRequired()
                .HasMaxLength(100);

            //Configurando o relacionamento entre Client -> Address (1 -> n)
            HasRequired(a => a.Client)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.ClientId);

            ToTable("Addresses");
        }
    }
}