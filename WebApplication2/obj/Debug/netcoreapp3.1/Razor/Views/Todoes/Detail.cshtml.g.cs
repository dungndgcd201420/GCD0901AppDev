#pragma checksum "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\Todoes\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ec9122e8270d868cc0449288621efaf84601e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todoes_Detail), @"mvc.1.0.view", @"/Views/Todoes/Detail.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ec9122e8270d868cc0449288621efaf84601e2", @"/Views/Todoes/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Todoes_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Todo>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 200px\">\r\n    <img \r\n        class=\"card-img-top\" \r\n        src=\"https://pic.onlinewebfonts.com/svg/img_213869.png\"\r\n        alt=\"card image\"/>\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\Todoes\Detail.cshtml"
                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\Todoes\Detail.cshtml"
                            Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\WebApplication2\WebApplication2\Views\Todoes\Detail.cshtml"
                            Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        </img>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Todo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
