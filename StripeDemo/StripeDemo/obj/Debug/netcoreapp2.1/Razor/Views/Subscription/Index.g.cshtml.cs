#pragma checksum "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35d53d729a92e2a6dc1daddde830bd4842bcb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_Index), @"mvc.1.0.view", @"/Views/Subscription/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subscription/Index.cshtml", typeof(AspNetCore.Views_Subscription_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e35d53d729a92e2a6dc1daddde830bd4842bcb00", @"/Views/Subscription/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4bda90f29aa42a7e534c4b2ec2ede4e847173e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscription_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/rubberduck.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-dialog modal-content bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2d07812ab044dc1928d8e489b1e3de8", async() => {
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
#line 22 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                                                  Write(Model.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(680, 126, true);
            WriteLiteral("/month</span>\r\n                </div>\r\n\r\n                <div class=\"lead\">\r\n                    <h3 class=\"font-weight-bold\">");
            EndContext();
            BeginContext(807, 10, false);
#line 26 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(817, 345, true);
            WriteLiteral(@"</h3>
                </div>

                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Et dolor suscipit libero eos atque quia ipsa
                    sint voluptatibus! Beatae sit assumenda asperiores iure at maxime atque repellendus maiores quia sapiente.
                </p>

                ");
            EndContext();
            BeginContext(1162, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59483238f544012b9a8e4d50f89f2a5", async() => {
                BeginContext(1182, 392, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""float-right"">
                                <button id=""subscribe-button"" class=""btn btn-primary"" type=""button"" href=""#payment-form"">subscribe</button>
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
            BeginContext(1581, 637, true);
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

<section id=""payment-section"" class=""modal fade rounded"" role=""dialog"">
    ");
            EndContext();
            BeginContext(2218, 3160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d7521792a2b4fce8dd0688b7c0e97e8", async() => {
                BeginContext(2334, 3037, true);
                WriteLiteral(@"

        <div class=""modal-header"">
            <h4 class=""modal-title"">Payment Informations</h4>
        </div>

        <div class=""modal-body"">
            <div class=""form-row mb-2"">
                <div class=""col"">
                    <label for=""name"" class=""control-label"">Name</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text bg-white""><i class=""fas fa-user""></i></span>
                        </div>
                        <input id=""name"" name=""name"" class=""form-control border-left-0"" type=""text"" placeholder=""Nom"" required>
                    </div>
                </div>
            </div>

            <div class=""form-row mb-2"">
                <div class=""col"">
                    <label for=""phone"" class=""control-label"">Phone</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                ");
                WriteLiteral(@"            <span class=""input-group-text bg-white""><i class=""fas fa-phone""></i></span>
                        </div>
                        <input id=""phone"" name=""phone"" class=""form-control border-left-0"" type=""text"" placeholder=""Phone number"" required>
                    </div>
                </div>
            </div>

            <div class=""form-row mb-2"">
                <div class=""col"">
                    <label for=""email"" class=""control-label"">Email</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text bg-white""><i class=""fas fa-at""></i></span>
                        </div>
                        <input id=""email"" class=""form-control border-left-0"" type=""email"" placeholder=""Email address"" required>
                    </div>
                </div>
            </div>

            <div class=""form-row mb-2"">
                <div class=""col"">
                  ");
                WriteLiteral(@"  <label for=""card"" class=""control-label"">Card</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text bg-white""><i class=""fas fa-credit-card""></i></span>
                        </div>
                        <div id=""card"" class=""form-control border-left-0""></div>
                    </div>
                    <div id=""card-errors"" role=""alert""></div>
                </div>
            </div>


            <div class=""modal-footer row"">
                <div class=""float-right"">
                    <button id=""cancel-btn"" type=""button"" class=""btn btn-outline-danger"">Cancel</button>
                    <button id=""reset-btn"" type=""reset"" class=""btn btn-outline-secondary"">Reset</button>
                    <button id=""submit-btn"" type=""submit"" class=""btn btn-success"">Confirm</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5378, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5412, 570, true);
                WriteLiteral(@"
    <script src=""https://js.stripe.com/v3/""></script>

    <script>
        (function () {
            ""use strict"";

            $(document).ready(function () {
                $(""#subscribe-button"").on(""click"", function () {
                    $(""#payment-section"").modal({
                        backdrop: 'static'
                    });

                    $(""#cancel-btn"").on(""click"", function () {
                        $(""#payment-section"").modal(""hide"");
                    });
                });

                let stripe = Stripe(""");
                EndContext();
                BeginContext(5983, 29, false);
#line 143 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                Write(StripeOptions.Value.PublicKey);

#line default
#line hidden
                EndContext();
                BeginContext(6012, 1920, true);
                WriteLiteral(@""");
                let elements = stripe.elements();

                let card = elements.create(""card"", {
                    style: {
                        base: {
                            fontSize: ""16px"",
                            fontWeight: ""400"",
                            color: ""#495057"",
                        }
                    },
                    hideIcon: true,
                    hidePostalCode: true
                });

                card.mount(""#card"");

                card.addEventListener('change', function (event) {
                    var displayError = document.getElementById('card-errors');
                    if (event.error) {
                        displayError.textContent = event.error.message;
                    } else {
                        displayError.textContent = '';
                    }
                });

                // Create a token or display an error when the form is submitted.
                var form = $(""#payment");
                WriteLiteral(@"-form"");
                form.on('submit', function (e) {
                    e.preventDefault();

                    stripe.createToken(card).then(function (result) {
                        if (result.error) {
                            $(""#card-errors"").textContent = result.error.message;
                        } else {
                            // Send the token to your server.
                            stripeTokenHandler(result.token);
                        }
                    });
                });

                function stripeTokenHandler(token) {
                    fetch('/subscription/charges', {
                        method: 'post',
                        headers: { 'content-type': 'application/json' },
                        body: JSON.stringify({
                            token: token.id,
                            description: """);
                EndContext();
                BeginContext(7933, 10, false);
#line 190 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7943, 47, true);
                WriteLiteral("\",\r\n                            amountInCents: ");
                EndContext();
                BeginContext(7991, 11, false);
#line 191 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                      Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(8002, 504, true);
                WriteLiteral(@" * 100, // Price in cents
                            currencyCode: ""cad"",
                            name: $(""#name"").val(),
                            email: $(""#email"").val(),
                            phone: $(""#phone"").val()
                        })
                    // Report to the browser that the payment was successful or failed.
                    }).then(function (response) {
                        if (response.ok) {
                            window.location.replace(""");
                EndContext();
                BeginContext(8507, 37, false);
#line 200 "C:\Users\hlapointe\Projects\GEJ\StripeDemo\StripeDemo\Views\Subscription\Index.cshtml"
                                                Write(Url.Action("Confirmation", "Payment"));

#line default
#line hidden
                EndContext();
                BeginContext(8544, 205, true);
                WriteLiteral("\")\r\n                        } else {\r\n                            e.complete(\'fail\');\r\n                        }\r\n                    });\r\n                }\r\n            });\r\n        })();\r\n    </script>\r\n");
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
