#pragma checksum "C:\Users\35883602800\Desktop\clone\project-RoleTopMVC\Views\Shared\Falha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e8441dc5f6a39dc8e9c82db0e8158f1af26c5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Falha), @"mvc.1.0.view", @"/Views/Shared/Falha.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Falha.cshtml", typeof(AspNetCore.Views_Shared_Falha))]
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
#line 1 "C:\Users\35883602800\Desktop\clone\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\35883602800\Desktop\clone\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e8441dc5f6a39dc8e9c82db0e8158f1af26c5d", @"/Views/Shared/Falha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9346c35ab2aa533a85ce99e20e39341cea489f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Falha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project_RoleTopMVC.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 70, true);
            WriteLiteral("<main>\r\n     <div id=\"mensagem-falha\">\r\n          <p>\r\n               ");
            EndContext();
            BeginContext(127, 14, false);
#line 5 "C:\Users\35883602800\Desktop\clone\project-RoleTopMVC\Views\Shared\Falha.cshtml"
          Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(141, 44, true);
            WriteLiteral("\r\n          </p>\r\n          <a id=\"backHome\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 185, "\'", 220, 1);
#line 7 "C:\Users\35883602800\Desktop\clone\project-RoleTopMVC\Views\Shared\Falha.cshtml"
WriteAttributeValue("", 192, Url.Action("Index", "Home"), 192, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(221, 58, true);
            WriteLiteral(">Voltar para a página principal.</a>\r\n     </div>\r\n</main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project_RoleTopMVC.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
