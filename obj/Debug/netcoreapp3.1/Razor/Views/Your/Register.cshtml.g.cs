#pragma checksum "/Users/cerser/ChristmasStore/Views/Your/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250fb49f9ce872039e9748883bfb2444c8a5f1c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Your_Register), @"mvc.1.0.view", @"/Views/Your/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"250fb49f9ce872039e9748883bfb2444c8a5f1c2", @"/Views/Your/Register.cshtml")]
    public class Views_Your_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChristmasStore.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/cerser/ChristmasStore/Views/Your/Register.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Create</h2>
<hr/>
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""User.FirstName"" class=""control-label""></label>
                <input asp-for=""User.FirstName"" class=""form-control"" />
                <span asp-validation-for=""User.FirstName"" class=""text-danger""></span>
            </div>
             <div class=""form-group"">
                <label asp-for=""User.LastName"" class=""control-label""></label>
                <input asp-for=""User.LastName"" class=""form-control"" />
                <span asp-validation-for=""User.LastName"" class=""text-danger""></span>
            </div>
<div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
              </form> 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChristmasStore.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
