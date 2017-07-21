

using System.Web.Mvc;

namespace GL.AppEnterprise.Infra.CrossCutting.Filters
{
    public class GlobalErrorHandler : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext != null)
            {
                //Tratar o erro de alguma forma
                //1 - Gravar no EventViewer
                //2 - Gravar no Banco
                //3 - Enviar no Banco
              
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
