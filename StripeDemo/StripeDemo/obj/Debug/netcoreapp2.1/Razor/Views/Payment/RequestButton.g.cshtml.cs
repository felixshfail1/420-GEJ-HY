#pragma checksum "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab080ac3008f20f19c6e574935773b472e79005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_RequestButton), @"mvc.1.0.view", @"/Views/Payment/RequestButton.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/RequestButton.cshtml", typeof(AspNetCore.Views_Payment_RequestButton))]
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
#line 1 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\_ViewImports.cshtml"
using StripeDemo;

#line default
#line hidden
#line 2 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\_ViewImports.cshtml"
using StripeDemo.Models;

#line default
#line hidden
#line 4 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab080ac3008f20f19c6e574935773b472e79005", @"/Views/Payment/RequestButton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4bda90f29aa42a7e534c4b2ec2ede4e847173e", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_RequestButton : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/rubberduck.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
   ViewData["Title"] = "Request Button Example"; 

#line default
#line hidden
            BeginContext(124, 273, true);
            WriteLiteral(@"
<section class=""bg-light rounded p-2"">
    <div class=""row"">
        <div class=""col"">
            <h2 class=""mb-2 font-weight-bold"">Request Payment Button</h2>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-6 text-center"">
            ");
            EndContext();
            BeginContext(397, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e1db4db7c3840d4b2ac73adca971d7e", async() => {
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
            EndContext();
            BeginContext(462, 192, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-6\">\r\n            <div class=\"p-4\">\r\n                <div class=\"lead my-2\">\r\n                    <span class=\"font-weight-bold\">Price: </span><span>");
            EndContext();
            BeginContext(655, 25, false);
#line 22 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                                                  Write(Model.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(680, 120, true);
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div class=\"lead\">\r\n                    <h3 class=\"font-weight-bold\">");
            EndContext();
            BeginContext(801, 10, false);
#line 26 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(811, 345, true);
            WriteLiteral(@"</h3>
                </div>

                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Et dolor suscipit libero eos atque quia ipsa
                    sint voluptatibus! Beatae sit assumenda asperiores iure at maxime atque repellendus maiores quia sapiente.
                </p>

                ");
            EndContext();
            BeginContext(1156, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f7fc46bb3343518eb9550ad364932f", async() => {
                BeginContext(1176, 392, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""float-right"">
                                <button id=""payment-request-button"" class=""btn btn-primary"" type=""button"" href=""#payment-form"">Buy</button>
                            </div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1575, 560, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <div id=""incompatible-message"" class=""alert alert-warning my-2 d-none"" role=""alert"">
                Your browser does not support the payment request API. To view this demo, you'll need to try it in a browser that does.
                See <a class=""alert-link"" href=""https://caniuse.com/#feat=payment-request"">https://caniuse.com/#feat=payment-request</a> for more information.
            </div>
        </div>
    </div>
</section>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2153, 269, true);
                WriteLiteral(@"
    <script src=""https://js.stripe.com/v3/""></script>
    <script>
        (function () {
            ""use strict"";

            $(document).ready(function () {
                // Switch out the test key here with your own
                let stripe = Stripe(""");
                EndContext();
                BeginContext(2423, 29, false);
#line 64 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                Write(StripeOptions.Value.PublicKey);

#line default
#line hidden
                EndContext();
                BeginContext(2452, 203, true);
                WriteLiteral("\");\r\n                let paymentRequest = stripe.paymentRequest({\r\n                    country: \'CA\',\r\n                    currency: \'cad\',\r\n                    total: {\r\n                        label: \"");
                EndContext();
                BeginContext(2656, 10, false);
#line 69 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2666, 36, true);
                WriteLiteral("\",\r\n                        amount: ");
                EndContext();
                BeginContext(2703, 11, false);
#line 70 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                           Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2714, 1203, true);
                WriteLiteral(@" * 100, // Price in cents
                    }
                });

                // Check the availability of the Payment Request API first.
                paymentRequest.canMakePayment().then(function (result) {
                    let message = $(""#incompatible-message"");
                    let button = $(""#payment-request-button"");

                    if (result) {
                        button.prop(""disabled"", false);

                        // Attach button click to start payment request
                        button.on(""click"", paymentRequest.show);
                    } else {
                        button.prop(""disabled"", true);
                        message.toggleClass(""d-none"");
                    }
                });

                paymentRequest.on('token', function (e) {
                    // Send the token to your server to charge it!
                    fetch('/payment/charges', {
                        method: 'post',
                        headers: ");
                WriteLiteral("{ \'content-type\': \'application/json\' },\r\n                        body: JSON.stringify({\r\n                            token: e.token.id,\r\n                            description: \"");
                EndContext();
                BeginContext(3918, 10, false);
#line 97 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3928, 47, true);
                WriteLiteral("\",\r\n                            amountInCents: ");
                EndContext();
                BeginContext(3976, 11, false);
#line 98 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                      Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3987, 393, true);
                WriteLiteral(@" * 100, // Price in cents
                            currencyCode: ""cad""
                        })
                    // Report to the browser that the payment was successful or failed.
                    }).then(function (response) {
                        if (response.ok) {
                            e.complete('success');
                            window.location.replace(""");
                EndContext();
                BeginContext(4381, 26, false);
#line 105 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Payment\RequestButton.cshtml"
                                                Write(Url.Action("Confirmation"));

#line default
#line hidden
                EndContext();
                BeginContext(4407, 207, true);
                WriteLiteral("\")\r\n                        } else {\r\n                            e.complete(\'fail\');\r\n                        }\r\n                    });\r\n                });\r\n            });\r\n        })();\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<StripeOptions> StripeOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
