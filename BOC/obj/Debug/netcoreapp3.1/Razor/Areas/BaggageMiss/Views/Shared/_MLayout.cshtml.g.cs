#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64cd502562bb2a356ddc59d83498cddc0e3894a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BaggageMiss_Views_Shared__MLayout), @"mvc.1.0.view", @"/Areas/BaggageMiss/Views/Shared/_MLayout.cshtml")]
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
#line 8 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cd502562bb2a356ddc59d83498cddc0e3894a5", @"/Areas/BaggageMiss/Views/Shared/_MLayout.cshtml")]
    public class Areas_BaggageMiss_Views_Shared__MLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
  

    var select = @HttpContextAccessor.HttpContext.Session.GetString("Lang") == null ? "VN" : @HttpContextAccessor.HttpContext.Session.GetString("Lang");
    var device = @HttpContextAccessor.HttpContext.Session.GetString("TypeOfDevice");
    var width = @HttpContextAccessor.HttpContext.Session.GetString("WidthOfDevice");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cd502562bb2a356ddc59d83498cddc0e3894a53511", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Baggage Miss</title>
    <!-- Jquey -->
    <script src=""/js/jquery-3.5.1.min.js""></script>
    <script src=""/js/jquery.min.js""></script>
    <!-- Bootstrap -->
    <script src=""/js/bootstrap.bundle.min.js""></script>
    <!-- Latest compiled and minified JavaScript -->
");
#nullable restore
#line 23 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
     if (select == "EN")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify.js\"></script>\r\n");
#nullable restore
#line 26 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify - VN.js\"></script>\r\n");
#nullable restore
#line 31 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/css/vendors/bootstrap.min.css"" />
    <link href=""/css/TableProfileStyle.css"" rel=""stylesheet"" />
    <!-- Alertify -->
    <link href=""/css/alertify.css"" rel=""stylesheet"">
    <!-- DevExtreme themes -->
    <link rel=""stylesheet"" href=""/css/devextreme/dx.common.css"">
    <link rel=""stylesheet"" href=""/css/devextreme/dx.light.css"">
    <!-- DevExtreme library -->
    <script type=""text/javascript"" src=""/js/devextreme/dx.all.js""></script>
    <link rel=""stylesheet"" href=""/css/fs-modal.min.css"">
");
#nullable restore
#line 44 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
     if (device == "MOBILE")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <link rel=\"stylesheet\" href=\"/css/style4baggagemissMobile.css\">\r\n");
#nullable restore
#line 47 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <style>
        body {
            /* background-color: rgb(128, 255, 128);*/
            background-color: rgb(235, 243, 248);
        }


        page {
            background: white;
            display: block;
            margin: 10px auto;
            margin-bottom: 0.5cm;
            box-shadow: 0 0 0.5cm rgba(0,0,0,0.5);
        }


            page[size=""A4""] {
                width: ");
#nullable restore
#line 65 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
                  Write(width.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"px!important;
                height: auto;
            }

        #back2Top {
            width: 40px;
            line-height: 40px;
            overflow: hidden;
            z-index: 999;
            display: none;
            cursor: pointer;
            -moz-transform: rotate(270deg);
            -webkit-transform: rotate(270deg);
            -o-transform: rotate(270deg);
            -ms-transform: rotate(270deg);
            transform: rotate(270deg);
            position: fixed;
            bottom: 50px;
            right: 0;
            background-color: #DDD;
            color: #555;
            text-align: center;
            font-size: 30px;
            text-decoration: none;
        }

            #back2Top:hover {
                background-color: #DDF;
                color: #000;
            }
    </style>

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64cd502562bb2a356ddc59d83498cddc0e3894a58412", async() => {
                WriteLiteral("\r\n\r\n    <article>\r\n        <section>\r\n            <page size=\"A4\">\r\n                <br>\r\n                ");
#nullable restore
#line 105 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </page>\r\n        </section>\r\n    </article>\r\n    <!-- footer content -->\r\n    <footer>\r\n        <div class=\"pull-right\" style=\"text-align: center;color: #00548E;\">\r\n");
#nullable restore
#line 112 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
             if (select == "EN")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div style=\"margin-left:30px!important;\">All rights & Copyrights reserved by Bamboo Airways</div>\r\n");
#nullable restore
#line 115 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div style=\"margin-left:50px!important;\">Bản quyền &copy; Bamboo Airways</div>\r\n");
#nullable restore
#line 119 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n        <script>\r\n                var getHomeAction = \"");
#nullable restore
#line 124 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Shared\_MLayout.cshtml"
                                Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                if (getHomeAction == ""/"")
                    getHomeAction = """";
                var _subFolder =  getHomeAction;
        </script>
    </footer>
    <!-- /footer content -->
    <a id=""back2Top"" title=""Back to top"" href=""#"">&#10148;</a>


    <script>
        $(document).ready(function () {
            //Back to top when user scroll
            $(window).scroll(function () {
                if ($(this).scrollTop()) {
                    $('#back2Top').fadeIn();
                } else {
                    $('#back2Top').fadeOut();
                }
            });

            $(""#back2Top"").click(function () {
                //1 second of animation time
                //html works for FFX but not Chrome
                //body works for Chrome but not FFX
                //This strange selector seems to work universally
                $(""html, body"").animate({ scrollTop: 0 }, 1000);
            });
           
        });
    </script>
");
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
