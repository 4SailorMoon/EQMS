using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.FriendlyUrls.Resolvers;
namespace WebApplication1
{
    public class MyWebFormsFriendlyUrlResolver: WebFormsFriendlyUrlResolver
    {
        protected override bool TrySetMobileMasterPage(HttpContextBase httpContext, Page page, string mobileSuffix)
        {
            if (mobileSuffix == "Mobile")
            {
                return false;
            }
            else
            {
                return base.TrySetMobileMasterPage(httpContext, page, mobileSuffix);
            }
        }

    }
}