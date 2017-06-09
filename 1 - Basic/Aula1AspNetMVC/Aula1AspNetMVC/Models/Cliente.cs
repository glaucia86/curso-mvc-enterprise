using System;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}