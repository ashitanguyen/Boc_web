#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c464b56e556427fb40dc397dfaa47d471c47e2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Mobile/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
using BOC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
using BOC.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c464b56e556427fb40dc397dfaa47d471c47e2d3", @"/Areas/Mobile/Views/Home/Index.cshtml")]
    public class Areas_Mobile_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c464b56e556427fb40dc397dfaa47d471c47e2d33534", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""author"" content=""NhatNguyen"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Login BOC Mobile</title>
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/my-login.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/alertify.css"">
    <script src=""/js/jquery-3.5.1.min.js""></script>
    <script src=""/js/alertify.js""></script>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c464b56e556427fb40dc397dfaa47d471c47e2d35026", async() => {
                WriteLiteral(@"
    <section class=""h-100"" style=""margin-top:20px;"">
        <div class=""container h-100"">
            <div class=""row justify-content-md-center h-100"">
                <div class=""card-wrapper"">
                    <div class=""card fat"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-5""><img src=""/images/logo.png"" style=""width:184px;height:45px;"" alt=""logo""></div>
                                <div class=""col-sm-7""><h3 id=""texthead"" class=""card-title"" style=""float:right;color:#00548E;font-family:sans-serif;padding-top:50px;""></h3></div>
                            </div>

                            <div>
                                <form method=""post"" enctype=""multipart/form-data"" class=""my-login-validation""");
                BeginWriteAttribute("novalidate", " novalidate=\"", 1476, "\"", 1489, 0);
                EndWriteAttribute();
                WriteLiteral(" asp-controller=\"Home\" asp-action=\"Index\">\r\n                                    ");
#nullable restore
#line 32 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"email\">User name</label>\r\n                                        ");
#nullable restore
#line 35 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                                   Write(Html.TextBoxFor(model => model.Username, new { @class = "form-control", id = "username", placeholder = "Input Your Account", }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <div class=""invalid-feedback"">
                                            Email is invalid
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""password"">
                                            Password
                                            <a href=""/Forgot/Index"" class=""float-right"" style=""font-style:italic;"">
                                                Forgot Password?
                                            </a>
                                        </label>
                                        ");
#nullable restore
#line 47 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                                   Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control", id = "password", placeholder = "Input Your PassWord", type = "password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <div class=""invalid-feedback"">
                                            Password is required
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""custom-checkbox custom-control"">
                                            ");
#nullable restore
#line 54 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                                       Write(Html.CheckBoxFor(model => model.Remember, new { @class = "custom-control-input", @id = "remember", @name = "remember", @checked = "checked" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            <label for=""remember"" class=""custom-control-label"">Remember Me</label>
                                        </div>
                                    </div>
                                    <div class=""form-group m-0"">
                                        ");
#nullable restore
#line 59 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                                   Write(Html.HiddenFor(model => model.TypeOfDevice, new { @id = "typeofdevice" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <button type=""submit"" id=""login"" class=""btn btn-primary btn-block"">
                                            Login
                                        </button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                    <div class=""footer"">
                        Copyright &copy; ");
#nullable restore
#line 69 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
                                    Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("  &mdash; Bamboo Airways\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <input type=\"hidden\" id=\"result\"");
                BeginWriteAttribute("value", " value=\"", 4402, "\"", 4423, 1);
#nullable restore
#line 76 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
WriteAttributeValue("", 4410, Model.Result, 4410, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"hidden\" id=\"error\"");
                BeginWriteAttribute("value", " value=\"", 4466, "\"", 4493, 1);
#nullable restore
#line 78 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\Mobile\Views\Home\Index.cshtml"
WriteAttributeValue("", 4474, Model.ErrorMessage, 4474, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <script src=""/js/my-login.js""></script>
    <script>

            $(function () {
                if ($(""#error"").val() !== """") {
                    alertify.alert($(""#error"").val());

                }
                if ($(""#result"").val() !== """") {
                    $('#password').val("""");

                }
                if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                    // true for mobile device
                    $(""#typeofdevice"").val(""MOBILE"");
                    document.getElementById(""texthead"").innerHTML = ""Login."";

                } else {
                    // false for not mobile device
                    $(""#typeofdevice"").val(""NONE"");
                    document.getElementById(""texthead"").innerHTML = ""Login"";

                }
            })
     </script>
    
");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
