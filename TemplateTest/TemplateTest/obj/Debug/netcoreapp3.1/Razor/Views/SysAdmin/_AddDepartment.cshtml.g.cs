#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89b2a0e8052a27aee2b0d562387083ccbe344035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__AddDepartment), @"mvc.1.0.view", @"/Views/SysAdmin/_AddDepartment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b2a0e8052a27aee2b0d562387083ccbe344035", @"/Views/SysAdmin/_AddDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__AddDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DepartmentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""addBackdrop"" data-backdrop=""static"" tabindex=""1"" role=""dialog"" aria-labelledby=""addBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addBackdropLabel"">New department</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
#nullable restore
#line 11 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
             using (Html.BeginForm("AddDepartment", "SysAdmin", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"modal-body\">\r\n\r\n                    ");
#nullable restore
#line 15 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 19 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
                   Write(Html.LabelFor(x => x.DepartmentName, new { @class = "col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
                   Write(Html.TextBoxFor(x => x.DepartmentName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                  
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Add new department</button>
                </div>
");
#nullable restore
#line 29 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddDepartment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DepartmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591