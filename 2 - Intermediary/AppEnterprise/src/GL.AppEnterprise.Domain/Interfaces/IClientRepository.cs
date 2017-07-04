using GL.AppEnterprise.Domain.Entities;
using GL.AppEnterprise.Domain.Interfaces.Repository;

namespace GL.AppEnterprise.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        // Método responsável por retornar um determinado Cliente pelo 'CPF'
        Client GetByCpf(string cpf);

        // Método responsável por retornar um determinado 'E-mail' do Cliente
        Client GetByEmail(string email);
    }
}