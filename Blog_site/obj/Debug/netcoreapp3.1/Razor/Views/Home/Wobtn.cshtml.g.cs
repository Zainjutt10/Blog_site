#pragma checksum "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286ab37e38b8b0c33f8ea28f75a08b52bd2b28b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wobtn), @"mvc.1.0.view", @"/Views/Home/Wobtn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286ab37e38b8b0c33f8ea28f75a08b52bd2b28b7", @"/Views/Home/Wobtn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_viewimports.cshtml")]
    public class Views_Home_Wobtn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"edit\" style=\"margin-left:20%; background-color:white; padding:20px; width:50%\">\r\n\r\n    <div class=\"row\" style=\"padding:inherit;margin-bottom:20px\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 227, "\"", 246, 1);
#nullable restore
#line 7 "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml"
WriteAttributeValue("", 233, Model.imgsrc, 233, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"height:100px;width:100px\" alt=\"usericon\" />\r\n        <div class=\"info\">\r\n            <h6>");
#nullable restore
#line 9 "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h5>");
#nullable restore
#line 10 "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\Zain Hassan Jutt\source\repos\Assignment03\Assignment03\Views\Home\Wobtn.cshtml"
          Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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