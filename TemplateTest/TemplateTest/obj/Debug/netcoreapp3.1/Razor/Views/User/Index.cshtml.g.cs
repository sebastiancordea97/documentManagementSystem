#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b84659e6fc2be4dd318d29ec1432fa3e5850b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b84659e6fc2be4dd318d29ec1432fa3e5850b43", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocumentsPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"row\">\r\n    <table class=\"table table-hover\">\r\n        <thead class=\"bg-primary text-light\">\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 10 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
               Write(Html.DisplayName("Document Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 13 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
               Write(Html.DisplayName("Document End-Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 16 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
               Write(Html.DisplayName("Document Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>");
#nullable restore
#line 18 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
               Write(Html.DisplayName("Options"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 24 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
             foreach (var item in Model.Documents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
                   Write(Html.ActionLink(System.IO.Path.GetFileName(item.DocumentPath), "GetDocument", "User", new { filePath = item.DocumentPath }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                \r\n                    <td>\r\n                        <button id=\"sendbutton\" class=\"btn btn-primary btn-sm rounded mr-3\" type=\"button\" data-toggle=\"modal\" data-target=\"#SignersModal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1222, "\"", 1258, 3);
            WriteAttributeValue("", 1232, "setDocumentId(", 1232, 14, true);
#nullable restore
#line 34 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
WriteAttributeValue("", 1246, item.DocId, 1246, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1257, ")", 1257, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >Send</button>\r\n                        <button id=\"deleteOpenModal3\" class=\"btn btn-danger btn-sm rounded\" type=\"button\" data-toggle=\"modal\" data-target=\"#deleteBackdrop3\" data-id=\"");
#nullable restore
#line 35 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
                                                                                                                                                                 Write(item.DocId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-value=\"");
#nullable restore
#line 35 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
                                                                                                                                                                                          Write(System.IO.Path.GetFileName(item.DocumentPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 39 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"

               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 52 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
Write(await Html.PartialAsync("_DeleteDocument"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
Write(await Html.PartialAsync("_SignersModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
Write(await Html.PartialAsync("_UploadModal", new DocumentViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"showtasks\" style=\"display:none\">\r\n    ");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\User\Index.cshtml"
Write(await Html.PartialAsync("_Tasks", Model.DocumentsToSign));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocumentsPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
