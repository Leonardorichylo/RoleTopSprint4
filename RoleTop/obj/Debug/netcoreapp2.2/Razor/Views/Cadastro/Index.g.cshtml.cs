#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cadastro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d06215322d5b5561a20bd8a58aeeb6c02d5964a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Index.cshtml", typeof(AspNetCore.Views_Cadastro_Index))]
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
#line 1 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\_ViewImports.cshtml"
using RoleTop;

#line default
#line hidden
#line 2 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\_ViewImports.cshtml"
using RoleTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d06215322d5b5561a20bd8a58aeeb6c02d5964a3", @"/Views/Cadastro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 59, true);
            WriteLiteral("        <main>\r\n        <h2>Cadastro</h2>\r\n                ");
            EndContext();
            BeginContext(59, 2296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d06215322d5b5561a20bd8a58aeeb6c02d5964a33694", async() => {
                BeginContext(132, 2216, true);
                WriteLiteral(@"
                    <div>
                        <label for=""nome"">Nome Completo</label>
                        <br />
                        <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3"" name=""nome"" />
                    </div>
        
                    <div>
                        <label for=""email"">E-mail</label>
                        <br />
                        <input id=""email"" type=""email"" maxlength=""20"" minlength=""3"" name=""email"" />
                    </div>

                    <div>
                        <label for=""endereco"">Endereço</label>
                        <br />
                        <input id=""endereco"" type=""endereco"" maxlength=""20"" minlength=""3"" name=""endereco"" />
                    </div>
        
                    <div>
                        <label for=""telefone"">Telefone</label>
                        <br />
                        <input id=""telefone"" type=""telefone"" maxlength=""20"" minlength=""3"" name=""telefone"" />
         ");
                WriteLiteral(@"           </div>

                    <div>
                        <label for=""cpf"">CPF</label>
                        <br />
                        <input id=""cpf"" type=""cpf"" name=""cpf"" />
                    </div>

                    <div>
                        <label for=""data-nascimento"">Data de Nascimento</label>
                        <br />
                        <input id=""data-nascimento"" type=""date"" maxlength=""20"" minlength=""3"" name=""data-nascimento"" />
                        </div>
                    
                    <div>
                        <label for=""senha"">Senha</label>
                        <br />
                        <input id=""senha"" type=""password"" maxlength=""20"" minlength=""6"" name=""senha"" />
                    </div>

                    <div>
                        <label for=""confirmar-senha"">Confirmar Senha</label>
                        <br />
                        <input id=""confirmar-senha"" type=""password"" maxlength=""20"" minlength");
                WriteLiteral("=\"6\" name=\"confirmar-senha\" />\r\n                    </div>\r\n\r\n                    <input type=\"submit\" value=\"Finalizar cadastro\" />\r\n                    \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 3 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cadastro\Index.cshtml"
AddHtmlAttributeValue("", 87, Url.Action("CadastrarCliente", "Cadastro"), 87, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2355, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
