#pragma checksum "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aabc01803c3ff497a8349cefcb27670fea2d2a16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserProfile), @"mvc.1.0.view", @"/Views/User/UserProfile.cshtml")]
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
#line 1 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using TrainTicket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using TrainTicket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabc01803c3ff497a8349cefcb27670fea2d2a16", @"/Views/User/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1100fa8555ff53eedadef9f56d1e033a6472cb7d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainTicket.Models.UserInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfilePicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
   Layout = "~/Views/Shared/_MyLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabc01803c3ff497a8349cefcb27670fea2d2a166125", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Project Add</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabc01803c3ff497a8349cefcb27670fea2d2a167366", async() => {
                WriteLiteral(@"
    <div class=""wrapper container"">
        <section class=""content"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""card card-primary card-outline"">
                        <div class=""card-body box-profile"">
                            <div class=""text-center"">
");
#nullable restore
#line 26 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                 if (Model.ProfilePicture == null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aabc01803c3ff497a8349cefcb27670fea2d2a168278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \n");
#nullable restore
#line 29 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aabc01803c3ff497a8349cefcb27670fea2d2a169869", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1212, "~/images/", 1212, 9, true);
#nullable restore
#line 32 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
AddHtmlAttributeValue("", 1221, Model.ProfilePicture, 1221, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 33 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n\n                            <h3 class=\"profile-username text-center\">");
#nullable restore
#line 37 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                                                Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n\n                            <p class=\"text-muted text-center\">");
#nullable restore
#line 39 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                                         Write(Model.UserType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                            <ul class=\"list-group list-group-unbordered mb-3\">\n                                <li class=\"list-group-item\">\n                                    <b>Email</b> <a class=\"float-right\">");
#nullable restore
#line 43 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                                                   Write(Model.UserEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n                                </li>\n                                <li class=\"list-group-item\">\n                                    <b>Phone Number</b> <a class=\"float-right\">");
#nullable restore
#line 46 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
                                                                          Write(Model.UserPhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Total Buy Tickets</b> <a class=""float-right"">13,287</a>
                                </li>
                            </ul>

                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabc01803c3ff497a8349cefcb27670fea2d2a1613850", async() => {
                    WriteLiteral("<b>Edit Profile</b>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                </div>
            

            
                <div class=""col-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">
                                <i class=""far fa-chart-bar""></i>
                                Your Info
                            </h3>

                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                    <i class=""fas fa-times""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
         ");
                WriteLiteral("                   <div class=\"row\">\n                                <div class=\"col-12 col-md-6 text-center\">\n                                    <input type=\"text\" class=\"knob\"");
                BeginWriteAttribute("value", " value=\"", 3544, "\"", 3569, 1);
#nullable restore
#line 80 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
WriteAttributeValue("", 3552, ViewBag.sellgrph, 3552, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" data-width=""90"" data-height=""90"" data-fgColor=""#932ab6"" readonly>
                                    <div class=""knob-label"">Total Sell</div>
                                </div>
                                <div class=""col-12 col-md-6 text-center"">
                                    <input type=""text"" class=""knob""");
                BeginWriteAttribute("value", " value=\"", 3894, "\"", 3918, 1);
#nullable restore
#line 84 "F:\New folder\Sujon\TrainTicket\TrainTicket\Views\User\UserProfile.cshtml"
WriteAttributeValue("", 3902, ViewBag.buygrph, 3902, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" data-width=""90"" data-height=""90"" data-fgColor=""#f56954"" readonly>

                                    <div class=""knob-label"">Total buy</div>
                                </div>
                                
                            </div>
                            
                        </div>
                    </div>
                </div>
          </div>
        </section>
    </div>
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            /* jQueryKnob */

            $('.knob').knob({
                /*change : function (value) {
                 //console.log(""change : "" + value);
                 },
                 release : function (value) {
                 console.log(""release : "" + value);
                 },
                 cancel : function () {
                 console.log(""cancel : "" + this.value);
                 },*/
                draw: function () {

                    // ""tron"" case
                    if (this.$.data('skin') == 'tron') {

                        var a = this.angle(this.cv)  // Angle
                            ,
                            sa = this.startAngle          // Previous start angle
                            ,
                            sat = this.startAngle         // Start angle
                            ,
                            ea                            // Previous end angle
                            ,
                        ");
                WriteLiteral(@"    eat = sat + a                 // End angle
                            ,
                            r = true

                        this.g.lineWidth = this.lineWidth

                        this.o.cursor
                            && (sat = eat - 0.3)
                            && (eat = eat + 0.3)

                        if (this.o.displayPrevious) {
                            ea = this.startAngle + this.angle(this.value)
                            this.o.cursor
                                && (sa = ea - 0.3)
                                && (ea = ea + 0.3)
                            this.g.beginPath()
                            this.g.strokeStyle = this.previousColor
                            this.g.arc(this.xy, this.xy, this.radius - this.lineWidth, sa, ea, false)
                            this.g.stroke()
                        }

                        this.g.beginPath()
                        this.g.strokeStyle = r ? this.o.fgColor : this.fgColor
                        this.g.");
                WriteLiteral(@"arc(this.xy, this.xy, this.radius - this.lineWidth, sat, eat, false)
                        this.g.stroke()

                        this.g.lineWidth = 2
                        this.g.beginPath()
                        this.g.strokeStyle = this.o.fgColor
                        this.g.arc(this.xy, this.xy, this.radius - this.lineWidth + 1 + this.lineWidth * 2 / 3, 0, 2 * Math.PI, false)
                        this.g.stroke()

                        return false
                    }
                }
            })
            /* END JQUERY KNOB */

            //INITIALIZE SPARKLINE CHARTS
            var sparkline1 = new Sparkline($('#sparkline-1')[0], { width: 240, height: 70, lineColor: '#92c1dc', endColor: '#92c1dc' })
            var sparkline2 = new Sparkline($('#sparkline-2')[0], { width: 240, height: 70, lineColor: '#f56954', endColor: '#f56954' })
            var sparkline3 = new Sparkline($('#sparkline-3')[0], { width: 240, height: 70, lineColor: '#3af221', endColor: '#3af221' })

            ");
                WriteLiteral("sparkline1.draw([1000, 1200, 920, 927, 931, 1027, 819, 930, 1021])\n            sparkline2.draw([515, 519, 520, 522, 652, 810, 370, 627, 319, 630, 921])\n            sparkline3.draw([15, 19, 20, 22, 33, 27, 31, 27, 19, 30, 21])\n\n        })\n\n    </script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainTicket.Models.UserInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591