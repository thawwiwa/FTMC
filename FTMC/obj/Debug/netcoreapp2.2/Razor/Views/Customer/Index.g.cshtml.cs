#pragma checksum "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba71bcdfe06e9cac012a282e70369f095afeb98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\_ViewImports.cshtml"
using FTMC;

#line default
#line hidden
#line 2 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\_ViewImports.cshtml"
using FTMC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ba71bcdfe06e9cac012a282e70369f095afeb98", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc395ba58f0788190366159dd15028a71c681a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FTMC.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 198, true);
            WriteLiteral("\r\n<h1>This Customer ViewIndex</h1>\r\n\r\n<h2>Table Customer</h2>\r\n\r\n<button>ORDER BY ASC</button>\r\n<button>ORDER By DESC</button>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(329, 46, false);
#line 18 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerID));

#line default
#line hidden
            EndContext();
            BeginContext(375, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(399, 48, false);
#line 19 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(447, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(471, 49, false);
#line 20 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(520, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(544, 50, false);
#line 21 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerBudget));

#line default
#line hidden
            EndContext();
            BeginContext(594, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(618, 48, false);
#line 22 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerUsed));

#line default
#line hidden
            EndContext();
            BeginContext(666, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(690, 47, false);
#line 23 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(737, 49, true);
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(835, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(874, 45, false);
#line 30 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
            EndContext();
            BeginContext(919, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(947, 47, false);
#line 31 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(994, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1022, 48, false);
#line 32 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1098, 49, false);
#line 33 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerBudget));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1175, 47, false);
#line 34 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerUsed));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1250, 46, false);
#line 35 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryCode));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1333, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1378, 258, true);
                WriteLiteral(@" 
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"" type=""text/javascript""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            alert(""Hello"");
        });

    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FTMC.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
