#pragma checksum "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0eb34382df2c56fca4007a258a5789e88fba94d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MyOrderDetails), @"mvc.1.0.view", @"/Views/Order/MyOrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0eb34382df2c56fca4007a258a5789e88fba94d", @"/Views/Order/MyOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_MyOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
  
    ViewData["Title"] = "MyOrderDetails";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""order-details-table"">
        <thead>
            <tr>
                <th>Product</th>
                <th>Quantity</th>
                <th>Price</th>
                <th>Total</th>
                <!-- Thêm các cột khác tùy theo nhu cầu -->
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
             foreach (var orderDetail in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
                   Write(orderDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
                   Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
                   Write(orderDetail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
                   Write(orderDetail.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <!-- Thêm các ô dữ liệu khác tùy theo nhu cầu -->\r\n                </tr>\r\n");
#nullable restore
#line 29 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 32 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No order details found.</p>\r\n");
#nullable restore
#line 36 "D:\WebsiteBadminton\PRN211\Views\Order\MyOrderDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591