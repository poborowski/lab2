#pragma checksum "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7af45f2a48172eee181ecee8073a24fa497e10c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Created), @"mvc.1.0.view", @"/Views/Form/Created.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7af45f2a48172eee181ecee8073a24fa497e10c", @"/Views/Form/Created.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6dba473eed4680a5eab1f8268cca4e2e045ee9", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Created : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab2_test.Models.FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml"
  
    ViewData["Title"] = "Form-Created";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-left\">\n    <h1 class=\"display-4\">Data</h1>\n    ");
#nullable restore
#line 9 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(":          ");
#nullable restore
#line 9 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml"
                                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<p>\n    od wybranej daty do teraz upłyneło:\n");
#nullable restore
#line 14 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml"
      
        TimeSpan roznica = DateTime.Now - Model.Description;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 17 "C:\Users\Bartek\Desktop\Nowy folder\lab2\Views\Form\Created.cshtml"
Write(roznica.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    dni.\n  \n</p>\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab2_test.Models.FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
