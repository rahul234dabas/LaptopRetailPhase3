#pragma checksum "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716685f1d09cd65b02a5ca72bd746482b002fec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserCustomer_details), @"mvc.1.0.view", @"/Views/UserCustomer/details.cshtml")]
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
#line 1 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\_ViewImports.cshtml"
using LaptopRetailPhase3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\_ViewImports.cshtml"
using LaptopRetailPhase3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716685f1d09cd65b02a5ca72bd746482b002fec0", @"/Views/UserCustomer/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18571bfbc71069b071847e3468fcafeb73ef8ec", @"/Views/_ViewImports.cshtml")]
    public class Views_UserCustomer_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaptopRetailPhase3.Models.TblLaptop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details of Customer</h1>\r\n\r\n<div>\r\n    <h4>TblLaptop</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.Sno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.LaptopName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.LaptopName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.ModelNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Processor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.Processor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\11036428\source\repos\LaptopRetailPhase3\LaptopRetailPhase3\Views\UserCustomer\details.cshtml"
       Write(Html.DisplayFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716685f1d09cd65b02a5ca72bd746482b002fec08671", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaptopRetailPhase3.Models.TblLaptop> Html { get; private set; }
    }
}
#pragma warning restore 1591
