#pragma checksum "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a20e7e093723241cfaa7e4f8742d5aca997a0059eed01433e819c1872070c13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a20e7e093723241cfaa7e4f8742d5aca997a0059eed01433e819c1872070c13d", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.MuaHangVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Mua Hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<WebApplication1.ViewModels.CartItemcs> Carts = ViewBag.GioHang;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Checkout</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""./index.html"">Home</a>
                        <span>Checkout</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Checkout Section Begin -->
<section class=""checkout spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h6>
                    <span class=""icon_tag_alt""></span> Have a coupon? <a href=""#"">Click here</a> to enter your code
                </h6>
            </div>
        </div>
        <div class=""checkout__form"">
            <h4>Billing Details</h4>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a20e7e093723241cfaa7e4f8742d5aca997a0059eed01433e819c1872070c13d5750", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-8 col-md-6"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""checkout__input"">
                                    <p>Full Name<span>*</span></p>
                                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 1663, "\"", 1686, 1);
#nullable restore
#line 42 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1671, Model.FullName, 1671, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            
                        </div>
                        <div class=""checkout__input"">
                            <p>Country<span>*</span></p>
                            <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 1987, "\"", 2011, 1);
#nullable restore
#line 49 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1995, Model.TinhThanh, 1995, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"checkout__input\">\r\n                            <p>Address<span>*</span></p>\r\n                            <input type=\"text\" placeholder=\"Street Address\"");
                BeginWriteAttribute("value", " value=\"", 2235, "\"", 2258, 1);
#nullable restore
#line 53 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 2243, Model.PhuongXa, 2243, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"checkout__input__add\">\r\n                        </div>\r\n                        <div class=\"checkout__input\">\r\n                            <p>Town/City<span>*</span></p>\r\n                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2484, "\"", 2508, 1);
#nullable restore
#line 57 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 2492, Model.QuanHuyen, 2492, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        

                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Phone<span>*</span></p>
                                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2848, "\"", 2868, 1);
#nullable restore
#line 65 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 2856, Model.Phone, 2856, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Email<span>*</span></p>
                                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 3181, "\"", 3201, 1);
#nullable restore
#line 71 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 3189, Model.Email, 3189, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                        </div>
                   
                     
                      
                        <div class=""checkout__input"">
                            <p>Order notes<span>*</span></p>
                            <input type=""text""
                                   placeholder=""Notes about your order, e.g. special notes for delivery.""");
                BeginWriteAttribute("value", " value=\"", 3651, "\"", 3670, 1);
#nullable restore
#line 81 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 3659, Model.Note, 3659, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""checkout__order"">
                            <h4>Your Order</h4>
                            <div class=""checkout__order__products"">Products <span>Total</span></div>
");
#nullable restore
#line 88 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                             if (Carts!=null && Carts.Count() > 0)
                            {
                                foreach(var item in Carts)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <ul>\r\n                                        <li>");
#nullable restore
#line 93 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                                       Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>");
#nullable restore
#line 93 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                                                                      Write(item.amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                        <div class=\"checkout__order__subtotal\">Subtotal <span>");
#nullable restore
#line 94 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                                                                                         Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("VND</span></div>\r\n\r\n                                    </ul>\r\n");
#nullable restore
#line 97 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h4>DON HANG KHONG CO</h4>\r\n");
#nullable restore
#line 102 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"checkout__order__total\">Total <span>");
#nullable restore
#line 103 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Checkout\Index.cshtml"
                                                                       Write(Carts.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("VND</span></div>\r\n\r\n                        \r\n                            <button type=\"submit\" class=\"site-btn\">PLACE ORDER</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.MuaHangVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
