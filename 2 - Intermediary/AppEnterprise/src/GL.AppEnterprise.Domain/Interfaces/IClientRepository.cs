using GL.AppEnterprise.Domain.Entities;
using GL.AppEnterprise.Domain.Interfaces.Repository;

namespace GL.AppEnterprise.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        /// <summary>
        /// Método responsável por retornar o CPF do Cliente.
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        Client GetByCpf(string cpf);

        /// <summary>
        /// Método responsável por retornar o Email do Cliente.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Client GetByEmail(string email);
    }
}