#pragma checksum "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e965"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Summary), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
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
#nullable restore
#line 2 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
using Spice.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e965", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderDetailsCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("userId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtPhone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("datepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("timepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
  
	ViewData["Title"] = "Summary";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e9659362", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
     if (Model.ListCart.Count > 0)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<br />\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e9659884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ListCart[0].ApplicationUserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
		<div class=""backgroundWhiteBorder"">
			<div class=""container"">
				<div class=""card"">
					<div class=""card-header bg-dark text-light m1-0 row container"">
						<div class=""col-6"">
							<i class=""fa fa-shopping-cart""></i> &nbsp;
							Order Summary
						</div>
						<div class=""col-6 text-right"">
							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96512141", async() => {
                    WriteLiteral("Back to Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
						</div>
					</div>
					<div class=""card-body"">
						<div class=""contianer rounded p-2"">
							<div class=""row"">
								<div class=""col-12 col-lg-6 pb-4"">
									<div class=""row"">
										<h4 class=""d-flex justify-content-between align-items-center mb-3"">
											<span class=""text-info"">PickUp Details:</span>
										</h4>
									</div>
									<div class=""row my-1"">
										<div class=""col-3"">
											<label>Name</label>
										</div>
										<div class=""col-9"">
											");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96514421", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickupName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"row my-1\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>Phone</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-9\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96516613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 49 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"row my-1\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>Date</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-9\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96518805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 57 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickUpDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"row my-1\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>Time</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-9\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96521206", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 65 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickUpTime);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"row my-1\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>Additional Instructions: </label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-9\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb1f95f78ae4e5fbda2e737ff1eefbc31c3e96523629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 73 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.Comments);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
										</div>
									</div>
								</div>

								<!-- Right Hand Component -->
								<div class=""col-12 col-lg-5 offset-lg-1"">
									<h4 class=""d-flex justify-content-between align-items-center mb-3"">
										<span class=""text-info"">Order Summary: </span>
									</h4>
									<ul class=""list-group mb-3"">
");
#nullable restore
#line 84 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                           var total = 0.0; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 86 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                         foreach (var details in Model.ListCart)
										{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<li class=\"list-group-item d-flex justify-content-between\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h6 class=\"my-0\">");
#nullable restore
#line 90 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                            Write(details.MenuItem.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<small class=\"text-muted\">Quantity: ");
#nullable restore
#line 91 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                               Write(details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 93 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                              
												var itemTotal = details.MenuItem.Price * details.Count;
											

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<span class=\"text-muted\">$");
#nullable restore
#line 96 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                  Write(itemTotal.ToString("n2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 97 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                               total += (details.MenuItem.Price * details.Count); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 99 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
													}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 101 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                         if (Model.OrderHeader.CouponCode != null)
										{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<li class=\"list-group-item d-flex justify-content-between\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"text-success\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<h6 class=\"my-0\">Promo Code</h6>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small class=\"text-success\">");
#nullable restore
#line 106 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                           Write(Model.OrderHeader.CouponCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 108 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                  
													var orderTotal = total - Model.OrderHeader.OrderTotal;
												

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"text-success\">-$");
#nullable restore
#line 111 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                         Write(orderTotal.ToString("n2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 113 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
										}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n\t\t\t\t\t\t\t\t\t\t\t<small class=\"text-info\">Total (NZD)</small>\r\n\t\t\t\t\t\t\t\t\t\t\t<strong class=\"text-info\">$");
#nullable restore
#line 116 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                   Write(Model.OrderHeader.OrderTotal.ToString("n2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t<div class=\"col-12 col-md-4 offset-md-8\">\r\n");
#nullable restore
#line 126 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                   
									// Stripe uses cents
									var OrderTotalForStripe = Model.OrderHeader.OrderTotal * 100;
								

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<script src=\"https://checkout.stripe.com/checkout.js\" class=\"stripe-button\" \r\n\t\t\t\t\t\t\t\t\t\t\tdata-key=");
#nullable restore
#line 132 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                Write(StripeSettings.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n\t\t\t\t\t\t\t\t\t\t\tdata-amount=\"");
#nullable restore
#line 133 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
                                                    Write(OrderTotalForStripe);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" 
											data-name=""Spice Restaurant""
											data-label=""Place Order""
											data-description=""Mmmmmmm... Food"" 
											data-locale=""auto""
											data-allow-remember-me=""false""
											data-image=""https://stripe.com/img/documentation/checkout/marketplace.png"">
									</script>

								<script>
									document.getElementsByClassName(""stripe-button-el"")[0].style.display = 'none';
								</script>
								<button type=""submit"" id=""btnPlaceOrder"" onclick=""return validateInput()"" value=""Place Order"" class=""btn btn-success form-control"">
									Place Order
								</button>
							</div>
						</div>
					</div>

				</div>
			</div>
		</div>
");
#nullable restore
#line 155 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<div class=\"backgroundWhiteBorder\"> No items added to the shopping cart...</div>\r\n");
#nullable restore
#line 159 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Cart\Summary.cshtml"
	}

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-timepicker/1.13.18/jquery.timepicker.js""></script>

	<script>
		$(function () {
			var minDate = 0;
			var currentDate = new Date();

			if (currentDate.getHours() >= 20) {
				minDate = 1;
			}
			$(""#datepicker"").datepicker({ minDate: minDate, maxDate: ""+1W"", dateFormat: ""dd/mm/yy"" });
			$(""#timepicker"").timepicker({ 'minTime': '10:00 AM', 'maxTime': '9:00 PM', step: '30' })
		});

		function setPickUpTime() {
			var dateSelected = document.getElementById(""datepicker"").value;
			var dt = new Date(dateSelected);
			var today = new Date();
			dt.setHours(0, 0, 0, 0);
			if (dt > today) {
				selectedTime = '10:00am';
			}
			else {
				selectedTime = getTimeFromCurrentDate();
			}
			$('#timepicker').timepicker('option', 'minTime', selectedTime);
		}

		function getTimeFromCurrentDate() {
			var curDt = new Date();
			var minTime = """";
			if (curDt.getHours() < 10) {
				minTime = '11:00am';
			}
			else {
				");
                WriteLiteral(@"if (curDt.getMinutes() < 30) {
					minTime = (curDt.getHours() + 1).toString() + ':30pm'
				}
				else {
					minTime = (curDt.getHours() + 2).toString() + ':00pm'
				}
			}
			return minTime;
		}

		$('#datepicker').change(function () {
			setPickUpTime();
		});

		function validateInput() {
			var time = document.getElementById(""timepicker"").value;
			var date = document.getElementById(""datepicker"").value;
			var name = document.getElementById(""txtName"").value;
			var phone = document.getElementById(""txtPhone"").value;

			if (date.toString() == '') {
				alert(""Please select Pickup Date"");
				return false;
			}

			if (time.toString() == '') {
				alert(""Please select Pickup Time"");
				return false;
			}

			if (name.toString() == '') {
				alert(""Please enter a Pickup Name"");
				return false;
			}

			if (phone.toString() == '') {
				alert(""Please enter a Pickup Phone Number"");
				return false;
			}

			return true;
		}

	</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.OrderDetailsCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
