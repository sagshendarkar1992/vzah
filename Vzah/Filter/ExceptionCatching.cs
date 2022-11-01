 
using System.Web.Mvc; 
namespace Vzah.Filter
{
    public class ExceptionCatching : HandleErrorAttribute
    {
        
        public override void OnException(ExceptionContext filterContext)
        {
            //daccess.SaveErrorLog(filterContext.Exception.ToString());
        }
    }
}