#pragma checksum "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7aefbd761e230aabdf7c194254e1e68f3146da7ed58b49c79bb2db3be813242e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MyOrders), @"mvc.1.0.view", @"/Views/Order/MyOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7aefbd761e230aabdf7c194254e1e68f3146da7ed58b49c79bb2db3be813242e", @"/Views/Order/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.Models.Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyOrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <Style>
    .title {
        text-align: center;
        background-color: #df8787;
        width: 25%;
        margin: 30px auto; /* Căn giữa theo chiều ngang */
        color:white;
        padding:5px 5px;
        
    }
        .order-table {
            
            width: 90%;
            border-collapse: collapse;
            margin:0 auto;
    }

            .order-table th, .order-table td {
            border: 1px solid #eeebeb;
                padding: 8px;
                text-align: left;
                padding:20px 0 20px 20px;
        }

            .order-table th {
            background-color: #e8e2ea;
        }

            .order-table tr:nth-child(even) {
                background-color: #f2f2f2;
            }

            .order-table tr:hover {
                background-color: #ddd;
            }

    .btn.btn-primary{
        font-weight:700;
        background-color: #8ac2ff;
        color: #3c3737;
        margin: 0 auto;
    }

    .");
            WriteLiteral(@"btn {
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .btn1 {
        display: flex;
        justify-content: center;
        align-items: center;
    }
    </Style>
    <h3 class=""title"">Đơn hàng </h3>
");
#nullable restore
#line 58 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""order-table"">
            <thead>
                <tr>
                <th>Địa chỉ đặt hàng</th>
                <th>Ngày đặt</th>
                <th>Tổng Tiền</th>
                <th class=""btn1"">Xem chi tiết đơn hàng</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 70 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                 \r\n                        <td>");
#nullable restore
#line 74 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                       Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                       Write(order.TotalMoney);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aefbd761e230aabdf7c194254e1e68f3146da7ed58b49c79bb2db3be813242e7388", async() => {
                WriteLiteral("Xem Đơn Hàng ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                                                                                                                         WriteLiteral(order.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                        <!-- Thêm các ô dữ liệu khác tùy theo nhu cầu -->\r\n                    </tr>\r\n");
#nullable restore
#line 82 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 85 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No orders found.</p>\r\n");
#nullable restore
#line 89 "E:\FPT\SP24\PRN211\Assigments\WebApplication1\WebApplication1\Views\Order\MyOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.Models.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
