using System;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Glaucia",
                Sobrenome = "Lemos",
                DataCadastro = DateTime.Now
            };

            return View(cliente);
        }
    }
}