using System;
using System.Net;
using System.Web.Mvc;
using GL.AppEnterprise.Application;
using GL.AppEnterprise.Application.ViewModel;

namespace GL.AppEnterprise.UI.Mvc.Controllers
{
    [RoutePrefix("management")]
    public class ClientsController : Controller
    {
        private readonly ClientAppService _clientAppService;

        public ClientsController()
        {
            _clientAppService = new ClientAppService();
        }

        #region " GET - Clients "

        [Route("list-clients")]
        public ActionResult Index()
        {
            return View(_clientAppService.GetAll());
        }

        #endregion

        #region " DETAILS - Clients "

        [Route("{id:guid}/view-client")]
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

        #endregion

        #region " CREATE - Client "

        [Route("new-client")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("new-client")]
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

        #endregion

        #region " EDIT - Client "

        [Route("{id:guid}/update-client")]
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

        [Route("{id:guid}/update-client")]
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

        #endregion

        #region " DELETE - Client "

        [Route("{id:guid}/delete-client")]
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

        [Route("{id:guid}/delete-client")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clientAppService.Delete(id);
            return RedirectToAction("Index");
        }

        #endregion

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
