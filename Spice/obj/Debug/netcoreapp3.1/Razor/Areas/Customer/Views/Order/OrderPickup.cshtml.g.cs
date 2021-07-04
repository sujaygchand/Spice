#pragma checksum "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5719610fce86cb1af1d7b82c0dba5742ad9b416"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderPickup), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
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
#line 2 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
using Spice.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5719610fce86cb1af1d7b82c0dba5742ad9b416", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderPickup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Spice.TagHelpers.PageLinkTagHelper __Spice_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
  
	ViewData["Title"] = "Order Pickup";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5719610fce86cb1af1d7b82c0dba5742ad9b4165567", async() => {
                WriteLiteral("\r\n\t<br />\r\n\t<br />\r\n\t<h2 class=\"text-info\"> Orders Ready for Pickup :</h2>\r\n\t<div class=\"border backgroundWhite\">\r\n\t\t<div class=\"row container\">\r\n\t\t\t<div class=\"col-11\">\r\n\t\t\t\t<div class=\"row\" style=\"padding-top:10px\">\r\n\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 18 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                   Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", @placeholder = "Name..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 21 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                   Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-4\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 24 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                   Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control", @placeholder = "Email..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
					</div>
				</div>
			</div>
			<div class=""col-1"">
				<div class=""row"" style=""padding-top:10px"">
					<button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-info form-control"">
					<i class=""fas fa-search""></i>
					</button>
				</div>
			</div>

		</div>
		<br />
		<div>
");
#nullable restore
#line 39 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
             if (Model.Orders.Count() > 0)
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<table class=\"table table-striped border\">\r\n\t\t\t\t\t<tr class=\"table-secondary\">\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 44 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(k => k.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 47 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(k => k.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 50 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(k => k.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 53 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(k => k.Orders[0].OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 56 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(k => k.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\tTotal Time\r\n\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t<th></th>\r\n\t\t\t\t\t</tr>\r\n\r\n");
#nullable restore
#line 64 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                     foreach (var item in Model.Orders)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 68 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 71 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 74 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 77 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 80 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 83 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(k => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-success btnOrderDetail\" data-id=\"");
#nullable restore
#line 87 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                                                                                                 Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"modal\">\r\n\t\t\t\t\t\t\t\t\t<i class=\"far fa-list-alt\"></i>&nbsp;Details\r\n\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 92 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t</table>\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5719610fce86cb1af1d7b82c0dba5742ad9b41613280", async() => {
                    WriteLiteral("\r\n\t\t\t\t");
                }
                );
                __Spice_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Spice.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__Spice_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 94 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Spice_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 94 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Spice_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Spice_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Spice_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t<br />\r\n");
#nullable restore
#line 99 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<p>No category exists...</p>\r\n");
#nullable restore
#line 103 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t</div>\r\n\t</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	<div class=""modal fade"" id=""myOrderDetails"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
		<div class=""modal-dialog-centered modal-dialog modal-lg"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header bg-success text-light"">
					<div class=""col-10 offset-1"">
						<h5 class=""modal-title align-content-center"">Order Details</h5>	
					</div>
					<div class=""col-1"">
						<button type=""button"" class=""float-right btn-outline-secondary close"" data-dismiss=""modal"" aria-label=""Close"">
							<span aria-hidden=""true"">&times;</span>
						</button>
					</div>
					</div>
				<div class=""modal-body justify-content-center"" id=""myOrderDetailsContent"">

				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
		</div>
	</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script>
    var OrderDetailsURL = '/Customer/Order/GetOrderDetails';

     $("".btnOrderDetail"").click(function () {
         
         var $buttonClicked = $(this);
         var id = $buttonClicked.attr('data-id');
         
         $.ajax({
            type: ""GET"",
            url: OrderDetailsURL,
            contentType: ""application/json; charset=utf-8"",
            data: {""Id"": id},
            cache: false,
            dataType: ""html"",
            success: function (data){
              $('#myOrderDetailsContent').html(data);
              $('#myOrderDetails').modal('show');
            },
            error: function () {
                alert(""Dynamic content load failed"")                    
            }    
         });
     });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
