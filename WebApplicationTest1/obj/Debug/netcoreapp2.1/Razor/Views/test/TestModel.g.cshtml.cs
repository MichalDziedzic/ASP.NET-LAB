#pragma checksum "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\test\TestModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6b63139b35ede5a8d4500157d30a399131609b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_test_TestModel), @"mvc.1.0.view", @"/Views/test/TestModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/test/TestModel.cshtml", typeof(AspNetCore.Views_test_TestModel))]
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
#line 1 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\_ViewImports.cshtml"
using WebApplicationTest1;

#line default
#line hidden
#line 2 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\_ViewImports.cshtml"
using WebApplicationTest1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6b63139b35ede5a8d4500157d30a399131609b", @"/Views/test/TestModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8663dad82ff39e9554d82c0f0772b6829df4ec60", @"/Views/_ViewImports.cshtml")]
    public class Views_test_TestModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModelTest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\test\TestModel.cshtml"
  
    ViewData["Title"] = "TestModel";
    


#line default
#line hidden
            BeginContext(84, 22, true);
            WriteLiteral("\r\n<h2>TestModel</h2>\r\n");
            EndContext();
#line 9 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\test\TestModel.cshtml"
 foreach(var m in @Model)
{

#line default
#line hidden
            BeginContext(136, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(144, 13, false);
#line 11 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\test\TestModel.cshtml"
  Write(m.TestMessage);

#line default
#line hidden
            EndContext();
            BeginContext(157, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "E:\Projekty Github\ASP.NET-LAB\WebApplicationTest1\Views\test\TestModel.cshtml"
}

#line default
#line hidden
            BeginContext(166, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModelTest>> Html { get; private set; }
    }
}
#pragma warning restore 1591