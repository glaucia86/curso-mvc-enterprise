using System;
using System.Linq;
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
    }
}
