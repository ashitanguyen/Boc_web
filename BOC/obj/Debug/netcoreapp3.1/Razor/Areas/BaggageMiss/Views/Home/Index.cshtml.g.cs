#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b6d91d76f1b7b0925a99db8a1a189ada1aec7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BaggageMiss_Views_Home_Index), @"mvc.1.0.view", @"/Areas/BaggageMiss/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
using BOC.Areas.Baggage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
using BOC.Areas.Baggage.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b6d91d76f1b7b0925a99db8a1a189ada1aec7d", @"/Areas/BaggageMiss/Views/Home/Index.cshtml")]
    public class Areas_BaggageMiss_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
  

    var select = @HttpContextAccessor.HttpContext.Session.GetString("Lang") == null ? "VN" : @HttpContextAccessor.HttpContext.Session.GetString("Lang");
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b6d91d76f1b7b0925a99db8a1a189ada1aec7d4136", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"" />
    <meta name=""author"" content=""NhatNguyen"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Baggage Miss</title>
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/my-login.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/alertify.css"">
    <script src=""/js/jquery-3.5.1.min.js""></script>
    <script src=""/js/jquery.min.js""></script>
");
#nullable restore
#line 26 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
     if (select == "EN")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify.js\"></script>\r\n");
#nullable restore
#line 29 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script src=\"/js/alertify - VN.js\"></script>\r\n");
#nullable restore
#line 33 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b6d91d76f1b7b0925a99db8a1a189ada1aec7d6443", async() => {
                WriteLiteral(@"
    <section class=""h-100"" style=""margin-top:50px;"">
        <div class=""container h-100"">
            <div class=""row justify-content-md-center h-100"">
                <div class=""card-wrapper"">
                    <div class=""card fat"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-5""><img src=""/images/logo.png"" style=""width:184px;height:45px;"" alt=""logo""></div>
                                <div class=""col-sm-9"" style=""float:right"">
                                    <a href=""#"" id=""vn""><img src=""/images/vn.png"" width=""24"" height=""30"" /></a>
                                    <a href=""#"" id=""en""><img src=""/images/en.png"" width=""20"" height=""20"" /></a>
                                </div>
                                <div class=""col-sm-12""><h4 id=""texthead"" class=""card-title"" style=""text-align:center;color:#00548E;font-family:sans-serif;padding-top:40px;""></h4></div>
                    ");
                WriteLiteral("        </div>\r\n\r\n                            <div>\r\n                                <form method=\"post\" enctype=\"multipart/form-data\" class=\"my-login-validation\"");
                BeginWriteAttribute("novalidate", " novalidate=\"", 2362, "\"", 2375, 0);
                EndWriteAttribute();
                WriteLiteral(" asp-controller=\"Home\" asp-action=\"Login\">\r\n                                    ");
#nullable restore
#line 53 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n");
#nullable restore
#line 55 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                         if (select == "EN")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <label for=\"pnr\">PNR</label>\r\n");
#nullable restore
#line 58 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                       Write(Html.TextBoxFor(model => model.PNR, new { @class = "form-control", id = "PNR", placeholder = "Input Your PNR" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                                                                                                                                             
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <label for=\"pnr\">M?? ?????t Ch???</label>\r\n");
#nullable restore
#line 63 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                       Write(Html.TextBoxFor(model => model.PNR, new { @class = "form-control", id = "PNR", placeholder = "Vui l??ng nh???p m?? ?????t ch??? c???a b???n" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                                                                                                                                                               
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n");
#nullable restore
#line 68 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                         if (select == "EN")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <label for=\"fltno\">FltNo</label>\r\n");
#nullable restore
#line 71 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                       Write(Html.TextBoxFor(model => model.FltNo, new { @class = "form-control", id = "FltNo", placeholder = "Input Your Flight No" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                                                                                                                                                       

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <label for=\"fltno\">S??? Hi???u Chuy???n Bay</label>\r\n");
#nullable restore
#line 77 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                       Write(Html.TextBoxFor(model => model.FltNo, new { @class = "form-control", id = "FltNo", placeholder = "Vui l??ng nh???p s??? hi???u chuy???n bay." }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                                                                                                                                                                    

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n\r\n                                    <div class=\"form-group m-0\">\r\n                                        ");
#nullable restore
#line 83 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                   Write(Html.HiddenFor(model => model.WidthOfDevice, new { @id = "widthofdevice" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 84 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                   Write(Html.HiddenFor(model => model.TypeOfDevice, new { @id = "typeofdevice" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                         if (select == "EN")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button type=\"submit\" id=\"check\" class=\"btn btn-primary btn-block\">\r\n                                                Login\r\n                                            </button>\r\n");
#nullable restore
#line 90 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button type=\"submit\" id=\"check\" class=\"btn btn-primary btn-block\">\r\n                                                ????ng nh???p\r\n                                            </button>\r\n");
#nullable restore
#line 96 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                    ");
#nullable restore
#line 98 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                               Write(Html.HiddenFor(model => model.token, new { @id = "token" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </form>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"footer\">\r\n");
#nullable restore
#line 104 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                         if (select == "EN")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div>Copyright & copy; ");
#nullable restore
#line 106 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                              Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("  &mdash; Bamboo Airways</div>\r\n");
#nullable restore
#line 107 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div>B???n quy???n &copy; ");
#nullable restore
#line 110 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("  &mdash; Bamboo Airways</div>\r\n");
#nullable restore
#line 111 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <input type=\"hidden\" id=\"result\"");
                BeginWriteAttribute("value", " value=\"", 6153, "\"", 6174, 1);
#nullable restore
#line 119 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
WriteAttributeValue("", 6161, Model.Result, 6161, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"hidden\" id=\"error\"");
                BeginWriteAttribute("value", " value=\"", 6217, "\"", 6244, 1);
#nullable restore
#line 121 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
WriteAttributeValue("", 6225, Model.ErrorMessage, 6225, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"hidden\" id=\"langselect\"");
                BeginWriteAttribute("value", " value=\"", 6292, "\"", 6307, 1);
#nullable restore
#line 123 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
WriteAttributeValue("", 6300, select, 6300, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

    <script>
        $(function () {
            var lang = $(""#langselect"").val() == null ? ""VN"" : $(""#langselect"").val();
            /*var x = localStorage.getItem(""Token"");*/
            $(""#token"").val(localStorage.getItem(""Token""));
            var width = getscreenresolution();

            if ($(""#error"").val() !== """") {
                if ($(""#error"").val() == ""Data entered cannot be left blank."" && lang == ""VN"") {

                    alertify.alert(""D??? li???u nh???p kh??ng ???????c b??? tr???ng."");
                }
                if ($(""#error"").val() == ""Data entered cannot be left blank."" && lang == ""EN""){
                    alertify.alert($(""#error"").val());
                }

                if ($(""#error"").val() == 'Not found ' && lang == ""VN"") {
                    alertify.alert(""Kh??ng t??m th???y."");
                }
                if ($(""#error"").val() == 'Not found ' && lang == ""EN"") {
                    alertify.alert($(""#error"").val());
                }


         ");
                WriteLiteral(@"   }
            if ($(""#result"").val() !== """") {
                $('#password').val("""");

            }
            if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                // true for mobile device
                $(""#typeofdevice"").val(""MOBILE"");
                $(""#widthofdevice"").val(width.toString());
                if (lang == ""VN"" || lang == """") {
                    document.getElementById(""texthead"").innerHTML = ""Khai b??o h??nh l?? b??? qu??n."";
                }
                else {
                    document.getElementById(""texthead"").innerHTML = ""Left-behind article declaration."";
                }


            } else {
                debugger
                // false for not mobile device
                $(""#typeofdevice"").val(""NONE"");
                $(""#widthfdevice"").val(width.toString());
                if (lang == ""VN"" || lang == """") {
                    document.getElementById(""texthead"").innerHTML = ""Khai ");
                WriteLiteral(@"b??o h??nh l?? b??? qu??n"";
                }
                else {
                    document.getElementById(""texthead"").innerHTML = ""Left-behind article declaration"";
                }

            }

            $(""a#vn"").bind('touchstart click', function () {
                window.location.href = _subFolder + ""/Home/SetLang?id=VN"";
            });
            $(""a#en"").bind(' touchstart click', function () {
                window.location.href = _subFolder + ""/Home/SetLang?id=EN"";
            });
        })
    </script>
    <script>
                var getHomeAction = """);
#nullable restore
#line 189 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Home\Index.cshtml"
                                Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                if (getHomeAction == ""/"")
                    getHomeAction = """";
                var _subFolder = getHomeAction;
    </script>
    <script>
        /*L???y k??ch th?????c chi???u r???ng m??n h??nh*/
        function getscreenresolution() {
            return screen.width;
        }
    </script>
    }
");
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
