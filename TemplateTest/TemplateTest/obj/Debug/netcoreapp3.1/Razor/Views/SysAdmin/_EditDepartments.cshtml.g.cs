#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditDepartments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63cdbdbe956bd58adde2f46482f9410bd270b496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__EditDepartments), @"mvc.1.0.view", @"/Views/SysAdmin/_EditDepartments.cshtml")]
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
#line 1 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\_ViewImports.cshtml"
using TemplateTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\_ViewImports.cshtml"
using TemplateTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cdbdbe956bd58adde2f46482f9410bd270b496", @"/Views/SysAdmin/_EditDepartments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__EditDepartments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""editBackdrop"" tabindex=""1"" role=""dialog"" aria-labelledby=""editBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editBackdropLabel"">Edit</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
#nullable restore
#line 10 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditDepartments.cshtml"
             using (Html.BeginForm("EditDepartment", "SysAdmin", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-body\">\r\n\r\n            ");
#nullable restore
#line 14 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditDepartments.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditDepartments.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"departmentNameEdit\" class=\"col-form-label\">Department name:</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"departmentNameEdit\" name=\"departmentName\"");
            BeginWriteAttribute("value", " value=\"", 981, "\"", 989, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n                <input type=\"hidden\" id=\"departmentEdit\" name=\"departmentId\"");
            BeginWriteAttribute("value", " value=\"", 1075, "\"", 1083, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>


            <div class=""form-group"">
                <label for=""departmentSupervisorEdit"" class=""col-form-label"">SupervisorId</label>
                <input type=""text"" class=""form-control"" id=""departmentSupervisorEdit"" name=""supervisorId""");
            BeginWriteAttribute("value", " value=\"", 1355, "\"", 1363, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>




        </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Save</button>
                </div>
");
#nullable restore
#line 39 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditDepartments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
