#pragma checksum "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d2ed36e29c78885db37247ab9ccd2848e70107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d2ed36e29c78885db37247ab9ccd2848e70107", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 5 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupons.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"border\">\r\n\t\t<div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2400\">\r\n");
#nullable restore
#line 9 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupons.Count(); i++)
			{
				if (i == 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"carousel-item active\">\r\n");
#nullable restore
#line 14 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
							var base64 = Convert.ToBase64String(Model.Coupons.ToList()[i].Picture);
							var couponImage = string.Format("data:image/jpg;base64,{0}", base64);
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 506, "\"", 524, 1);
#nullable restore
#line 19 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 512, couponImage, 512, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 21 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"carousel-item\">\r\n");
#nullable restore
#line 25 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
							var base64 = Convert.ToBase64String(Model.Coupons.ToList()[i].Picture);
							var couponImage = string.Format("data:image/jpg;base64,{0}", base64);
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 826, "\"", 844, 1);
#nullable restore
#line 30 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 832, couponImage, 832, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
				}

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 37 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<div class=\"backgroundWhite container\">\r\n\r\n\t<!-- Buttons -->\r\n\t<ul id=\"menu-filters\" class=\"menu-filter-list list-inline text-center\">\r\n\t\t<li class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</li>\r\n\r\n");
#nullable restore
#line 48 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var item in Model.Categories)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 50 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(item.Name.Replace(" ", string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 50 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n\r\n");
#nullable restore
#line 54 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"row\" id=\"menu-wrapper\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65d2ed36e29c78885db37247ab9ccd2848e701078319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 57 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItems.Where(k => k.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n");
#nullable restore
#line 59 "D:\Libraries\Documents\.NET Projects\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>

	<script>
		//var posts = $('.post');

		(function ($) {
			$(""#menu-filters li"").click(function () {
				$(""#menu-filters li"").removeClass('active btn btn-secondary');
				$(this).addClass('active btn btn-secondary');

				var menuWrapper = $('menu-wrapper');
				var selectedFilter = $(this).data(""filter"");

				$("".menu-restaurant"").fadeOut();

				setTimeout(function () {
					$(selectedFilter).slideDown();
				}, 300);
			});
		})(jQuery);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
