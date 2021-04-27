#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b780d40576a166a5641fee72d12767e21bc9ab3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__EditUser), @"mvc.1.0.view", @"/Views/SysAdmin/_EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b780d40576a166a5641fee72d12767e21bc9ab3f", @"/Views/SysAdmin/_EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
  
    List<DataAccessLibrary.Models.Department> departments = (List<DataAccessLibrary.Models.Department>)ViewData["Departments"];
    List<DataAccessLibrary.Models.UserRole> userTypes = (List<DataAccessLibrary.Models.UserRole>)ViewData["UserTypes"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""editBackdrop2"" data-backdrop=""static"" tabindex=""1"" role=""dialog"" aria-labelledby=""editBackdropLabel"" aria-hidden=""true"">
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
#line 15 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
             using (Html.BeginForm("EditUser", "SysAdmin", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-body\">\r\n\r\n            ");
#nullable restore
#line 19 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <input type=\"hidden\" id=\"userIdEdit\" name=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 1084, "\"", 1092, 0);
            EndWriteAttribute();
            WriteLiteral(@" />

            <div class=""form-group row"">
                <label for=""usernameEdit"" class=""col-sm-4 col-form-label"">Username</label>
                <div class=""col-sm-8"">
                    <input type=""text"" class=""form-control"" id=""usernameEdit"" name=""Lastname""");
            BeginWriteAttribute("value", " value=\"", 1367, "\"", 1375, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>

            <div class=""form-group row"">
                <label for=""firstName"" class=""col-sm-4 col-form-label"">First Name</label>
                <div class=""col-sm-8"">
                    <input type=""text"" class=""form-control"" id=""firstName""");
            BeginWriteAttribute("name", " name=\"", 1674, "\"", 1713, 1);
#nullable restore
#line 34 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 1681, nameof(UserViewModel.Firstname), 1681, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1714, "\"", 1722, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>

            <div class=""form-group row"">
                <label for=""rank"" class=""col-sm-4 col-form-label"">User Rank</label>
                <div class=""col-sm-8"">
                    <input type=""text"" class=""form-control"" id=""rank""");
            BeginWriteAttribute("name", " name=\"", 2010, "\"", 2048, 1);
#nullable restore
#line 41 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 2017, nameof(UserViewModel.Userrank), 2017, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2049, "\"", 2057, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>

            <div class=""form-group row"">
                <label for=""func"" class=""col-sm-4 col-form-label"">User Function</label>
                <div class=""col-sm-8"">
                    <input type=""text"" class=""form-control"" id=""func""");
            BeginWriteAttribute("name", " name=\"", 2349, "\"", 2391, 1);
#nullable restore
#line 48 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 2356, nameof(UserViewModel.Userfunction), 2356, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2392, "\"", 2400, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>



            <div class=""form-group row"">
                <label for=""userEmailEdit"" class=""col-sm-4 col-form-label"">Email</label>
                <div class=""col-sm-8"">
                    <input type=""email"" class=""form-control"" id=""userEmailEdit""");
            BeginWriteAttribute("name", " name=\"", 2707, "\"", 2742, 1);
#nullable restore
#line 57 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 2714, nameof(UserViewModel.Email), 2714, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2743, "\"", 2751, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>


            <div class=""form-group row"">
                <label for=""userPasswordEdit"" class=""col-sm-4 col-form-label"">New password</label>
                <div class=""col-sm-8 input-group show_hide_password"">
                    <input type=""password"" class=""form-control"" id=""userPasswordEdit""");
            BeginWriteAttribute("name", " name=\"", 3103, "\"", 3141, 1);
#nullable restore
#line 65 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 3110, nameof(UserViewModel.Password), 3110, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3142, "\"", 3150, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"input-group-append\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3236, "\"", 3243, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-secondary""><i class=""fa fa-eye-slash"" aria-hidden=""true""></i></a>
                    </div>
                </div>
            </div>

            <div class=""form-group row"">
                <label class=""col-sm-4 col-form-label"">Department</label>
                <div class=""col-sm-8"">
                    <select class=""custom-select mb-3""");
            BeginWriteAttribute("name", " name=\"", 3612, "\"", 3654, 1);
#nullable restore
#line 75 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 3619, nameof(UserViewModel.DepartmentId), 3619, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"departmentIdEdit\">\r\n");
#nullable restore
#line 76 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
                         foreach (var department in departments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b780d40576a166a5641fee72d12767e21bc9ab3f10909", async() => {
#nullable restore
#line 78 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
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
#line 78 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
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
#line 79 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </div>

            <div class=""form-group row"">
                <label class=""col-sm-4 col-form-label"">User type</label>
                <div class=""col-sm-8"">

                    <select class=""custom-select mb-3""");
            BeginWriteAttribute("name", " name=\"", 4181, "\"", 4217, 1);
#nullable restore
#line 88 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
WriteAttributeValue("", 4188, nameof(UserViewModel.RoleId), 4188, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"userRoleIdEdit\">\r\n");
#nullable restore
#line 89 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
                         foreach (var userType in userTypes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b780d40576a166a5641fee72d12767e21bc9ab3f13948", async() => {
#nullable restore
#line 91 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
                                                            Write(userType.Role);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
                               WriteLiteral(userType.UserRoleId);

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
#line 92 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
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
                    <button type=""submit"" class=""btn btn-primary"">Save</button>
                </div>
");
#nullable restore
#line 104 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_EditUser.cshtml"
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
