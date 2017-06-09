using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Teste()
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Glaucia",
                Sobrenome = "Lemos",
                DataCadastro = DateTime.Now
            };

            return View("Index", cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){ Id = 2, Nome = "José", Sobrenome = "Lemos", DataCadastro = DateTime.Now },
                new Cliente(){ Id = 3, Nome = "Jurema", Sobrenome = "Lemos", DataCadastro = DateTime.Now }
            };

            return View(listaClientes);
        }

        public ActionResult Pesquisa(string id)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){ Id = 1, Nome = "José", Sobrenome = "Lemos", DataCadastro = DateTime.Now },
                new Cliente(){ Id = 2, Nome = "Jurema", Sobrenome = "Lemos", DataCadastro = DateTime.Now },
                new Cliente(){ Id = 3, Nome = "Jake", Sobrenome = "Lemos", DataCadastro = DateTime.Now },
                new Cliente(){ Id = 4, Nome = "Edízio", Sobrenome = "Lemos", DataCadastro = DateTime.Now }
            };

            /* Aqui estamos realizando uma busca de clientes pelo Nome através do 'Id' */
            var cliente = listaClientes.Where(c => c.Nome == id).ToList();

            return View("Lista", cliente);
        }
    }
}