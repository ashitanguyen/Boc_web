#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7938d87669fd648bb78eab6fb0811c2b9bab49a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BaggageMiss_Views_Profiles_Index), @"mvc.1.0.view", @"/Areas/BaggageMiss/Views/Profiles/Index.cshtml")]
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
#line 10 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using BOC.Areas.BaggageMiss.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7938d87669fd648bb78eab6fb0811c2b9bab49a", @"/Areas/BaggageMiss/Views/Profiles/Index.cshtml")]
    public class Areas_BaggageMiss_Views_Profiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/BaggageMiss/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
  

    var select = @HttpContextAccessor.HttpContext.Session.GetString("Lang") == null ? "VN" : @HttpContextAccessor.HttpContext.Session.GetString("Lang");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    table {
        border-collapse: collapse;
        border-spacing: 0;
        width: 96% !important;
        border: 1px solid #ddd;
    }

    th, td {
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #f2f2f2
    }
</style>

<div class=""row"" style=""margin-left:20px;"">
    <div class=""col-sm-5""><img src=""/images/logo.png"" style=""width:184px;height:45px;"" alt=""logo""></div>
    <div class=""col-sm-9"" style=""float:right"">
        <a href=""#"" id=""vn""><img src=""/images/vn.png"" width=""24"" height=""30"" /></a>
        <a href=""#"" id=""en""><img src=""/images/en.png"" width=""20"" height=""20"" /></a>
    </div>
    <div class=""col-sm-12""><h4 id=""texthead"" class=""card-title"" style=""text-align:center;color:#00548E;font-family:sans-serif;padding-top:40px;""></h4></div>
</div>
<div class=""row"" style=""margin-left:2px;"">
    <table class=""table table-bordered"" style=""table-layout:fixed; width:90%""  id=""tableProfile"">
");
#nullable restore
#line 44 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
         if (select == "VN")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <thead>
                <tr>
                    <th scope=""col"" style=""width: 50px!important;"">STT</th>
                    <th scope=""col"" style=""width: 52px!important;"">M?? h??? s??</th>
                    <th scope=""col"" style=""width: 150px!important;"">H??? T??n</th>
                    <th scope=""col"" style=""width: 200px!important;"">?????a Ch???</th>
                    <th scope=""col"" style=""width: 150px!important;"">Email</th>
                    <th scope=""col"" style=""width: 120px!important;"">S??T</th>
                    <th scope=""col"" style=""width: 50px!important;""></th>
                </tr>
            </thead>
");
#nullable restore
#line 57 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <thead>
                <tr>
                    <th scope=""col"" style=""width: 50px!important;"">ID</th>
                    <th scope=""col"">MissBagID</th>
                    <th scope=""col"" style=""width: 150px!important;"">FullName</th>
                    <th scope=""col"" style=""width: 200px!important;"">Address</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Phone</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
");
#nullable restore
#line 71 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
         foreach (var item in ViewBag.ProfileDescLst)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr style=\"word-wrap: break-word;\">\r\n                    <th class=\"col\" style=\"width: 50px!important;\">");
#nullable restore
#line 78 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                              Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td class=\"col\">");
#nullable restore
#line 79 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                               Write(item.BagMiss_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\">");
#nullable restore
#line 80 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\">");
#nullable restore
#line 81 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\">");
#nullable restore
#line 82 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\">");
#nullable restore
#line 83 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"edit\" id=\"EditProfile\" href=\"#\" data-bb=\"");
#nullable restore
#line 85 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                                      Write(item.BagMiss_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><img src=\"/images/edit.png\" width=\"20\" height=\"20\" /></a>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 89 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n<div class=\"row\" style=\"margin-left:500px;\">\r\n");
#nullable restore
#line 95 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
     if (select == "EN")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\" id=\"CreateProfile\" style=\"float:right!important;margin-left: 170px;\">New Profile</button>\r\n");
#nullable restore
#line 98 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\" id=\"CreateProfile\" style=\"float:right!important;margin-left: 150px;\">T???o h??? s?? m???i</button>\r\n");
#nullable restore
#line 102 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<input type=\"hidden\" id=\"langselect\"");
            BeginWriteAttribute("value", " value=\"", 3946, "\"", 3961, 1);
#nullable restore
#line 107 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
WriteAttributeValue("", 3954, select, 3954, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<script>
    $(function () {
        var lang = $(""#langselect"").val() == null ? ""VN"" : $(""#langselect"").val();

        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
            // true for mobile device
            $(""#typeofdevice"").val(""MOBILE"");
            if (lang == ""VN"" || lang == """") {
                document.getElementById(""texthead"").innerHTML = ""Vui l??ng ch???n h??? s?? c???a b???n."";
            }
            else {
                document.getElementById(""texthead"").innerHTML = ""Please choose your miss baggage profile."";
            }


        } else {
            // false for not mobile device
            $(""#typeofdevice"").val(""NONE"");
            if (lang == ""VN"" || lang == """") {
                document.getElementById(""texthead"").innerHTML = ""Vui l??ng ch???n h??? s?? c???a b???n"";
            }
            else {
                document.getElementById(""texthead"").innerHTML = ""Please choose your miss baggage profile"";
       ");
            WriteLiteral(@"     }

        }

        $(""a#vn"").bind('touchstart click', function () {
            window.location.href = _subFolder + ""/Profiles/SetLang?id=VN"";
        });
        $(""a#en"").bind('touchstart click', function () {
            window.location.href = _subFolder + ""/Profiles/SetLang?id=EN"";
        });
        $("".btn-primary"").bind('touchstart click', function () {
            window.location.href = _subFolder + ""/Pages/Index?flag="" + lang + ""&bagmissdetail_id=0"";

        });

        $(""a.edit"").bind('touchstart click', function (){

            ////Check ki???m tra radio c?? ???????c ch???n hay kh??ng?
            //var radios = document.querySelectorAll('input[type=""radio""]:checked');
            //var BagMissDetail_ID = radios.length > 0 ? radios[0].value : null;
            var BagMissDetail_ID = $(this).attr(""data-bb"");
            if (BagMissDetail_ID != null) {
                window.location.href = _subFolder + ""/Pages/Index?flag="" + lang + ""&bagmissdetail_id="" + BagMissDetail_ID;
 ");
            WriteLiteral("           }\r\n            else {\r\n                alertify.alert(\"Please select your profile.\");\r\n            }\r\n\r\n        });\r\n    })\r\n</script>\r\n\r\n\r\n");
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
