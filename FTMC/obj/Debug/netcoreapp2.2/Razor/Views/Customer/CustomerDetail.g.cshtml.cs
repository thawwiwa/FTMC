#pragma checksum "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\CustomerDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f060184987da04327c2f559a093d6119923c29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerDetail), @"mvc.1.0.view", @"/Views/Customer/CustomerDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/CustomerDetail.cshtml", typeof(AspNetCore.Views_Customer_CustomerDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f060184987da04327c2f559a093d6119923c29", @"/Views/Customer/CustomerDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc395ba58f0788190366159dd15028a71c681a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FTMC.Models.Customer>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\CustomerDetail.cshtml"
  
    ViewData["Title"] = "CustomerDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 27, true);
            WriteLiteral("\r\n<h1>CustomerDetail</h1>\r\n");
            EndContext();
            BeginContext(211, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(215, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53f060184987da04327c2f559a093d6119923c293823", async() => {
                BeginContext(221, 18, true);
                WriteLiteral("\r\n    <div>รหัส : ");
                EndContext();
                BeginContext(240, 42, false);
#line 13 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\CustomerDetail.cshtml"
           Write(Html.DisplayFor(model => model.CustomerID));

#line default
#line hidden
                EndContext();
                BeginContext(282, 25, true);
                WriteLiteral("</div>\r\n    <div>ชื่อ  : ");
                EndContext();
                BeginContext(308, 44, false);
#line 14 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\CustomerDetail.cshtml"
            Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
                EndContext();
                BeginContext(352, 25, true);
                WriteLiteral("</div>\r\n    <div>อีเมล : ");
                EndContext();
                BeginContext(378, 45, false);
#line 15 "C:\Users\thawwiwa\source\repos\FTMC\FTMC\Views\Customer\CustomerDetail.cshtml"
            Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
                EndContext();
                BeginContext(423, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(438, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FTMC.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591