#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a170221e19c65f573be8ae8922f8212542d665f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orcamento_Index), @"mvc.1.0.view", @"/Views/Orcamento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orcamento/Index.cshtml", typeof(AspNetCore.Views_Orcamento_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a170221e19c65f573be8ae8922f8212542d665f", @"/Views/Orcamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Orcamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.OrcamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 40, true);
            WriteLiteral("<main>\r\n        <h2>Faça seu Orçamento! ");
            EndContext();
            BeginContext(87, 17, false);
#line 3 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                           Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(104, 15, true);
            WriteLiteral("</h2>\r\n        ");
            EndContext();
            BeginContext(119, 4114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f4499", async() => {
                BeginContext(185, 207, true);
                WriteLiteral("\r\n                    <div>\r\n                        <label for=\"nome\">Nome Completo</label>\r\n                        <br />\r\n                        <input id=\"nome\" type=\"nome\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 392, "\"", 419, 1);
#line 8 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 400, Model.Cliente.Nome, 400, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(420, 267, true);
                WriteLiteral(@" name=""nome"" />
                    </div>
        
                    <div>
                        <label for=""endereco"">Endereço</label>
                        <br />
                        <input id=""endereco"" type=""endereco"" maxlength=""20"" minlength=""3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 687, "\"", 718, 1);
#line 14 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 695, Model.Cliente.Endereco, 695, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(719, 247, true);
                WriteLiteral(" name=\"endereco\" />\r\n                    </div>\r\n\r\n                    <div>\r\n                        <label for=\"telefone\">Telefone para contato</label>\r\n                        <br />\r\n                        <input id=\"telefone\" type=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 966, "\"", 997, 1);
#line 20 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 974, Model.Cliente.Telefone, 974, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(998, 230, true);
                WriteLiteral(" name=\"telefone\"/>\r\n                    </div>\r\n        \r\n                    <div>\r\n                        <label for=\"email\">E-mail</label>\r\n                        <br />\r\n                        <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1228, "\"", 1256, 1);
#line 26 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 1236, Model.Cliente.Email, 1236, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1257, 251, true);
                WriteLiteral(" name=\"email\" />\r\n                    </div>\r\n\r\n                    <div>\r\n                        <label for=\"cpf\">CPF</label>\r\n                        <br />\r\n                        <input id=\"cpf\" type=\"cpf\" name=\"cpf\" placeholder=\"123.456.789-56\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1508, "\"", 1534, 1);
#line 32 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 1516, Model.Cliente.Cpf, 1516, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1535, 520, true);
                WriteLiteral(@" />
                    
                    <div class=""double-field"">
                        <label for=""data_evento"">Data do Evento:</label>
                        <input id=""evento_evento"" type=""date"" name=""data_evento""><br><br>
                    </div>


                    <div class=""double-field"">
                        <div>
                            <label for=""evento"">Evento</label>
                            <select id=""evento"" name=""evento"" required>
                                ");
                EndContext();
                BeginContext(2055, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f8847", async() => {
                    BeginContext(2091, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                EndContext();
                BeginContext(2109, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                 foreach (var evento in Model.Eventos)
                                {

#line default
#line hidden
                BeginContext(2218, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2254, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f11342", async() => {
                    BeginContext(2282, 11, false);
#line 47 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                          Write(evento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2293, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2299, 12, false);
#line 47 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                                           Write(evento.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                      WriteLiteral(evento.Nome);

#line default
#line hidden
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
                EndContext();
                BeginContext(2320, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2357, 299, true);
                WriteLiteral(@"                            </select>
                            </div>
                        <div>
                            <label for=""pacoteServicos"">Pacote Serviços</label>
                            <select id=""pacoteServicos"" name=""pacoteServicos"">
                                ");
                EndContext();
                BeginContext(2656, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f14430", async() => {
                    BeginContext(2692, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                EndContext();
                BeginContext(2710, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 55 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                 foreach (var p in Model.PacotesServicos)
                                {

#line default
#line hidden
                BeginContext(2822, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2858, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f16929", async() => {
                    BeginContext(2881, 6, false);
#line 57 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                     Write(p.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2887, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2893, 7, false);
#line 57 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                                 Write(p.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 57 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                      WriteLiteral(p.Nome);

#line default
#line hidden
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
                EndContext();
                BeginContext(2909, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2946, 336, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    
                    <div>
                        <label for=""tipo_evento"">Tipo de Evento</label>
                            <select id=""tipo_evento"" name=""tipo_evento"" required>
                                ");
                EndContext();
                BeginContext(3282, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f20022", async() => {
                    BeginContext(3317, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                EndContext();
                BeginContext(3335, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3369, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f22169", async() => {
                    BeginContext(3377, 7, true);
                    WriteLiteral("Publico");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3393, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3427, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f23459", async() => {
                    BeginContext(3435, 7, true);
                    WriteLiteral("Fechado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3451, 302, true);
                WriteLiteral(@"
                            </select>
                    </div>

                    <div>
                        <label for=""forma_pagamento"">Forma de Pagamento</label>
                            <select id=""forma_pagamento"" name=""forma_pagamento"" required>
                                ");
                EndContext();
                BeginContext(3753, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f25023", async() => {
                    BeginContext(3788, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                EndContext();
                BeginContext(3806, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3840, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f27170", async() => {
                    BeginContext(3849, 17, true);
                    WriteLiteral("Cartão de Credito");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3875, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3909, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a170221e19c65f573be8ae8922f8212542d665f28471", async() => {
                    BeginContext(3918, 6, true);
                    WriteLiteral("Boleto");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3933, 293, true);
                WriteLiteral(@"
                            </select>
                    </div>


                    <p>Após a confirmação do pagamento, analisaremos o Orçamento, caso seja recusado o valor será estornado.</p>
                    <input type=""submit"" value=""Finalizar Orçamento!"" />
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
AddHtmlAttributeValue("", 147, Url.Action("Registrar","Orcamento"), 147, 36, false);

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
            BeginContext(4233, 31, true);
            WriteLiteral("\r\n        \r\n            </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop.ViewModels.OrcamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
