#pragma checksum "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc684b0d3c51cd3029bac0db72e9cc8434a5df8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc684b0d3c51cd3029bac0db72e9cc8434a5df8", @"/Views/Home/Movies.cshtml")]
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
            WriteLiteral("\r\n<div class=\"row col-12\">\r\n    <div class=\"col-12 d-flex justify-content-between\">\r\n        <div class=\"float-left\">\r\n            <h1 style=\"margin: 0.33em 0;\">");
#nullable restore
#line 9 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"text-nowrap\">");
#nullable restore
#line 10 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                              Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies found according to the search word; ");
#nullable restore
#line 10 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                                                                                       Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral(". 50 records</p>\r\n        </div>\r\n        <div class=\"input-group custom-search-form float-right\" style=\"justify-content: flex-end; margin: 2.33em 0; \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc684b0d3c51cd3029bac0db72e9cc8434a5df86307", async() => {
                WriteLiteral(@"
                <div class=""d-flex justify-content-between"">

                    <div id=""myDropdown"" class=""dropdown-content"">
                        <div>
                            <input name=""param"" type=""text"" class=""form-control position-absolute"" placeholder=""Search..."" id=""myInput"" onmouseover=""filterFunction()"" onmouseout=""filterClose()"" autocomplete=""off"">
                            <span class=""input-group-btn"">
                                <button id=""inputBtn"" class=""btn btn-default"" type=""submit"">
                                    <span class=""glyphicon glyphicon-search""></span>
                                </button>
                            </span>
                        </div>

                        <a id=""searchTerm1"" style=""display:none""></a>
                        <a id=""searchTerm2"" style=""display:none""></a>
                        <a id=""searchTerm3"" style=""display:none""></a>
                        <a id=""searchTerm4"" style=""display:none""></a>
      ");
                WriteLiteral("                  <a id=\"searchTerm5\" style=\"display:none\"></a>\r\n\r\n\r\n                    </div>\r\n\r\n                    <input name=\"page\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1757, "\"", 1778, 1);
#nullable restore
#line 35 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 1765, ViewBag.Page, 1765, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-12 mt-3 text-center\">\r\n        <div class=\"pagination\" id=\"pagination\">\r\n            <a id=\"page0\"");
            BeginWriteAttribute("href", " href=\"", 1977, "\"", 2024, 3);
            WriteAttributeValue("", 1984, "/home/movies?param=", 1984, 19, true);
#nullable restore
#line 43 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2003, ViewBag.Param, 2003, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2017, "&page=1", 2017, 7, true);
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a>\r\n            <a id=\"page1\"");
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2111, 3);
            WriteAttributeValue("", 2071, "/home/movies?param=", 2071, 19, true);
#nullable restore
#line 44 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2090, ViewBag.Param, 2090, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2104, "&page=1", 2104, 7, true);
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n            <a id=\"page2\"");
            BeginWriteAttribute("href", " href=\"", 2145, "\"", 2192, 3);
            WriteAttributeValue("", 2152, "/home/movies?param=", 2152, 19, true);
#nullable restore
#line 45 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2171, ViewBag.Param, 2171, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2185, "&page=2", 2185, 7, true);
            EndWriteAttribute();
            WriteLiteral(">2</a>\r\n            <a id=\"page3\"");
            BeginWriteAttribute("href", " href=\"", 2226, "\"", 2273, 3);
            WriteAttributeValue("", 2233, "/home/movies?param=", 2233, 19, true);
#nullable restore
#line 46 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2252, ViewBag.Param, 2252, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2266, "&page=3", 2266, 7, true);
            EndWriteAttribute();
            WriteLiteral(">3</a>\r\n            <a id=\"page4\"");
            BeginWriteAttribute("href", " href=\"", 2307, "\"", 2354, 3);
            WriteAttributeValue("", 2314, "/home/movies?param=", 2314, 19, true);
#nullable restore
#line 47 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2333, ViewBag.Param, 2333, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2347, "&page=4", 2347, 7, true);
            EndWriteAttribute();
            WriteLiteral(">4</a>\r\n            <a id=\"page5\"");
            BeginWriteAttribute("href", " href=\"", 2388, "\"", 2435, 3);
            WriteAttributeValue("", 2395, "/home/movies?param=", 2395, 19, true);
#nullable restore
#line 48 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2414, ViewBag.Param, 2414, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "&page=5", 2428, 7, true);
            EndWriteAttribute();
            WriteLiteral(">5</a>\r\n            <a id=\"page6\"");
            BeginWriteAttribute("href", " href=\"", 2469, "\"", 2516, 3);
            WriteAttributeValue("", 2476, "/home/movies?param=", 2476, 19, true);
#nullable restore
#line 49 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2495, ViewBag.Param, 2495, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2509, "&page=6", 2509, 7, true);
            EndWriteAttribute();
            WriteLiteral(">6</a>\r\n            <a id=\"page7\"");
            BeginWriteAttribute("href", " href=\"", 2550, "\"", 2597, 3);
            WriteAttributeValue("", 2557, "/home/movies?param=", 2557, 19, true);
#nullable restore
#line 50 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2576, ViewBag.Param, 2576, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2590, "&page=7", 2590, 7, true);
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
 foreach (var movie in Model.movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--movie-card-start-->\r\n    <div class=\"movie-card\">\r\n        <div class=\"movie-header MovieImg\"");
            BeginWriteAttribute("style", " style=\"", 2796, "\"", 2845, 3);
            WriteAttributeValue("", 2804, "background:url(\'", 2804, 16, true);
#nullable restore
#line 61 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 2820, movie.posters.original, 2820, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2843, "\')", 2843, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div><!--movie-header-->\r\n        <div class=\"movie-content\">\r\n            <div class=\"movie-content-header\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2987, "\"", 3064, 6);
            WriteAttributeValue("", 2994, "/Home/MovieDetail?id=", 2994, 21, true);
#nullable restore
#line 65 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 3015, movie.id, 3015, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3024, "&param=", 3024, 7, true);
#nullable restore
#line 65 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 3031, ViewBag.Param, 3031, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3045, "&page=", 3045, 6, true);
#nullable restore
#line 65 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
WriteAttributeValue("", 3051, ViewBag.Page, 3051, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3 class=\"movie-title\">");
#nullable restore
#line 66 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
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
#line 73 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
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
#line 86 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function ()\r\n        {\r\n            var anchorId = \"#page\" + \"");
#nullable restore
#line 92 "C:\Users\Kamil\source\repos\TodayXML\TodayXML.MVCcore\Views\Home\Movies.cshtml"
                                  Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            $(anchorId).addClass(""active"");
        });
    </script>

    <script>


        function filterFunction() {
            var input, filter, ul, li, a, i;
            input = document.getElementById(""myInput"");
            filter = input.value.toUpperCase();
            div = document.getElementById(""myDropdown"");
            a = div.getElementsByTagName(""a"");
            for (i = 0; i < a.length; i++) {
                if (a[i].text !== """") {
                    a[i].style.display = """";
                }
            }
        }

        function filterClose() {
            var input, filter, ul, li, a, i;
            input = document.getElementById(""myInput"");
            filter = input.value.toUpperCase();
            div = document.getElementById(""myDropdown"");
            a = div.getElementsByTagName(""a"");
            for (i = 0; i < a.length; i++) {
                if (a[i].text === """") {
                    /*alert(a[i].text !== null);*/
                    a");
                WriteLiteral(@"[i].style.display = ""none"";
                }
            }
        }

        var item = div = document.getElementById(""myDropdown"");
        a = div.getElementsByTagName(""a"");
        item.addEventListener(""mouseover"", func, false);
        item.addEventListener(""mouseout"", func1, false);

        function func() {
            for (i = 0; i < a.length; i++) {
                if (a[i].text !== """") {
                    a[i].style.display = """";
                }
            }
        }
        function func1() {
            for (i = 0; i < a.length; i++) {
                if (a[i].text !== """") {
                    a[i].style.display = ""none"";
                }
            }
        }
        func1();

    </script>
    <script>
        $(document).ready(function () {

            var localTermFull = localStorage.hasOwnProperty(""searchTerm5"");
            if (!localTermFull) {
                for (var i = 5; i > 0; i--) {
                    const SearchNo = ""#searchTerm"" + i.");
                WriteLiteral(@"toString();
                    const backwardNo = ""#searchTerm"" + (6 - i).toString();
                   
                    if (localStorage.hasOwnProperty(SearchNo.substring(1))) {

                        $(backwardNo).text(localStorage.getItem(SearchNo.substring(1)));
                        $(backwardNo).attr(""href"", ""/home/movies?param="" + localStorage.getItem(SearchNo.substring(1)));
                       
                    }
                }
            }
            else {
                lastValue = JSON.parse(localStorage.getItem(""Terms""));
                for (var i = 5; i >= 0; i--) {

                    const backwardNo = ""#searchTerm"" + (6 - i).toString();

                    $(backwardNo).text(lastValue[i - 1]);
                    $(backwardNo).attr(""href"", ""/home/movies?param="" + lastValue[i - 1]);

                }
            }

        });

        $(""#inputBtn"").bind(""click"", function (event) {
            event.preventDefault();

            var loca");
                WriteLiteral(@"lTerm5Full = localStorage.hasOwnProperty(""searchTerm5"");


            var counter = localStorage.counterValue || 1;
            var lastItemNo = 6;
            var backwards = (lastItemNo - counter);


            if (!localTerm5Full) {
                lstorageItemName = ""searchTerm"" + counter.toString();
            } else {
                lstorageItemName = ""searchTerm6"";
            }


            if ($(""#myInput"").val()) {


                localStorage.setItem(lstorageItemName, $(""#myInput"").val());

                var href = ""/home/movies?param="";


                switch (parseInt(counter)) {
                    case 1:
                        if (localTerm5Full) {
                            ScrollLocalStroge();
                            $(""#searchTerm1"").text(localStorage.getItem(""searchTerm1""));
                            $(""#searchTerm1"").attr(""href"", href + localStorage.getItem(""searchTerm1""));


                        } else {
                            $(");
                WriteLiteral(@"""#searchTerm5"").text(localStorage.getItem(""searchTerm1""));
                            $(""#searchTerm5"").attr(""href"", href + localStorage.getItem(""searchTerm1""));

                            localStorage.counterValue = ++counter;
                        }

                        break;
                    case 2:
                        $(""#searchTerm4"").text(localStorage.getItem(""searchTerm2""));
                        $(""#searchTerm4"").attr(""href"", href + localStorage.getItem(""searchTerm2""));

                        localStorage.counterValue = ++counter;
                        break;
                    case 3:
                        $(""#searchTerm3"").text(localStorage.getItem(""searchTerm3""));
                        $(""#searchTerm3"").attr(""href"", href + localStorage.getItem(""searchTerm3""));

                        localStorage.counterValue = ++counter;
                        break;
                    case 4:
                        $(""#searchTerm2"").text(localStorage.getItem(""se");
                WriteLiteral(@"archTerm4""));
                        $(""#searchTerm2"").attr(""href"", href + localStorage.getItem(""searchTerm4""));

                        localStorage.counterValue = ++counter;
                        break;
                    case 5:
                        $(""#searchTerm1"").text(localStorage.getItem(""searchTerm5""));
                        $(""#searchTerm1"").attr(""href"", href + localStorage.getItem(""searchTerm5""));

                        localStorage.counterValue = 1;
                        ScrollLocalStroge();
                        break;
                }

                function ScrollLocalStroge() {
                   
                    let a = 1;
                    var lastValue = [];

                    while (a <= 6) {
                      
                        if (lastValue.length < 5) {
                            lastValue.push(localStorage.getItem(""searchTerm"" + a.toString()));
                        }
                        else {
                       ");
                WriteLiteral(@"     if (localStorage.hasOwnProperty(""searchTerm6"")) {
                               
                                lastValue.push(localStorage.getItem(""searchTerm6""));
                                lastValue.shift();
                            }

                        }
                        a++;
                    }
                    localStorage.setItem(""Terms"", JSON.stringify(lastValue));
                    lastValue = JSON.parse(localStorage.getItem(""Terms""));

                    var b = 1;
                    if (lastValue.length >= 5) {
                       
                        while (b <= 5) {
                            localStorage.setItem(""searchTerm"" + (b).toString(), lastValue[b - 1]);
                            b++;
                        }
                      
                    }
                }

            }

            $(this).unbind(event);

            setTimeout(function () { $(""#inputBtn"").click(); }, 500);
        });
    </scri");
                WriteLiteral("pt>\r\n");
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
