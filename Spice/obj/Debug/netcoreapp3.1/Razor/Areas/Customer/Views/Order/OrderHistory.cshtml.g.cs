#pragma checksum "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af382e7bf345f7df308cf157f94943b8eb2d031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af382e7bf345f7df308cf157f94943b8eb2d031", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Spice.Models.ViewModels.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
   
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br /><br />\r\n<div class=\"border backgroundWhite\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<h2 class=\"text-info\"> Category List</h2>\r\n\t\t</div>\r\n\t\t<div class=\"col-6 text-right\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2af382e7bf345f7df308cf157f94943b8eb2d0314074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<br />\r\n\t<div>\r\n");
#nullable restore
#line 20 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if(Model.Count() > 0)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<table class=\"table table-striped border\">\r\n\t\t\t<tr class=\"table-secondary\">\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 25 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(k => k.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 28 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(k => k.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 31 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(k => k.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 34 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(k => k.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 37 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(k => k.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\tTotal Time\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\r\n");
#nullable restore
#line 44 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 48 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(k => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 51 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(k => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 54 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(k => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 57 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(k => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
#nullable restore
#line 60 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayFor(k => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\tTotal Time\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 66 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</table>\r\n");
#nullable restore
#line 68 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<p>No category exists...</p>\r\n");
#nullable restore
#line 72 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Spice.Models.ViewModels.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591