#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6efdcdbba84336f7eae90dbdef63688649c69a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__Users), @"mvc.1.0.view", @"/Views/SysAdmin/_Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6efdcdbba84336f7eae90dbdef63688649c69a6", @"/Views/SysAdmin/_Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<DataAccessLibrary.Models.Department>, List<DataAccessLibrary.Models.Users>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!-- List all users. -->\r\n<table class=\"table table-striped table-responsive-md btn-table \">\r\n    <thead>\r\n        <tr class=\"font-weight-bolder text-dark\" text-dark>\r\n            <th>\r\n                ");
#nullable restore
#line 9 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("UserId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("UserRank"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("UserFunction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Department"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Role"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Supervisor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
           Write(Html.DisplayName("Options:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
         foreach (var item in Model.Item2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                   ");
#nullable restore
#line 45 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
              Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.Userrank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td> \r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserFunction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartmentNavigation.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.Role.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n");
#nullable restore
#line 68 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                     if (!(item.DepartmentNavigation.SupervisorNavigation == null))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartmentNavigation.SupervisorNavigation.Lastname));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                              
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                   Write(Html.DisplayName("Not set"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                    ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </td>
                <td>
                    <!-- Edit department button. -->
                    <button id=""editOpenModal2"" class=""btn btn-secondary rounded-pill"" type=""button"" data-toggle=""modal"" data-target=""#editBackdrop2"" data-id=""");
#nullable restore
#line 79 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                          Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-username=\"");
#nullable restore
#line 79 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                                       Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-firstname=\"");
#nullable restore
#line 79 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                                                                       Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" \r\n                             data-rank=\"");
#nullable restore
#line 80 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                   Write(item.Userrank);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-function=\"");
#nullable restore
#line 80 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                  Write(item.UserFunction);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
            WriteLiteral(" data-email=\"");
#nullable restore
#line 80 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                  Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-depid=\"");
#nullable restore
#line 80 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                           Write(item.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-usertypeid=\"");
#nullable restore
#line 80 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                                                                Write(item.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button> |\r\n\r\n                    <!-- Delete department button. -->\r\n                    <button id=\"deleteOpenModal2\" class=\"btn btn-danger rounded-pill\" type=\"button\" data-toggle=\"modal\" data-target=\"#deleteBackdrop2\" data-id=\"");
#nullable restore
#line 83 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                           Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-username=\"");
#nullable restore
#line 83 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                                        Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-email=\"");
#nullable restore
#line 83 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
                                                                                                                                                                                                                    Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button> \r\n\r\n                   \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Users.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<DataAccessLibrary.Models.Department>, List<DataAccessLibrary.Models.Users>>> Html { get; private set; }
    }
}
#pragma warning restore 1591