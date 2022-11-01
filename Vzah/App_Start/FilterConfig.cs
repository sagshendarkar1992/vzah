﻿using Vzah.Filter;
using System.Web;
using System.Web.Mvc;

namespace Vzah
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SessionExpireAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
