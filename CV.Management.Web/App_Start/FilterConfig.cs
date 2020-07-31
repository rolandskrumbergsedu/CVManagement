using NWebsec.Mvc.HttpHeaders.Csp;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ErrorHandler.AiHandleErrorAttribute());

            filters.Add(new CspAttribute());
            filters.Add(new CspDefaultSrcAttribute { Self = true });
            filters.Add(new CspScriptSrcAttribute { Self = true, UnsafeInline = true, CustomSources = "https://az416426.vo.msecnd.net" });
            filters.Add(new CspStyleSrcAttribute { Self = true, UnsafeInline = true });
            filters.Add(new CspImgSrcAttribute { Self = true, CustomSources = "data:" });
            filters.Add(new CspObjectSrcAttribute { None = true });
            filters.Add(new CspMediaSrcAttribute { Self = true });
            filters.Add(new CspFrameSrcAttribute { None = true });
            filters.Add(new CspFontSrcAttribute { Self = true });
            filters.Add(new CspConnectSrcAttribute { CustomSources = "https://dc.services.visualstudio.com https://cv.amrop.lv/api/deletebyusername" });
            filters.Add(new CspFrameAncestorsAttribute { None = true });
        }
    }
}
