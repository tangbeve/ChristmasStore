#pragma checksum "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8acb50ffe7da1ebfd05b86c8fbaba049f166e7f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Your_Display), @"mvc.1.0.view", @"/Views/Your/Display.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8acb50ffe7da1ebfd05b86c8fbaba049f166e7f0", @"/Views/Your/Display.cshtml")]
    public class Views_Your_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChristmasStore.Models.Shop>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
  
    Layout = "~/Views/Shared/_myLayoutPage.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n \n\n    <p> ");
#nullable restore
#line 10 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n\n");
#nullable restore
#line 12 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
      
        ViewData["Title"] = "Details";

    

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\n    <thead>\n        <tr>\n        <th>Item</th>\n        <th>Price</th>\n             </tr>\n    </thead>\n<tbody>\n\n\n");
#nullable restore
#line 26 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
 foreach(var s in ViewBag.AllShops)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n     <td>");
#nullable restore
#line 29 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
    Write(s.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
   Write(s.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 32 "/Users/cerser/ChristmasStore/Views/Your/Display.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\n</table>\n\n   \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChristmasStore.Models.Shop> Html { get; private set; }
    }
}
#pragma warning restore 1591
