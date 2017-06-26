using System;

namespace GL.AppEnterprise.Domain.Entities
{
    public class Address
    {
        public Address()
        {
            //Inicializando o Guid para que não venha 'zerado'
            AddressId = Guid.NewGuid();
        }

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

        /// <summary>
        /// Foreign Key (Campo para DB)
        /// ->> 
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Relacionamento entre Cliente -> Endereço
        /// </summary>
        public virtual Client Client { get; set; }
    }
}
