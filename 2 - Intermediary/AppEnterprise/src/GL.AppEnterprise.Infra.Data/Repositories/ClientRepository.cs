using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using GL.AppEnterprise.Domain.Entities;
using GL.AppEnterprise.Domain.Interfaces;

namespace GL.AppEnterprise.Infra.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        // Método responsável por realizar a busca do CPF do cliente
        public Client GetByCpf(string cpf)
        {
            return Search(c => c.Cpf == cpf).FirstOrDefault();
        }

        // Método responsável por realizar a busca do email do cliente
        public Client GetByEmail(string email)
        {
            return Search(c => c.Email == email).FirstOrDefault();
        }

        // Método responsável por setar o status do cliente como 'false'/ 'inativo'
        // Assim evitará de remover o dado do Client, evitando a perda de dados de um cliente.
        public override void Delete(Guid id)
        {
            var client = GetById(id); //primeiro busco o cliente que quero alterar
            client.Active = false; //altero o status dele para 'false'
            Update(client); //atualizo no banco de dados
        }

        public override IEnumerable<Client> GetAll()
        {
            var conn = Db.Database.Connection;

            var cmd = @"select * from clients";

            return conn.Query<Client>(cmd);
        }

        public override Client GetById(Guid id)
        {
            var conn = Db.Database.Connection;

            var cmd = @"SELECT * FROM Clients c " +
                      "LEFT JOIN Addresses a " +
                      "ON c.ClientId = a.ClientId " +
                      "WHERE c.ClientId = @sid";

            var client = conn.Query<Client, Address, Client>(cmd,
                (c, a) =>
                {
                    c.Addresses.Add(a);
                    return c;
                }, new { sid = id }, splitOn: "ClientId, AddressId");

            return client.FirstOrDefault();
        }
    }
}
