using System;

namespace GL.AppEnterprise.Domain.Entities
{
    public class Client
    {
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Nome do Cliente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email do Cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// CPF do Cliente
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Data de Criação do Cadastro do Cliente
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Data de Nascimento do Cliente
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Saber se o Cliente está ativo ou não - Ativo
        /// </summary>
        public bool Active { get; set; }
    }
}
