#pragma checksum "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9fb1be7e3da66d51e0df2121a5fa306578bd924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Movies), @"mvc.1.0.view", @"/Views/Home/Movies.cshtml")]
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
#line 1 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using TodayXML.MVCcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using TodayXML.MVCcore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using TodayXML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using TodayXML.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using TodayXML.Serializer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\_ViewImports.cshtml"
using RottenTomatoes.Movie.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9fb1be7e3da66d51e0df2121a5fa306578bd924", @"/Views/Home/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d6a502e8fd46fe88fe4ef84c268aaff7930849", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rootobject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
  
    ViewData["Title"] = "Movie'S";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row col-12\">\r\n    <div class=\"col-12\">\r\n        <h1>");
#nullable restore
#line 8 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
      Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies found according to the search word; ");
#nullable restore
#line 9 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                                                               Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral(". 50 records</p>\r\n\r\n        <div class=\"input-group custom-search-form\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9fb1be7e3da66d51e0df2121a5fa306578bd9246018", async() => {
                WriteLiteral(@"
                <div class=""d-flex justify-content-between"">
                    <input name=""param"" type=""text"" class=""form-control"">

                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"" type=""submit"">
                            <span class=""glyphicon glyphicon-search""></span>
                        </button>
                    </span>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12 mt-3 text-center\">\r\n        <div class=\"pagination\" id=\"pagination\">\r\n            <a id=\"page0\"");
            BeginWriteAttribute("href", " href=\"", 983, "\"", 1030, 3);
            WriteAttributeValue("", 990, "/home/movies?param=", 990, 19, true);
#nullable restore
#line 28 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1009, ViewBag.Param, 1009, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1023, "&page=1", 1023, 7, true);
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a>\r\n            <a id=\"page1\"");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1117, 3);
            WriteAttributeValue("", 1077, "/home/movies?param=", 1077, 19, true);
#nullable restore
#line 29 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1096, ViewBag.Param, 1096, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1110, "&page=1", 1110, 7, true);
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n            <a id=\"page2\"");
            BeginWriteAttribute("href", " href=\"", 1151, "\"", 1198, 3);
            WriteAttributeValue("", 1158, "/home/movies?param=", 1158, 19, true);
#nullable restore
#line 30 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1177, ViewBag.Param, 1177, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1191, "&page=2", 1191, 7, true);
            EndWriteAttribute();
            WriteLiteral(">2</a>\r\n            <a id=\"page3\"");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1279, 3);
            WriteAttributeValue("", 1239, "/home/movies?param=", 1239, 19, true);
#nullable restore
#line 31 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1258, ViewBag.Param, 1258, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1272, "&page=3", 1272, 7, true);
            EndWriteAttribute();
            WriteLiteral(">3</a>\r\n            <a id=\"page4\"");
            BeginWriteAttribute("href", " href=\"", 1313, "\"", 1360, 3);
            WriteAttributeValue("", 1320, "/home/movies?param=", 1320, 19, true);
#nullable restore
#line 32 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1339, ViewBag.Param, 1339, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1353, "&page=4", 1353, 7, true);
            EndWriteAttribute();
            WriteLiteral(">4</a>\r\n            <a id=\"page5\"");
            BeginWriteAttribute("href", " href=\"", 1394, "\"", 1441, 3);
            WriteAttributeValue("", 1401, "/home/movies?param=", 1401, 19, true);
#nullable restore
#line 33 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1420, ViewBag.Param, 1420, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1434, "&page=5", 1434, 7, true);
            EndWriteAttribute();
            WriteLiteral(">5</a>\r\n            <a id=\"page6\"");
            BeginWriteAttribute("href", " href=\"", 1475, "\"", 1522, 3);
            WriteAttributeValue("", 1482, "/home/movies?param=", 1482, 19, true);
#nullable restore
#line 34 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1501, ViewBag.Param, 1501, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1515, "&page=6", 1515, 7, true);
            EndWriteAttribute();
            WriteLiteral(">6</a>\r\n            <a id=\"page7\"");
            BeginWriteAttribute("href", " href=\"", 1556, "\"", 1603, 3);
            WriteAttributeValue("", 1563, "/home/movies?param=", 1563, 19, true);
#nullable restore
#line 35 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1582, ViewBag.Param, 1582, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1596, "&page=7", 1596, 7, true);
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
 foreach (var movie in Model.movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--movie-card-start-->\r\n    <div class=\"movie-card\">\r\n        <div class=\"movie-header MovieImg\"");
            BeginWriteAttribute("style", " style=\"", 1802, "\"", 1851, 3);
            WriteAttributeValue("", 1810, "background:url(\'", 1810, 16, true);
#nullable restore
#line 46 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1826, movie.posters.original, 1826, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1849, "\')", 1849, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        </div><!--movie-header-->\r\n        <div class=\"movie-content\">\r\n            <div class=\"movie-content-header\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1995, "\"", 2029, 2);
            WriteAttributeValue("", 2002, "/Home/MovieDetail/", 2002, 18, true);
#nullable restore
#line 51 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2020, movie.id, 2020, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3 class=\"movie-title\">");
#nullable restore
#line 52 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                                       Write(movie.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </a>
                <div class=""imax-logo""></div>
            </div>
            <div class=""movie-info"">
                <div class=""info-section"">
                    <label>Releases Date & Time</label>
                    <span>");
#nullable restore
#line 59 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                     Write(movie.release_dates.theater);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div><!--date,time-->
                <div class=""info-section"">
                    <label>Screen</label>
                    <span>06</span>
                </div><!--screen-->
                <div class=""info-section"">
                    <label>Seat</label>
                    <span>05,06</span>
                </div><!--seat-->
            </div>
        </div><!--movie-content-->
    </div><!--movie-card-->
");
#nullable restore
#line 72 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $( document ).ready(function() {\r\n    var anchorId = \"#page\" + \"");
#nullable restore
#line 77 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                          Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n   $(anchorId).addClass(\"active\");\r\n    });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rootobject> Html { get; private set; }
    }
}
#pragma warning restore 1591