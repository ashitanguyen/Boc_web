#pragma checksum "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "635f70e2127816f7eb416f9219d837dd3c5ff0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlightDate_Index), @"mvc.1.0.view", @"/Views/FlightDate/Index.cshtml")]
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
#line 7 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
using BOC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
using BOC.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635f70e2127816f7eb416f9219d837dd3c5ff0b9", @"/Views/FlightDate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bd3e559f0a79a0d6a90e442bed2631b5d65b52", @"/Views/_ViewImports.cshtml")]
    public class Views_FlightDate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoungeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmFlightDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FlightDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout4Boc.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<style>
    fieldset {
        border: 1px solid #ddd !important;
        margin: 0;
        min-width: 0;
        padding: 10px;
        position: relative;
        border-radius: 4px;
        background-color: #f5f5f5;
        padding-left: 10px !important;
    }

    legend {
        font-size: 14px;
        font-weight: bold;
        margin-bottom: 0px;
        width: 35%;
        border: 1px solid #ddd;
        border-radius: 4px;
        padding: 5px 5px 5px 10px;
        background-color: #ffffff;
    }

    .dx-fieldset {
        height: 500px;
    }

    .dx-texteditor-container {
        width: 400px;
    }
</style>

<div class=""container"" style=""padding-top:60px;"">

    <div class=""panel panel-default"">

        <div class=""panel-body"" style=""padding-left:10px;"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "635f70e2127816f7eb416f9219d837dd3c5ff0b97237", async() => {
                WriteLiteral(@"
                <fieldset class=""col-md-6"">
                    <legend>Flight Filter</legend>

                    <div class=""panel panel-default"">
                        <div class=""panel-body"">
                            <div class=""row"">
                                &ensp;&ensp; Station:&ensp;&ensp;&ensp;&ensp;&ensp;
                                ");
#nullable restore
#line 58 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                            Write(Html.DevExtreme().DropDownBoxFor(model => model.AirportChoose)
    .ID("dropDownBox")
    .ValueExpr("ID")
    .DisplayExpr(new JS("gridBox_displayExpr"))
    .DataSource(d => d.Mvc()
        .Controller("FlightDate/Detail")
        .LoadAction("Post")
        .LoadMode(DataSourceLoadMode.Raw)
        .Key(Model.AirportChoose)
    )
    .Width("380")
    .Placeholder("Select Your Station....")
    .ShowClearButton(true)
    .OnValueChanged("gridBox_valueChanged")
    .ContentTemplate(new TemplateName("EmbeddedDataGridSingle"))
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                 using (Html.DevExtreme().NamedTemplate("EmbeddedDataGridSingle"))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                Write(Html.DevExtreme().DataGrid()
                .ID("embedded-datagrid")
                .DataSource(Model.ListAirport, "Airport")
                .Columns(columns => {
                    columns.Add().DataField("Airport").Width(0);
                    columns.Add().DataField("AirportName");
                    columns.Add().DataField("CityName");
                    columns.Add().DataField("CountryName");
                })
                .HoverStateEnabled(true)
                .Paging(p => p.PageSize(10))
                .FilterRow(f => f.Visible(true))
                .Scrolling(s => s.Mode(GridScrollingMode.Infinite))
                .Height(345)
                .Width(380)
                .Selection(s => s.Mode(SelectionMode.Single))
                //.SelectedRowKeys(new JS(@"[component.option(""key"")]"))
                .SelectedRowKeys(Model.AirportChoose)
                .OnSelectionChanged(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        function(selectedItems) {\r\n                            var keys = selectedItems.selectedRowKeys;\r\n                            component.option(\"value\", keys);\r\n\r\n                          }\r\n                    ");
    PopWriter();
}
))
                );

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                 
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div><br />\r\n                                  <div class=\"row\">\r\n                                      &ensp;&ensp; Date:&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;");
#nullable restore
#line 107 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                                                                             Write(Html.TextBoxFor(model => model.Date,
new { placeholder = "dd/mm/yyyy", id = "datepicker", style = "width:380px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                                  </div>\r\n                            <br />\r\n                            <div class=\"row\">\r\n                                &ensp;&ensp; Route Type:&ensp;\r\n                                ");
#nullable restore
#line 115 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                           Write(Html.DropDownListFor(model => model.SelectedRouting, new SelectList((IEnumerable<SelectListItem>)ViewBag.List, "Value", "Text"), new { @class = "dropdown" , style = "width:380px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                            </div><br />\r\n                            <div class=\"row\">&ensp;&ensp; Key Search:&ensp;");
#nullable restore
#line 120 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                                                      Write(Html.TextBoxFor(model => model.Key,new { style = "width:380px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div><br />
                            <div class=""row"">
                                &ensp;&ensp; Time Zone:&ensp;&ensp;
                                <input type=""checkbox"" name=""check"" value=""HAN"" checked onclick=""onlyOne(this)""> &ensp;&ensp;HAN&ensp;&ensp;
                                <input type=""checkbox"" name=""check"" value=""UTC"" onclick=""onlyOne(this)"">&ensp;&ensp;UTC&ensp;&ensp;
                                <input type=""checkbox"" name=""check"" value=""LOCAL"" onclick=""onlyOne(this)"">&ensp;&ensp;LOCAL&ensp;&ensp;

                                ");
#nullable restore
#line 127 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                           Write(Html.HiddenFor(model => model.TimeZone, new { @id = "TimeZone" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div><br />\r\n                                  <div class=\"row\">&ensp;&ensp;View Type:&ensp;&ensp;");
#nullable restore
#line 129 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                                                                Write(Html.TextBoxFor(model => model.ViewType, new { style = "width:380px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br />\r\n                            <div class=\"row\">&ensp;&ensp;");
#nullable restore
#line 130 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
                                                    Write(Html.CheckBoxFor(model => model.AutoHide));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" &ensp;&ensp;Auto Hide&ensp;&ensp;</div>
                            <input type=""submit"" id=""filter"" value=""OK"" class=""btn btn-primary"" style=""float:right"" />

                        </div>
                    </div>

                </fieldset>

                <div class=""clearfix""></div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>-\r\n\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"error\"");
            BeginWriteAttribute("value", " value=\"", 6159, "\"", 6186, 1);
#nullable restore
#line 144 "C:\Users\Nhat Nguyen\Desktop\BOC_UP_FINAL\BOC\Views\FlightDate\Index.cshtml"
WriteAttributeValue("", 6167, Model.ErrorMessage, 6167, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "635f70e2127816f7eb416f9219d837dd3c5ff0b916946", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "635f70e2127816f7eb416f9219d837dd3c5ff0b917986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    /*Format datepicker bootstrap*/
  
    $('#datepicker').datepicker({
        weekStart: 1,
        daysOfWeekHighlighted: ""6,0"",
        autoclose: true,
        todayHighlight: true,
        format: 'dd/mm/yyyy'
       

    });

    $('#datepicker').datepicker(""setDate"", new Date());

    function onlyOne(checkbox) {
        var checkboxes = document.getElementsByName('check')
        checkboxes.forEach((item) => {
            if (item !== checkbox) item.checked = false
        })
        //Bind value timezone checked
        $.each($(""input[name='check']:checked""), function () {
            $('#TimeZone').val($(this).val());

        });

    }




    function gridBox_valueChanged(e) {
        let element = document.getElementById(""embedded-datagrid"");
        let instance = DevExpress.ui.dxAccordion.getInstance(element);
        if (element.length) {
            var dataGrid = element.dxDataGrid(instance);
            dataGrid.sele");
            WriteLiteral(@"ctRows(e.value, false);

        }
    }

    function gridBox_displayExpr(item) {
        return item && item.Airport;

    }

    $(function () {
        if ($(""#error"").val() !== """") {
            alertify.alert($(""#error"").val());

        }
    
    })





</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoungeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
