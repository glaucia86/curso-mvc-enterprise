using System;

namespace GL.AppEnterprise.Domain.Entities
{
    public class Client
    {
        public Guid ClientId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }
    }
}
