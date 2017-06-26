using System;

namespace GL.AppEnterprise.Domain.Entities
{
    public class Address
    {
        /// <summary>
        /// Id do Endereço
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        public string PublicPlace { get; set; }

        /// <summary>
        /// Número do Endereço
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Complemento 
        /// </summary>
        public string AddressComplement { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public string State { get; set; }
    }
}
