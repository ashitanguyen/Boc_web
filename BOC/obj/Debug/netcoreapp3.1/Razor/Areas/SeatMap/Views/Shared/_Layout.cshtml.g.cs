#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe7ce69ee60ccba5bc2c259e8fdff41568090a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SeatMap_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/SeatMap/Views/Shared/_Layout.cshtml")]
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
#line 7 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe7ce69ee60ccba5bc2c259e8fdff41568090a2", @"/Areas/SeatMap/Views/Shared/_Layout.cshtml")]
    public class Areas_SeatMap_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
  

    var select = @HttpContextAccessor.HttpContext.Session.GetString("Language") == null ? "VN" : @HttpContextAccessor.HttpContext.Session.GetString("Language");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe7ce69ee60ccba5bc2c259e8fdff41568090a23378", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
#nullable restore
#line 15 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - SeatMap Page</title>
    <link rel=""stylesheet"" href=""/css/vendors/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""/css/SeatMap.css"" />
    <link rel=""stylesheet"" href=""/css/SeatNote.css"" />
    <link href=""/css/alertify.css"" rel=""stylesheet"" media=""screen"" type=""text/css"" />
    <script src=""/js/jquery-3.5.1.min.js""></script>
");
#nullable restore
#line 21 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
     if (select == "EN")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify.js\"></script>\r\n");
#nullable restore
#line 24 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify - VN.js\"></script>\r\n");
#nullable restore
#line 29 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe7ce69ee60ccba5bc2c259e8fdff41568090a25869", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"content\">\r\n        <main role=\"main\" class=\"pb-1\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n");
                DefineSection("scripts", async() => {
                    WriteLiteral(@"

        <script>
            $(function () {
                if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                    // true for mobile device
                    $(""#content"").addClass(""container-sm"");

                } else {
                    // false for not mobile device
                    $(""#content"").addClass(""container-fluid"");


                }
            })

        </script>
        <script>
                var getHomeAction = """);
#nullable restore
#line 58 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
                                Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\";\r\n                if (getHomeAction == \"/\")\r\n                    getHomeAction = \"\";\r\n                var _subFolder = getHomeAction;\r\n        </script>\r\n       \r\n\r\n    ");
                }
                );
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 71 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\SeatMap\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
