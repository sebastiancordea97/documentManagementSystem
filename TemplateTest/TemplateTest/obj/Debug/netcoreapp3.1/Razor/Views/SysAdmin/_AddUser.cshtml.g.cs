#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__AddUser), @"mvc.1.0.view", @"/Views/SysAdmin/_AddUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da6", @"/Views/SysAdmin/_AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
  
    List<DataAccessLibrary.Models.Department> departments = (List<DataAccessLibrary.Models.Department>)ViewData["Departments"];
    List<DataAccessLibrary.Models.UserRole> userRoles = (List<DataAccessLibrary.Models.UserRole>)ViewData["UserTypes"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

 <div class=""modal fade"" id=""addBackdrop2"" data-backdrop=""static"" tabindex=""1"" role=""dialog"" aria-labelledby=""addBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addBackdropLabel"">New user</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
#nullable restore
#line 18 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
             using (Html.BeginForm("AddUser", "SysAdmin", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-body\">\r\n\r\n            ");
#nullable restore
#line 22 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 26 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Firstname, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 28 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.TextBoxFor(x => x.Firstname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 33 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Lastname, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 35 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.TextBoxFor(x => x.Lastname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 40 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Userrank, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 42 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.TextBoxFor(x => x.Userrank, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 47 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Userfunction, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 49 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.TextBoxFor(x => x.Userfunction, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 54 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Email, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 61 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.Password, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8 input-group show_hide_password\">\r\n                    ");
#nullable restore
#line 63 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
               Write(Html.PasswordFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"input-group-append\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2975, "\"", 2982, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\"><i class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 71 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.DepartmentId, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    <select class=\"custom-select mb-3\" name=\"DepartmentId\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da610260", async() => {
                WriteLiteral("Select department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                         foreach (var department in departments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da611848", async() => {
#nullable restore
#line 77 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                                                         Write(department.DepName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                               WriteLiteral(department.DepId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 84 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
           Write(Html.LabelFor(x => x.RoleId, new { @class = "col-sm-4 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-sm-8\">\r\n                    <select class=\"custom-select mb-3\" name=\"RoleId\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da614455", async() => {
                WriteLiteral("Select user Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                         foreach (var userRole in userRoles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5bf6d44b53dfef410bc1fbc3eac9b6a3997da616038", async() => {
#nullable restore
#line 90 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                                                            Write(userRole.Role);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                               WriteLiteral(userRole.UserRoleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </div>



        </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Add new user</button>
                </div>
");
#nullable restore
#line 103 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_AddUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
