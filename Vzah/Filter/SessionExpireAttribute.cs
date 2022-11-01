using Common;

using Vzah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace Vzah.Filter
{
    public class SessionExpireAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(SkipMyGlobalActionFilterAttribute), false).Any())
            {
                return;
            }

            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(SkipMyGlobalActionFilterAttribute), false).Any())
            {
                return;
            }
            if (HttpContext.Current.Request.Cookies["route_user"] == null)
            {
                FormsAuthentication.SignOut();
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                                                                 {
                                                                 { "action", "Login" },
                                                                 { "area", "" },
                                                                 { "controller", "Account" },
                                                                 { "returnUrl", filterContext.HttpContext.Request.RawUrl.ToString()}
                                                            });

                return;
            }
            else
            {
                string[] cookies = HttpContext.Current.Request.Cookies.AllKeys;
                foreach (string cookie in cookies)
                {
                    HttpContext.Current.Request.Cookies[cookie].Secure = true;
                }
                LoginSessionDetails objSessLog = new LoginSessionDetails();
                string[] strTemp = SPLITDETAILS();
                //SET THIS COOKIES DETAILS TO SESSIONLOGINOBJECT
                objSessLog.UserName = strTemp[0];
                objSessLog.UserId = Convert.ToInt32(strTemp[1]);
                objSessLog.Roles = strTemp[2]; objSessLog.USERTYPEStr = strTemp[3];
                objSessLog.RoleId = Convert.ToInt32(strTemp[4]);
                HttpContext.Current.Session["SessionInformation"] = objSessLog;

                //var descriptor = filterContext.ActionDescriptor;
                //var result = daccess.CheckPermittedUrl(
                //         Convert.ToInt32(strTemp[1]),
                //        (string)filterContext.RouteData.DataTokens["area"] ?? string.Empty,
                //        descriptor.ActionName,
                //        descriptor.ControllerDescriptor.ControllerName);
                //if (result == "0" && (descriptor.ActionName != "Index" || descriptor.ActionName != "_MainMenu") && (descriptor.ControllerDescriptor.ControllerName != "Landing" && descriptor.ControllerDescriptor.ControllerName != "CLCom_Admin"))
                //{
                //    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                //                                                 {
                //                                                 { "action", "UnAuthorized" },
                //                                                 { "area", "" },
                //                                                 { "controller", "Account" },
                //                                                 { "returnUrl", filterContext.HttpContext.Request.RawUrl.ToString()}
                //                                            });
                //}
            }
        }

        private static string[] SPLITDETAILS()
        {
            LoginViewModel lvm = new LoginViewModel();
            var bytes = Convert.FromBase64String(HttpContext.Current.Request.Cookies["route_user"].Value);
            var output = MachineKey.Unprotect(bytes, "ProtectCookie");
            string userdecrypt = Encoding.UTF8.GetString(output);
            //var userdecrypt = lvm.Decryptdata(HttpContext.Current.Request.Cookies["route_user"].Value);
            string[] strTemp = userdecrypt.Split(',');
            lvm.UserName = strTemp[0];
            lvm.Id = Convert.ToInt32(strTemp[1]);
            lvm.Role = strTemp[2]; lvm.USERTYPE = strTemp[3];
            return strTemp;
        }
    }
    public class SkipMyGlobalActionFilterAttribute : Attribute
    {
    }
}