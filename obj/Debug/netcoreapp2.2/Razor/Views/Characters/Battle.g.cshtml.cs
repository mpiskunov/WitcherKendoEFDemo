#pragma checksum "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb59b6bbd3ccaf72676339829022b013a2efd799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Battle), @"mvc.1.0.view", @"/Views/Characters/Battle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Characters/Battle.cshtml", typeof(AspNetCore.Views_Characters_Battle))]
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
#line 1 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\_ViewImports.cshtml"
using WitcherKendoEFDemo;

#line default
#line hidden
#line 2 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb59b6bbd3ccaf72676339829022b013a2efd799", @"/Views/Characters/Battle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d110e3b12b8b93280462307187ceaaa31a31ac83", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters_Battle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WitcherKendoEFDemo.Models.Character>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
  
    ViewData["Title"] = "Battle";

#line default
#line hidden
            BeginContext(101, 27, true);
            WriteLiteral("\r\n<h1>Battle!</h1>\r\n<div>\r\n");
            EndContext();
#line 9 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
     using (@Html.BeginForm("Action", "Battle", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(212, 377, false);
#line 11 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
    Write(Html.Kendo()
        .DropDownList()
        .Name("ddlCharacters")
        .DataTextField("Name")
        .DataValueField("CharacterID")
        .DataSource(source =>
        {
            source.Read(read =>
            {
                read.Action("Characters_Read", "Characters");
            });
        }).Events(e => 
        e.Change("onChange"))
        );

#line default
#line hidden
            EndContext();
            BeginContext(602, 394, false);
#line 25 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
    Write(Html.Kendo()
            .DropDownList()
            .Name("ddlCharacters2")
            .DataTextField("Name")
            .DataValueField("CharacterID")
            .DataSource(source =>
                    {
                source.Read(read =>
                        {
                    read.Action("Characters_Read", "Characters");
                });
            })
        );

#line default
#line hidden
            EndContext();
            BeginContext(1008, 64, false);
#line 38 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
   Write(Html.Kendo().Button().Name("btn_SubmitBattle").Content("Submit"));

#line default
#line hidden
            EndContext();
#line 38 "C:\Users\Mpiskunov\Desktop\node_projects\WitcherKendoEFDemo\Views\Characters\Battle.cshtml"
                                                                         ;
    }

#line default
#line hidden
            BeginContext(1082, 196, true);
            WriteLiteral("\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        function onChange() {\r\n            alert(\"change\");\r\n            kendoConsole.log(\"event: change\");\r\n        };\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WitcherKendoEFDemo.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
