#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2072871205c0c451f85cfd7d8dbf47aaec77bdaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysAdmin__Departments), @"mvc.1.0.view", @"/Views/SysAdmin/_Departments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2072871205c0c451f85cfd7d8dbf47aaec77bdaf", @"/Views/SysAdmin/_Departments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_SysAdmin__Departments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<DataAccessLibrary.Models.Department>, List<DataAccessLibrary.Models.Users>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
  
    ViewData["Title"] = "Departments";
    //Dictionary<int, string> usernames = (Dictionary<int, string>)ViewData["boss"];

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- List all departments. -->\r\n    <table class=\"table table-striped table-responsive-md btn-table \" id=\"depatmentsTable\">\r\n        <thead>\r\n            <tr class=\"font-weight-bolder text-dark\">\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
               Write(Html.DisplayName("Department name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
               Write(Html.DisplayName("Department Supervisor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
               Write(Html.DisplayName("Options"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
             foreach (var item in Model.Item1)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                  \r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 36 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 39 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                         if (!(item.SupervisorNavigation == null))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SupervisorNavigation.Lastname));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                             
                        }
                        else
                        {
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                      Write(Html.DisplayName("Not set"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                       ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                   

                    <td>


                       <!-- Edit department button. -->

                        <button id=""editOpenModal"" class=""btn btn-secondary rounded-pill"" type=""button"" data-toggle=""modal"" data-target=""#editBackdrop"" data-id=""");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                                                                                            Write(item.DepId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-depname=\"");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                                                                                                                       Write(item.DepName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-super=\"");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                                                                                                                                                  Write(item.Supervisor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >Edit</button> |\r\n\r\n                        <!-- Delete department button. -->\r\n                        <button id=\"deleteOpenModal\" class=\"btn btn-danger rounded-pill\" type=\"button\" data-toggle=\"modal\" data-target=\"#deleteBackdrop\" data-id=\"");
#nullable restore
#line 59 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                                                                                             Write(item.DepId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-value=\"");
#nullable restore
#line 59 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
                                                                                                                                                                                      Write(item.DepName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 62 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
#nullable restore
#line 65 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
Write(await Html.PartialAsync("_DeleteDepartments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 67 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\SysAdmin\_Departments.cshtml"
Write(await Html.PartialAsync("_EditDepartments"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<DataAccessLibrary.Models.Department>, List<DataAccessLibrary.Models.Users>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
