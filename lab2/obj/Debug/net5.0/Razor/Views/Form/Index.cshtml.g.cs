#pragma checksum "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "713a83d37165a2d2c7ff9c9d9dd6a5537275a130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Index), @"mvc.1.0.view", @"/Views/Form/Index.cshtml")]
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
#line 1 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\_ViewImports.cshtml"
using lab2_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\_ViewImports.cshtml"
using lab2_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"713a83d37165a2d2c7ff9c9d9dd6a5537275a130", @"/Views/Form/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6dba473eed4680a5eab1f8268cca4e2e045ee9", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
  
    ViewData["Title"] = "Form-Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 5 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Implicit Razor expression - Current date: ");
#nullable restore
#line 7 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
                                        Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !</p>\n\n<p>Explicit Razor expression - Last week this time: ");
#nullable restore
#line 9 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
                                                Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 11 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
  
    void RenderName(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: <strong>");
#nullable restore
#line 14 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
                    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\n");
#nullable restore
#line 15 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Index.cshtml"
    }

    RenderName("Mahatma Gandhi");
    RenderName("Martin Luther King, Jr.");

#line default
#line hidden
#nullable disable
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