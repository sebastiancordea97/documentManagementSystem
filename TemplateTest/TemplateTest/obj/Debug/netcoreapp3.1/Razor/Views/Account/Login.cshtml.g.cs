#pragma checksum "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c28c911324f781f4ca76baa6d67f027cf7f606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c28c911324f781f4ca76baa6d67f027cf7f606", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2eae4111975adfff660c9a82fc8b0a6d3862a41", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gradient-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c28c911324f781f4ca76baa6d67f027cf7f6063794", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 320, "\"", 330, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 357, "\"", 367, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Login</title>

    <!-- Custom fonts for this template-->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c28c911324f781f4ca76baa6d67f027cf7f6065786", async() => {
                WriteLiteral(@"

    <div class=""container"">


        <div class=""row justify-content-center"">

            <div class="" col-6"">
               
                <div class=""card o-hidden border-0 shadow-lg my-5"">


                    <div class=""p-5"">
                        <div class=""text-center"">
                            <h1 class=""h4 text-gray-900 mb-4""><b>Welcome To C&C System!</b></h1>
                        </div>
");
#nullable restore
#line 44 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                         using (Html.BeginForm("Login", "Account", FormMethod.Post, new { @class = "user" }))
                        {



#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <i class=\"fa fa-envelope prefix grey-text\"></i>\r\n                                ");
#nullable restore
#line 50 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                           Write(Html.ValidationMessageFor(x => x.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 51 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                           Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control form-control-user", @placeholder = "Enter Email Address...", @type = "email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <i class=\"fa fa-lock prefix grey-text\"></i>\r\n                                ");
#nullable restore
#line 56 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                           Write(Html.ValidationMessageFor(x => x.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 57 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                           Write(Html.PasswordFor(x => x.Password, new { @class = "form-control form-control-user", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <div class=\"custom-control custom-checkbox small\">\r\n                                    ");
#nullable restore
#line 62 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                               Write(Html.CheckBoxFor(x => x.IsPersistent, new { @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 63 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                               Write(Html.LabelFor(x => x.IsPersistent, new { @class = "custom-control-label font-weight-bold" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""text-center"">
                                <button type=""submit"" class=""btn btn-primary btn-user "">Login</button>

                            </div>
");
                WriteLiteral("                            <hr>\r\n");
#nullable restore
#line 73 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                             if (ViewData["Error"].Equals(true))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text-danger\">");
#nullable restore
#line 75 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                                                  Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 76 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Licenta lucru\TemplateTest\TemplateTest\Views\Account\Login.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>



                </div>

            </div>

        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
