#pragma checksum "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a69e9acf97461e5f590ea5ec4241c1c0179ff0f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_DetEmp), @"mvc.1.0.view", @"/Views/Department/DetEmp.cshtml")]
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
#line 1 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
using Core_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a69e9acf97461e5f590ea5ec4241c1c0179ff0f2", @"/Views/Department/DetEmp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0eaa5661b89f8a8235807a0c02538c44125481", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_DetEmp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
  
    ViewData["Title"] = "DetEmp";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>");
#nullable restore
#line 9 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
Write(ViewBag.DepN);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Department</h2>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Employee ID</th>\r\n        <th>Employee Name</th>\r\n        <th>Employee Surname</th>\r\n        <th>Employee City</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
           Write(x.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
           Write(x.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
           Write(x.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
           Write(x.EmployeeCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Downloads\ASP.NET\Core_MVC\Core_MVC\Views\Department\DetEmp.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
