#pragma checksum "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c76ed2b03a07e009786b8f16aa5f372710e2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistrationForm), @"mvc.1.0.view", @"/Views/Home/RegistrationForm.cshtml")]
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
#line 1 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c76ed2b03a07e009786b8f16aa5f372710e2b5", @"/Views/Home/RegistrationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistrationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
 using (Html.BeginForm("Result", "Home", FormMethod.Get))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 10 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 15 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 20 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.Genre, new SelectList(Enum.GetValues(typeof(Genre)))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 25 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 30 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 31 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 35 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.LabelFor(m => m.Directors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
   Write(Html.TextAreaFor(m => m.Directors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 40 "C:\Users\mvarasteanu\source\repos\FrontEndCSS1\MovieRegistration\MovieRegistration\Views\Home\RegistrationForm.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591