#pragma checksum "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33fe1b134d3321888cc3b1ae25c38acc0c60d152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\WebsiteBadminton\PRN211\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebsiteBadminton\PRN211\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fe1b134d3321888cc3b1ae25c38acc0c60d152", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.ViewModels.CartItemcs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""breadcrumb-section set-bg"" data-setbg=""img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Shopping Cart</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""./index.html"">Home</a>
                        <span>Shopping Cart</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__table"">
                    <div class=""col-lg-12"">
                        <div class=""shoping__cart__table"">

                            <table>

                    <thead>
                        <tr>

                            <td>Tên Sản Phẩm</td>
                            <td>S");
            WriteLiteral("ố Lượng</td>\r\n                            <td>Đơn giá</td>\r\n                            <td>Xóa\r\n                            <td>\r\n                        </tr>\r\n                    </thead>\r\n");
#nullable restore
#line 42 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                         foreach (var item in Model)
                        {
                         

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tbody>
                                            <tr class=""shoping__cart__item"">
                                                
                                                <td class=""shoping__cart__item__details"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33fe1b134d3321888cc3b1ae25c38acc0c60d1526428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1878, "~/images/products/", 1878, 18, true);
#nullable restore
#line 51 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1896, item.product.Thumb, 1896, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1922, item.product.Title, 1922, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                                                    <h5 class=\"details-cart\">");
#nullable restore
#line 52 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                                                        Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                </td>
                                                <td class=""shoping__cart__quantity"">
                                                    <div class=""quantity"">
                                                        <div class=""pro-qty"">
                                                            <input data-mahh =""");
#nullable restore
#line 57 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                                                          Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"cartItem\" data-dongia=\"");
#nullable restore
#line 57 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                                                                                                                 Write(item.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2536, "\"", 2556, 1);
#nullable restore
#line 57 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2544, item.amount, 2544, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" min=""1"">
                                                        </div>
                                                    </div>
                                                </td>

                                                <td class=""shoping__cart__total"">
                                                    <span class=""total-amount"">");
#nullable restore
#line 63 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                                                          Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"VND</span>
                                                </td>
                                                <td class=""shoping__cart__item__delete"">
                                                    <input type=""button"" value=""X"" class=""removecart btn btn-priamry"" data-mahh=""");
#nullable restore
#line 66 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                                                                                                            Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                                                </td>\r\n\r\n                                            </tr>\r\n\r\n                                        </tbody>\r\n");
#nullable restore
#line 72 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                         

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </table>

                </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__btns"">
                    <a href=""#"" class=""primary-btn cart-btn"">CONTINUE SHOPPING</a>
                    <a href=""#"" class=""primary-btn cart-btn cart-btn-right"">
                        <span class=""icon_loading""></span>
                        Upadate Cart
                    </a>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__continue"">
                    <div class=""shoping__discount"">
                        <h5>Discount Codes</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33fe1b134d3321888cc3b1ae25c38acc0c60d15212897", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Enter your coupon code\">\r\n                            <button type=\"submit\" class=\"site-btn\">APPLY COUPON</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            <div class=""col-lg-6"">
                <div class=""shoping__checkout"">
                    <h5>Cart Total</h5>
                    <ul>
                        <li>Subtotal <span>");
#nullable restore
#line 108 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                                      Write(Model.Sum(x=> x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("VND</span></li>\r\n                        <li>Total <span>000</span></li>\r\n                    </ul>\r\n");
#nullable restore
#line 111 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"
                     if(User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/checkout.html\" class=\"primary-btn\">THANH TOÁN</a>\r\n");
#nullable restore
#line 114 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"

                    } else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"primary-btn\">PROCEED TO CHECKOUT</a>\r\n");
#nullable restore
#line 118 "D:\WebsiteBadminton\PRN211\Views\ShoppingCart\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>
        $(function () {
            function loadHeaderCart() {
                $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
                $(""#numberCart"").load(""/AjaxContent/numberCart"");
            }

            $("".removecart"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: { productID: productid },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();
                            window.location = 'cart.html';
                        }
                    },
                    error: function (rs) {
                        alert(""Remove Cart Error!"");
                    }
                });
            });

            $("".cartItem"").click(function () {
                var pro");
                WriteLiteral(@"ductid = $(this).attr(""data-mahh"");
                var soluong = parseInt($(this).val());
                $.ajax({
                    url: ""api/cart/update"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productID: productid,
                        amount: soluong
                    },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();
                            window.location = 'cart.html';
                        }
                    }
                });
            });

            $('.quantity-input').on('input', function () {
                var quantity = parseInt($(this).val());
                var pricePerItem = parseFloat($(this).data('dongia'));
                var totalPriceElement = $(this).closest('.shoping__cart__quantity').next('.shoping__cart__total').find('.total-amount');

                // Cal");
                WriteLiteral(@"culate the current total price for the item
                var currentTotalPrice = parseFloat(totalPriceElement.text().replace(/[^\d.-]/g, ''));

                // Calculate the new total price based on the updated quantity
                var newTotalPrice = currentTotalPrice + (quantity * pricePerItem);

                // Update the total price display for the current item
                totalPriceElement.text(newTotalPrice.toLocaleString() + 'VND');

                // Recalculate and update the overall cart total
                updateCartTotal();
            });
        });

        function refreshCart() {
            $.ajax({
                url: '/api/cart/add', // Đường dẫn API để thêm sản phẩm vào giỏ hàng
                type: 'POST',
                data: { productID: productId, amount: amount }, // Thông tin sản phẩm muốn thêm vào giỏ hàng
                success: function (data) {
                    // Cập nhật lại phần hiển thị giỏ hàng trên trang web với dữ liệu mới từ");
                WriteLiteral(@" API
                    $('.shoping__cart__table').html(data);
                },
                error: function () {
                    alert('Đã xảy ra lỗi khi thêm sản phẩm vào giỏ hàng.');
                }
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.ViewModels.CartItemcs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
