using System;
using System.Net;
using System.Web.Mvc;
using GL.AppEnterprise.Application;
using GL.AppEnterprise.Application.ViewModel;

namespace GL.AppEnterprise.UI.Mvc.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientAppService _clientAppService;

        public ClientsController()
        {
            _clientAppService = new ClientAppService();
        }

        // GET: Clients
        public ActionResult Index()
        {
            return View(_clientAppService.GetAll());
        }

        // GET: Clients/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientViewModel = _clientAppService.GetById(id.Value);
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }

            return View(clientViewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientAddressViewModel clientAddressViewModel)
        {
            if (ModelState.IsValid)
            {
                _clientAppService.Add(clientAddressViewModel);
                return RedirectToAction("Index");
            }

            return View(clientAddressViewModel);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientViewModel = _clientAppService.GetById(id.Value);
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clientViewModel);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                _clientAppService.Update(clientViewModel);
                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var clientViewModel = _clientAppService.GetById(id.Value);

            if (clientViewModel == null)
            {
                return HttpNotFound();
            }

            return View(clientViewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clientAppService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clientAppService.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
