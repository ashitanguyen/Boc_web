#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ca93b348f217da39cbf2e806708e34c05c4c91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FileUpload), @"mvc.1.0.view", @"/Views/Shared/_FileUpload.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\_ViewImports.cshtml"
using BOC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
using BOC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
using BOC.Areas.BaggageMiss.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ca93b348f217da39cbf2e806708e34c05c4c91", @"/Views/Shared/_FileUpload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bd3e559f0a79a0d6a90e442bed2631b5d65b52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FileUpload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
  

    List<FileAttach_HS> _attachfileList = SessionHelper.GetObjectFromJson<List<FileAttach_HS>>(@HttpContextAccessor.HttpContext.Session, "AttachFileHSFound");



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
 if (_attachfileList != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul id=\"file_dinhkem\">\r\n");
#nullable restore
#line 20 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
         foreach (var item in _attachfileList)
        {
            if (item.FileLoc_ID != 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 25 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
               Write(item.FileName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("&emsp;&emsp;<a class=\"viewFile\"");
            BeginWriteAttribute("href", " href=\"", 603, "\"", 633, 2);
            WriteAttributeValue("", 610, "/data/", 610, 6, true);
#nullable restore
#line 25 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
WriteAttributeValue("", 616, item.sysFileName, 616, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"color:blue;\">View</a>&emsp;<a class=\"removeFile\" href=\"#\" data-fileid=\"");
#nullable restore
#line 25 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
                                                                                                                                                                                                     Write(item.sysFileName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"color:red;\">Remove</a></li>\r\n");
#nullable restore
#line 26 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 30 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\Shared\_FileUpload.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
