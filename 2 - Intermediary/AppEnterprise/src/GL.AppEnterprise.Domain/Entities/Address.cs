using System;

namespace GL.AppEnterprise.Domain.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }

        public string PublicPlace { get; set; }

        public string Number { get; set; }

        public string AddressComplement { get; set; }

        public string Cep { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
