#pragma checksum "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13f0cb088af3f32ff5c98c935f464cdbc42b12a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\_ViewImports.cshtml"
using WitcherKendoEFDemo;

#line default
#line hidden
#line 2 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13f0cb088af3f32ff5c98c935f464cdbc42b12a", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d110e3b12b8b93280462307187ceaaa31a31ac83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 110, true);
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1 class=\"jumbotron-heading\">");
            EndContext();
            BeginContext(154, 13, false);
#line 7 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\Home\Contact.cshtml"
                                 Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(167, 48, true);
            WriteLiteral(".</h1>\r\n        <p class=\"lead-text text-muted\">");
            EndContext();
            BeginContext(216, 15, false);
#line 8 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\Home\Contact.cshtml"
                                   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(231, 43, true);
            WriteLiteral("</p>\r\n    </div>\r\n</section>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(276, 2917, false);
#line 13 "C:\Users\duffl\Desktop\WitcherKendoEFDemo\Views\Home\Contact.cshtml"
Write(Html.Kendo().TabStrip()
                    .Name("ContactsTabStrip")
                    .Items(items =>
                    {
                        items.Add()
                            .Text("Phone")
                            .Selected(true)
                            .Content(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(578, 433, true);
    WriteLiteral(@"
                                <p>
                                    <strong>Main:</strong>
                                    <span>425.555.0100</span>
                                </p>
                                <p>
                                    <strong>After Hours:</strong>
                                    <span>425.555.0199</span>
                                </p>
                            ");
    EndContext();
    PopWriter();
}
))
                                    .ContentHtmlAttributes(new { style = "min-height: 250px" });
                                items.Add()
                                    .Text("Email")
                                    .Content(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1268, 417, true);
    WriteLiteral(@"
                                        <address>
                                            <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
                                            <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
                                        </address>
                                    ");
    EndContext();
    PopWriter();
}
))
                                        .ContentHtmlAttributes(new { style = "min-height: 250px" });
                                        items.Add()
                                            .Text("Address")
                                            .Content(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1972, 1083, true);
    WriteLiteral(@"
                                                <address>
                                                    Progress Software Corporation<br />
                                                    Bedford, MA 01730<br />
                                                    14 Oak Park Drive<br />
                                                    <abbr title=""Phone"">Phone:</abbr>
                                                    +1-781-280-4000
                                                </address>
                                                <address>
                                                    Progress Software Europe BV<br />
                                                    Rotterdam, 3067 GG<br />
                                                    Schorpioenstraat 67<br />
                                                    <abbr title=""Phone"">Phone:</abbr>
                                                    +31-10-235-1111
                                             ");
    WriteLiteral("   </address>\r\n                                            ");
    EndContext();
    PopWriter();
}
))
                                                        .ContentHtmlAttributes(new { style = "min-height: 250px" });
                                            })
    );

#line default
#line hidden
            EndContext();
            BeginContext(3236, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
