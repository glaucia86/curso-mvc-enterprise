﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using GL.AppEnterprise.Domain.Entities;
using GL.AppEnterprise.Infra.Data.EntityConfig;

namespace GL.AppEnterprise.Infra.Data.Context
{
    public class AppEnterpriseContext : DbContext
    {
        public AppEnterpriseContext()
            : base("DefaultConnection")
        {

        }

        //Mapeamento do DB pelo EF
        public DbSet<Client> Clients { get; set; }

        //Mapeamento do DB pelo EF
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Para evitar o Cascade Delete para relacionamentos de 1 -> n
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Para evitar o Cascade Delete para relacionamentos de n -> n
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Para evitar de colocar os nomes das tabelas do DB no plural
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Configurando qual campo é o PK da DB
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Configurando os campos q forem do tipo 'string' serem do tipo 'varchar'
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Configurando que os campos do tipo 'string' recebem o tamanho máximo de 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //Adicionando as configurações dos dados da classe 'Client' no arquivo: 'ClientConfig.cs'
            modelBuilder.Configurations.Add(new ClientConfig());

            //Adicionando as configurações dos dados da classe 'Address' no arquivo: 'AddressConfig.cs'
            modelBuilder.Configurations.Add(new AddressConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedDate").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}