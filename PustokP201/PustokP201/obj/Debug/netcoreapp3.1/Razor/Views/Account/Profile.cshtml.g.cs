#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\59. 07-01-2022\PustokP201\PustokP201\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4141dc2da85bfdeb1cd69084ade80ac95313c169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\59. 07-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\59. 07-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\59. 07-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4141dc2da85bfdeb1cd69084ade80ac95313c169", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5884438bbf247ea6d9f39676e18e38800fdc98e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item active"">My Account</li>
                </ol>
            </nav>
        </div>
    </div>
</section>
<div class=""page-section inner-page-sec-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row"">
                    <!-- My Account Tab Menu Start -->
                    <div class=""col-lg-3 col-12"">
                        <div class=""myaccount-tab-menu nav"" role=""tablist"">
                            <a href=""#dashboad"" class=""active"" data-toggle=""tab"">
                                <i class=""fas fa-tachometer-alt""></i>
                               ");
            WriteLiteral(@" Dashboard
                            </a>
                            <a href=""#orders"" data-toggle=""tab""><i class=""fa fa-cart-arrow-down""></i> Orders</a>
                            <a href=""#download"" data-toggle=""tab""><i class=""fas fa-download""></i> Download</a>
                            <a href=""#payment-method"" data-toggle=""tab"">
                                <i class=""fa fa-credit-card""></i>
                                Payment
                                Method
                            </a>
                            <a href=""#address-edit"" data-toggle=""tab"">
                                <i class=""fa fa-map-marker""></i>
                                address
                            </a>
                            <a href=""#account-info"" data-toggle=""tab"">
                                <i class=""fa fa-user""></i> Account
                                Details
                            </a>
                            <a href=""login-register.html""><i class=""");
            WriteLiteral(@"fas fa-sign-out-alt""></i> Logout</a>
                        </div>
                    </div>
                    <!-- My Account Tab Menu End -->
                    <!-- My Account Tab Content Start -->
                    <div class=""col-lg-9 col-12 mt--30 mt-lg--0"">
                        <div class=""tab-content"" id=""myaccountContent"">
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade show active"" id=""dashboad"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Dashboard</h3>
                                    <div class=""welcome mb-20"">
                                        <p>
                                            Hello, <strong>");
#nullable restore
#line 55 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\59. 07-01-2022\PustokP201\PustokP201\Views\Account\Profile.cshtml"
                                                      Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> (If Not <strong>\r\n                                                Tuntuni\r\n                                                !\r\n                                            </strong>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4141dc2da85bfdeb1cd69084ade80ac95313c1698189", async() => {
                WriteLiteral("\r\n                                                Logout\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@")
                                        </p>
                                    </div>
                                    <p class=""mb-0"">
                                        From your account dashboard. you can easily check &amp; view
                                        your
                                        recent orders, manage your shipping and billing addresses and edit your
                                        password and account details.
                                    </p>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Orders</h3>
                                    <div class=""myaccount-table table-responsive text-center"">
    ");
            WriteLiteral(@"                                    <table class=""table table-bordered"">
                                            <thead class=""thead-light"">
                                                <tr>
                                                    <th>No</th>
                                                    <th>Name</th>
                                                    <th>Date</th>
                                                    <th>Status</th>
                                                    <th>Total</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Mostarizing Oil</td>
                                                    <td>Aug ");
            WriteLiteral(@"22, 2018</td>
                                                    <td>Pending</td>
                                                    <td>$45</td>
                                                    <td><a href=""cart.html"" class=""btn"">View</a></td>
                                                </tr>
                                                <tr>
                                                    <td>2</td>
                                                    <td>Katopeno Altuni</td>
                                                    <td>July 22, 2018</td>
                                                    <td>Approved</td>
                                                    <td>$100</td>
                                                    <td><a href=""cart.html"" class=""btn"">View</a></td>
                                                </tr>
                                                <tr>
                                                    <td>3</td>
                             ");
            WriteLiteral(@"                       <td>Murikhete Paris</td>
                                                    <td>June 12, 2017</td>
                                                    <td>On Hold</td>
                                                    <td>$99</td>
                                                    <td><a href=""cart.html"" class=""btn"">View</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""download"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Downloads</h3>
                                    <div class=""m");
            WriteLiteral(@"yaccount-table table-responsive text-center"">
                                        <table class=""table table-bordered"">
                                            <thead class=""thead-light"">
                                                <tr>
                                                    <th>Product</th>
                                                    <th>Date</th>
                                                    <th>Expire</th>
                                                    <th>Download</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Mostarizing Oil</td>
                                                    <td>Aug 22, 2018</td>
                                                    <td>Yes</td>
                                                    <td><a h");
            WriteLiteral(@"ref=""#"" class=""btn"">Download File</a></td>
                                                </tr>
                                                <tr>
                                                    <td>Katopeno Altuni</td>
                                                    <td>Sep 12, 2018</td>
                                                    <td>Never</td>
                                                    <td><a href=""#"" class=""btn"">Download File</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
                                <div class=""myacco");
            WriteLiteral(@"unt-content"">
                                    <h3>Payment Method</h3>
                                    <p class=""saved-message"">You Can't Saved Your Payment Method yet.</p>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""address-edit"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Billing Address</h3>
                                    <address>
                                        <p><strong>Alex Tuntuni</strong></p>
                                        <p>
                                            1355 Market St, Suite 900 <br>
                                            San Francisco, CA 94103
                                        </p>
                                        <p>Mobile: (123) 456-7");
            WriteLiteral(@"890</p>
                                    </address>
                                    <a href=""#"" class=""btn btn--primary"">
                                        <i class=""fa fa-edit""></i>Edit
                                        Address
                                    </a>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""account-info"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Account Details</h3>
                                    <div class=""account-details-form"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4141dc2da85bfdeb1cd69084ade80ac95313c16917825", async() => {
                WriteLiteral(@"
                                            <div class=""row"">
                                                <div class=""col-lg-6 col-12  mb--30"">
                                                    <input id=""first-name"" placeholder=""First Name"" type=""text"">
                                                </div>
                                                <div class=""col-lg-6 col-12  mb--30"">
                                                    <input id=""last-name"" placeholder=""Last Name"" type=""text"">
                                                </div>
                                                <div class=""col-12  mb--30"">
                                                    <input id=""display-name"" placeholder=""Display Name""
                                                           type=""text"">
                                                </div>
                                                <div class=""col-12  mb--30"">
                                                    <inpu");
                WriteLiteral(@"t id=""email"" placeholder=""Email Address"" type=""email"">
                                                </div>
                                                <div class=""col-12  mb--30"">
                                                    <h4>Password change</h4>
                                                </div>
                                                <div class=""col-12  mb--30"">
                                                    <input id=""current-pwd"" placeholder=""Current Password""
                                                           type=""password"">
                                                </div>
                                                <div class=""col-lg-6 col-12  mb--30"">
                                                    <input id=""new-pwd"" placeholder=""New Password""
                                                           type=""password"">
                                                </div>
                                                <div class=""c");
                WriteLiteral(@"ol-lg-6 col-12  mb--30"">
                                                    <input id=""confirm-pwd"" placeholder=""Confirm Password""
                                                           type=""password"">
                                                </div>
                                                <div class=""col-12"">
                                                    <button class=""btn btn--primary"">Save Changes</button>
                                                </div>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                            <!-- Single Tab Content End -->
                        </div>
                    </div>
                    <!-- My Account Tab Content End -->
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
