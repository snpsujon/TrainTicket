#pragma checksum "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a90e8c4fdcf6836154619d842e035ee01dfe02b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_print), @"mvc.1.0.view", @"/Views/Booking/print.cshtml")]
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
#line 1 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using TrainTicket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using TrainTicket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a90e8c4fdcf6836154619d842e035ee01dfe02b", @"/Views/Booking/print.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1100fa8555ff53eedadef9f56d1e033a6472cb7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainTicket.ViewModels.BookingVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
  
    ViewData["Title"] = "Booking";
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""callout callout-info"">
                    <h5><i class=""fas fa-info""></i> Note:</h5>
                    This page has been enhanced for printing. Click the print button at the bottom of the invoice to test.
                </div>


                <!-- Main content -->
                <div class=""invoice p-3 mb-3"">
                    <!-- title row -->
                    <div class=""row"">
                        <div class=""col-12"">
                            <h4>
                                <i class=""fas fa-globe""></i> Train Tickets
                                <small class=""float-right"">Date: ");
#nullable restore
#line 27 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                                            Write(DateTime.Now.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                            </h4>
                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- info row -->
                    <div class=""row invoice-info"">
                        <div class=""col-sm-4 invoice-col"">
                            From
                            <address>
                                <strong>");
#nullable restore
#line 37 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                   Write(Model.SellerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                                ");
#nullable restore
#line 38 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                           Write(Model.SellerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                email: ");
#nullable restore
#line 39 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                  Write(Model.SellerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </address>
                        </div>
                        <!-- /.col -->
                        <div class=""col-sm-4 invoice-col"">
                            To
                            <address>
                                <strong>");
#nullable restore
#line 46 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                   Write(Model.BuyerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                                ");
#nullable restore
#line 47 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                           Write(Model.BuyerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                email: ");
#nullable restore
#line 48 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                  Write(Model.BuyerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </address>\r\n                        </div>\r\n                        <!-- /.col -->\r\n                        <div class=\"col-sm-4 invoice-col\">\r\n                            <b>Invoice #");
#nullable restore
#line 53 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                   Write(Model.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br>\r\n                            <br>\r\n                            <b>Order ID:</b> ");
#nullable restore
#line 55 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                        Write(Model.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                            <b>Booking Time:</b> ");
#nullable restore
#line 56 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                            Write(Model.BookedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                            <b>Payment Type:</b> ");
#nullable restore
#line 57 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                            Write(Model.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <b>Payment Confirmations:</b>");
#nullable restore
#line 58 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                                    Write(Model.PaymentConfirmation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- /.row -->
                    <!-- Table row -->
                    <div class=""row"">
                        <div class=""col-12 table-responsive"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>Qty</th>
                                        <th>Train Name</th>
                                        <th>Journey Time</th>
                                        <th>Status</th>
                                        <th>Per Ticket Price</th>

                                        <th>Subtotal</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>");
#nullable restore
#line 81 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.TicketQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 82 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.TrainName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 83 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.JourneyTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 84 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.BookingStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 85 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.PerTicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>???");
#nullable restore
#line 86 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                        Write(Model.TicketTotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- /.row -->

                    <div class=""row"">
                        <!-- accepted payments column -->
                        <div class=""col-6"">
                            <p class=""lead"">Payment Methods:</p>
                            <img src=""../../dist/img/credit/visa.png"" alt=""Visa"">
                            <img src=""../../dist/img/credit/mastercard.png"" alt=""Mastercard"">
                            <img src=""../../dist/img/credit/american-express.png"" alt=""American Express"">
                            <img src=""../../dist/img/credit/paypal2.png"" alt=""Paypal"">

                            <p class=""text-muted well well-sm shadow-none"" style=""margin-top: 10px;"">
                                Etsy doostang zoodles disqus groupo");
            WriteLiteral(@"n greplin oooj voxy zoodles, weebly ning heekya handango imeem
                                plugg
                                dopplr jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.
                            </p>
                        </div>
                        <!-- /.col -->
                        <div class=""col-6"">


                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <tr>
                                        <th style=""width:50%"">Subtotal:</th>
                                        <td>");
#nullable restore
#line 119 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.TicketTotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <th>Total:</th>\r\n                                        <td>");
#nullable restore
#line 123 "F:\New folder\Sujon\train\TrainTicket\TrainTicket\Views\Booking\print.cshtml"
                                       Write(Model.TicketTotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- /.row -->
                    <!-- this row will not appear when printing -->
                    <div class=""row no-print"">
                        <div class=""col-12"">
                            <a href=""#"" rel=""noopener"" target=""_blank"" class=""btn btn-default"" onclick=""print()""><i class=""fas fa-print""></i> Print</a>

                            <button type=""button"" class=""btn btn-primary float-right"" style=""margin-right: 5px;"">
                                <i class=""fas fa-download""></i> Download Ticket
                            </button>
                        </div>
                    </div>
                </div>
                <!-- /.invoice -->
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.contai");
            WriteLiteral("ner-fluid -->\r\n</section>\r\n\r\n\r\n<script>\r\n    \r\n\r\n            window.addEventListener(\"load\", window.print());\r\n    \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainTicket.ViewModels.BookingVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
