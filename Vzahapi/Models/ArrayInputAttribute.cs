using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class ArrayInputAttribute : ActionFilterAttribute
{
    private readonly string parameterName;

    public ArrayInputAttribute(string paramName)
    {
        this.parameterName = paramName;
        this.Separator = ',';
    }

    public char Separator { get; set; }

    public override void OnActionExecuting(HttpActionContext actionContext)
    {
        if (!actionContext.ActionArguments.ContainsKey(this.parameterName))
        {
            return;
        }

        var parameters = string.Empty;
        if (actionContext.ControllerContext.RouteData.Values.ContainsKey(this.parameterName))
        {
            parameters = (string)actionContext.ControllerContext.RouteData.Values[this.parameterName];
        }
        else if (actionContext.ControllerContext.Request.RequestUri.ParseQueryString()[this.parameterName] != null)
        {
            parameters = actionContext.ControllerContext.Request.RequestUri.ParseQueryString()[this.parameterName];
        }

        if (parameters.Contains(this.Separator))
        {
            actionContext.ActionArguments[this.parameterName]= 
                parameters.Split(this.Separator).Select(int.Parse).ToArray();
        }
        else
        {
            actionContext.ActionArguments[this.parameterName] = new[] { parameters };
        }
    }
}