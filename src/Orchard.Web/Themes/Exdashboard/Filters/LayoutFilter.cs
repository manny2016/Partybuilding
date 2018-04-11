using Orchard;
using Orchard.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exdashboard.Filters
{
    public class LayoutFilter : FilterProvider, IResultFilter
    {
        private readonly IWorkContextAccessor ContextAcccessor;

        public LayoutFilter(IWorkContextAccessor wca)
        {
            ContextAcccessor = wca;
        }
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            WorkContext workContext = ContextAcccessor.GetContext();

            if (HttpContext.Current.Request.Url.PathAndQuery.IndexOf("Exhibition/Industry", StringComparison.OrdinalIgnoreCase) > -1)
            {
                workContext.Layout.Metadata.Alternates.Add("Layout_Industry");
            }

            if (HttpContext.Current.Request.Url.PathAndQuery.IndexOf("Exhibition/Partbuilding", StringComparison.OrdinalIgnoreCase) > -1)
            {
                workContext.Layout.Metadata.Alternates.Add("Layout_Partbuilding");
            }
        }
        public void OnResultExecuted(ResultExecutedContext filterContext) { }
    }
}