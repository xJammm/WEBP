#pragma checksum "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6879d4373296399a8b28a062a864efd61b7d5bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6879d4373296399a8b28a062a864efd61b7d5bfe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821521680d2f6cb10bb1dcdd0594b94425db339d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBP.WebAPI.Models.ListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
     foreach (var item in Model.blogs)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"post\">\r\n\t\t\t<p class=\"lead\">");
#nullable restore
#line 9 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
                       Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t<hr class=\"my-4\">\r\n\t\t\t<p>");
#nullable restore
#line 11 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
          Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t<p> ");
#nullable restore
#line 12 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
           Write(Model.categories.Find(c => c.id == item.categoryid).name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t</div>\r\n");
#nullable restore
#line 14 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBP.WebAPI.Models.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
