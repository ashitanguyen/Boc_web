#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09905a9c2ecfecd31185926cd210768cf8c3c5df"
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
#line 12 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
using BOC.Areas.BaggageMiss.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09905a9c2ecfecd31185926cd210768cf8c3c5df", @"/Areas/BaggageMiss/Views/Profiles/Index.cshtml")]
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
    var stage = @HttpContextAccessor.HttpContext.Session.GetString("Status");


#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""row"" style=""margin-left:20px;"">
    <div class=""col-sm-5""><img src=""/images/logo.png"" style=""width:184px;height:45px;"" alt=""logo""></div>
    <div class=""col-sm-9"" style=""float:right"">
        <a href=""#"" id=""vn""><img src=""/images/vn.png"" width=""24"" height=""30"" /></a>
        <a href=""#"" id=""en""><img src=""/images/en.png"" width=""20"" height=""20"" /></a>
    </div>
    <div class=""col-sm-12"" style=""text-align:center;"">
            
            <h4 id=""texthead"" class=""card-title""></h4>
            <div>PNR: ");
#nullable restore
#line 29 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                 Write(ViewBag.PNR.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>FltNo: ");
#nullable restore
#line 30 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                   Write(ViewBag.FltNo.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n\r\n    \r\n</div>\r\n\r\n<div class=\"table-responsive\">\r\n    <table class=\"tableprofile table-bordered\"  id=\"tableProfile\">\r\n");
#nullable restore
#line 38 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
         if (select == "VN")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <thead>
                <tr>
                    <th class=""sticky-col first-col"" style=""width: 5%;""></th>
                    <th class=""sticky-col second-col"" style=""width: 5%"">STT</th>
                    <th scope=""col"" style=""width: 20%;"">M?? h??? s??</th>
                    <th scope=""col"" style=""width: 20%;"">H??? T??n</th>
                    <th scope=""col"" style=""width: 30%"">?????a Ch???</th>
                    <th scope=""col"" style=""width: 10%"">Email</th>
                    <th scope=""col"" style=""width: 10%"">S??T</th>

                </tr>
            </thead>
");
#nullable restore
#line 52 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <thead>
                <tr>
                    <th class=""sticky-col first-col"" style=""width: 5%;""></th>
                    <th class=""sticky-col second-col"" style=""width: 5%;"">ID</th>
                    <th scope=""col""  style=""width: 20%;"">Profile Number</th>
                    <th scope=""col"" style=""width: 20%;"">FullName</th>
                    <th scope=""col"" style=""width: 30%;"">Address</th>
                    <th scope=""col"" style=""width: 10%"">Email</th>
                    <th scope=""col"" style=""width: 10%;"">Phone</th>

                </tr>
            </thead>
");
#nullable restore
#line 67 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
         foreach (var item in ViewBag.ProfileDescLst)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr style=\"word-wrap: break-word;\">\r\n                    <th class=\"sticky-col first-col\" style=\"width: 5%;\">\r\n                        <a class=\"edit\" id=\"EditProfile\" href=\"#\" data-bb=\"");
#nullable restore
#line 75 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                                      Write(item.BagMiss_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><img src=\"/images/edit.png\" width=\"20\" height=\"20\" /></a>\r\n                    </th>\r\n                    <th class=\"sticky-col second-col\" style=\"width: 5%;\">");
#nullable restore
#line 77 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                                    Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th style=\"width: 20%;\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                   Write(item.ProfileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n");
#nullable restore
#line 81 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                         if (item.Status == "CL" && select == "EN")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small style=\"font-style: italic; color: #4EBDEC!important;\">Completed</small>\r\n");
#nullable restore
#line 84 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                         if (item.Status == "CL" && select == "VN")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small style=\"font-style:italic;color:#4EBDEC!important;\">???? ho??n th??nh</small>\r\n");
#nullable restore
#line 88 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                         if (item.Status != "CL" && select == "EN")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small style=\"font-style: italic; color: #E2AE14!important;\">Not yet</small>\r\n");
#nullable restore
#line 92 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                         if (item.Status != "CL" && select == "VN")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small style=\"font-style: italic; color:#E2AE14!important;\">Ch??a ho??n th??nh</small>\r\n");
#nullable restore
#line 96 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </th>\r\n                    <th style=\"width: 20%;\">");
#nullable restore
#line 98 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td class=\"col\" style=\"width: 30%;\">");
#nullable restore
#line 99 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\" style=\"width: 10%;\">");
#nullable restore
#line 100 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col\" style=\"width: 10%;\">");
#nullable restore
#line 101 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 105 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 112 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
     if (select == "EN")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <button type=\"button\" class=\"btn btn-primary\" id=\"CreateProfile\" style=\"margin-left:50px;margin-top:10px;\">New Profile</button>\r\n");
#nullable restore
#line 115 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\" id=\"CreateProfile\" style=\"margin-left:50px;margin-top:10px;\">T???o h??? s?? m???i</button>\r\n");
#nullable restore
#line 119 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n<br />\r\n\r\n<input type=\"hidden\" id=\"langselect\"");
            BeginWriteAttribute("value", " value=\"", 4917, "\"", 4932, 1);
#nullable restore
#line 125 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Areas\BaggageMiss\Views\Profiles\Index.cshtml"
WriteAttributeValue("", 4925, select, 4925, 7, false);

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
            window.location.href = _subFolder + ""/Pages/Index?t_flag="" + lang + ""&t_bagmiss_id=0"";

        });

        $(""a.edit"").bind('touchstart click', function () {

            ////Check ki???m tra radio c?? ???????c ch???n hay kh??ng?
            //var radios = document.querySelectorAll('input[type=""radio""]:checked');
            //var BagMissDetail_ID = radios.length > 0 ? radios[0].value : null;
            var BagMiss_ID = $(this).attr(""data-bb"");
            if (BagMiss_ID != null) {
                window.location.href = _subFolder + ""/Pages/Index?t_flag="" + lang + ""&t_bagmiss_id="" + BagMiss_ID;
            }
       ");
            WriteLiteral(@"     else {
                alertify.alert(""Please select your profile."");
            }

        });

        $(""#CreateProfile"").bind('touchstart click', function () {


            window.location.href = _subFolder + ""/Pages/Index?t_flag="" + lang + ""&t_bagmiss_id="" + 0 + ""&t_action="" + 0;


        });



    })
</script>


");
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
