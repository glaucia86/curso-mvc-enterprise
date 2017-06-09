using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Test()
        {
            var client = new Client()
            {
                Id = 1,
                Name = "Glaucia",
                Surname = "Lemos",
                CreatedDate = DateTime.Now
            };

            return View("Index", client);
        }

        public ActionResult List()
        {
            var clientList = new List<Client>()
            {
                new Client(){ Id = 1, Name = "José", Surname = "Lemos", CreatedDate = DateTime.Now },
                new Client(){ Id = 2, Name = "Jurema", Surname = "Lemos", CreatedDate = DateTime.Now },               
            };

            return View(clientList);
        }

        public ActionResult Search(string id)
        {
            var clientList = new List<Client>()
            {
                new Client(){ Id = 1, Name = "José", Surname = "Lemos", CreatedDate = DateTime.Now },
                new Client(){ Id = 2, Name = "Jurema", Surname = "Lemos", CreatedDate = DateTime.Now },
                new Client(){ Id = 3, Name = "Jake", Surname = "Lemos", CreatedDate = DateTime.Now },
                new Client(){ Id = 4, Name = "Edízio", Surname = "Lemos", CreatedDate = DateTime.Now }
            };

            /* Aqui estamos realizando uma busca de clientes pelo Nome através do 'Id' */
            var cliente = clientList.Where(c => c.Name == id).ToList();

            return View("List", clientList);
        }
    }
}