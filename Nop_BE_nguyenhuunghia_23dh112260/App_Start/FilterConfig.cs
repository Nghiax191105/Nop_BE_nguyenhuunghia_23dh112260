﻿using System.Web;
using System.Web.Mvc;

namespace Nop_BE_nguyenhuunghia_23dh112260
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
