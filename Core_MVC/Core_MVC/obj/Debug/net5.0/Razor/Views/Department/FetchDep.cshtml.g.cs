#pragma checksum "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6c07a67b2272ed3de8901a5a2bda29900d5536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_FetchDep), @"mvc.1.0.view", @"/Views/Department/FetchDep.cshtml")]
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
#line 1 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\_ViewImports.cshtml"
using Core_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\_ViewImports.cshtml"
using Core_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6c07a67b2272ed3de8901a5a2bda29900d5536", @"/Views/Department/FetchDep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0eaa5661b89f8a8235807a0c02538c44125481", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_FetchDep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core_MVC.Models.Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
  
    ViewData["Title"] = "FetchDep";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
 using (Html.BeginForm("UpdateDep", "Department", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <strong>");
#nullable restore
#line 10 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
       Write(Html.LabelFor(x => x.DepartmentID, "Department ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 11 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
Write(Html.TextBoxFor(x => x.DepartmentID, new {@readonly="readonly", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <strong>");
#nullable restore
#line 13 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
       Write(Html.LabelFor(x => x.DepartmentName, "Department Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 14 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
Write(Html.TextBoxFor(x => x.DepartmentName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Update</button>\r\n");
#nullable restore
#line 17 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\FetchDep.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core_MVC.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
