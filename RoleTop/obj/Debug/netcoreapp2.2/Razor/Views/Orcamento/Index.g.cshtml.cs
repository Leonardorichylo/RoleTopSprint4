#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a487ff224663239c784106530eb461dab8369079"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a487ff224663239c784106530eb461dab8369079", @"/Views/Orcamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Orcamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.OrcamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(119, 9961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a487ff224663239c784106530eb461dab83690794498", async() => {
                BeginContext(184, 207, true);
                WriteLiteral("\r\n                    <div>\r\n                        <label for=\"nome\">Nome Completo</label>\r\n                        <br />\r\n                        <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 391, "\"", 418, 1);
#line 8 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 399, Model.Cliente.Nome, 399, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(419, 263, true);
                WriteLiteral(@" name=""nome"" />
                    </div>
        
                    <div>
                        <label for=""endereco"">Endereço</label>
                        <br />
                        <input id=""endereco"" type=""text"" maxlength=""20"" minlength=""3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 682, "\"", 713, 1);
#line 14 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 690, Model.Cliente.Endereco, 690, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(714, 251, true);
                WriteLiteral(" name=\"endereco\" />\r\n                    </div>\r\n        \r\n                    <div>\r\n                        <label for=\"telefone\">Telefone para contato</label>\r\n                        <br />\r\n                        <input id=\"telefone\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 965, "\"", 996, 1);
#line 20 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 973, Model.Cliente.Telefone, 973, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(997, 230, true);
                WriteLiteral(" name=\"telefone\"/>\r\n                    </div>\r\n        \r\n                    <div>\r\n                        <label for=\"email\">E-mail</label>\r\n                        <br />\r\n                        <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1227, "\"", 1255, 1);
#line 26 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 1235, Model.Cliente.Email, 1235, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1256, 271, true);
                WriteLiteral(@" name=""email"" />
                    </div>

                    <div>
                        <label for=""cpf/cnpj"">CPF/CNPJ</label>
                        <br />
                        <input id=""cpf/cnpj"" type=""cpf"" name=""cpf/cnpj"" placeholder=""123.456.789-56""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1527, "\"", 1553, 1);
#line 32 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
WriteAttributeValue("", 1535, Model.Cliente.Cpf, 1535, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1554, 291, true);
                WriteLiteral(@" />
                    </div>
        
                    <div class=""double-field"">
                        <div>
                            <label for=""evento"">Evento</label>
                            <select id=""evento"" name=""evento"" required>
                                ");
                EndContext();
                BeginContext(1845, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a487ff224663239c784106530eb461dab83690798616", async() => {
                    BeginContext(1881, 9, true);
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
                BeginContext(1899, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                 foreach (var evento in Model.Eventos)
                                {

#line default
#line hidden
                BeginContext(2008, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2044, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a487ff224663239c784106530eb461dab836907911112", async() => {
                    BeginContext(2072, 11, false);
#line 42 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                          Write(evento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2083, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2089, 12, false);
#line 42 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                                           Write(evento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2101, 80, true);
                    WriteLiteral("\r\n                                        \r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
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
                BeginContext(2190, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2227, 743, true);
                WriteLiteral(@"                            </select>
                            </div>
                        <!--<div>
                            <label for=""tipo_evento"">Tipo de Evento</label>
                            <select id=""tipo_evento"">
                                <option value="""" disabled selected>Selecione</option>
                                <option>Publico</option>
                                <option>Fechado</option>
                            </select>
                        </div>-->
                        <div>
                            <label for=""pacoteServicos"">Pacote Serviços</label>
                            <select id=""pacoteServicos"" name=""pacoteServicos"">
                                ");
                EndContext();
                BeginContext(2970, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a487ff224663239c784106530eb461dab836907914859", async() => {
                    BeginContext(3006, 9, true);
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
                BeginContext(3024, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 60 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                 foreach (var p in Model.PacotesServicos)
                                {

#line default
#line hidden
                BeginContext(3136, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(3172, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a487ff224663239c784106530eb461dab836907917358", async() => {
                    BeginContext(3195, 6, false);
#line 62 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                     Write(p.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(3201, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(3207, 7, false);
#line 62 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                                                 Write(p.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 62 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
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
                BeginContext(3223, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 63 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Orcamento\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(3260, 6813, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>

                        <!--
                        <div class=""double-field"">
                        <label for=""data_evento"">Data Inicio Evento:</label>
                        <input type=""date"" name=""bday"" min=""2019-09-10""><br><br>
                    </div>
                    <div class=""double-field"">
                        <label for=""data_evento"">Data Fim Evento:</label>
                        <input type=""date"" name=""bday"" max=""2019-12-31""><br><br>
                    </div>

                    <div class=""double-field"">
                            <label for=""convidados"">Quant. Convidados</label>
                            <input type=""number"" min=""1"" max=""300"" id=""convidados""><br><br>
                    </div> -->

                    <!--
                    <div class=""double-field"">
                    <label for=""CartãoCredito"">Cartão Crédito</label>    
               ");
                WriteLiteral(@"             <div>
                                <label for=""CartãoCredito"">Forma de Pagamento</label>
                                <select id=""CartãoCredito"" required>
                                    <option value="""" disabled selected>Selecione</option>
                                    <option value=""Sim"">1x com desconto de até 10% - R$ 9.000,00</option>
                                    <option value=""Sim"">2x com desconto de até 5% - R$ 475,00</option>
                                    <option value=""Sim"">3x com desconto de até 5% - R$ 316,66</option>
                                    <option value=""Sim"">4x sem juros - R$ 2.500,00</option>
                                    <option value=""Sim"">5x sem juros</option>
                                    <option value=""Sim"">6x sem juros</option>
                                    <option value=""Sim"">7x sem juros</option>
                                    <option value=""Sim"">8x sem juros</option>
                                ");
                WriteLiteral(@"    <option value=""Sim"">9x sem juros</option>
                                    <option value=""Sim"">10x sem juros</option>
                                    <option value=""Sim"">11x sem juros</option>
                                    <option value=""Sim"">12x sem juros</option>
                                </select>
                            </div>
                    </div>
                            <div>
                                <label for=""CartãoNome"">Nome (Escrito no cartão)</label>
                        <br />
                        <input id=""CartãoNome"" type=""text"" maxlength=""20"" minlength=""3"" name=""CartãoNome""/>
                            </div>
                            <div>
                                    <label for=""CartãoNumero"">Numero Cartão</label>
                            <br />
                            <input id=""CartãoNumero"" type=""number"" maxlength=""20"" minlength=""3"" name=""CartãoNumero"" placeholder=""Somente números, Sem espaços""/>
          ");
                WriteLiteral(@"                  </div>
                            
                                <div>
                                    <label for=""Validade Cartão"">Validade (mm/aa)</label>
                                    <select id=""CartãoCredito"" required>
                                        <option value="""" disabled selected></option>
                                        <option value=""Numero"">01</option>
                                        <option value=""Numero"">02</option>
                                        <option value=""Numero"">03</option>
                                        <option value=""Numero"">04</option>
                                        <option value=""Numero"">05</option>
                                        <option value=""Numero"">06</option>
                                        <option value=""Numero"">07</option>
                                        <option value=""Numero"">08</option>
                                        <option value=""Numero"">09</opt");
                WriteLiteral(@"ion>
                                        <option value=""Numero"">10</option>
                                        <option value=""Numero"">11</option>
                                        <option value=""Numero"">12</option> 
                                    </select>
                                    <select id=""CartãoCredito"" required>
                                            <option value="""" disabled selected></option>
                                            <option value=""Numero"">19</option>
                                            <option value=""Numero"">20</option>
                                            <option value=""Numero"">21</option>
                                            <option value=""Numero"">22</option>
                                            <option value=""Numero"">23</option>
                                            <option value=""Numero"">24</option>
                                            <option value=""Numero"">25</option>
                  ");
                WriteLiteral(@"                          <option value=""Numero"">26</option>
                                            <option value=""Numero"">27</option>
                                            <option value=""Numero"">28</option>
                                            <option value=""Numero"">29</option>
                                    </select>
                                </div>
                                <div class=""double-field"">
                                    <label for=""cod.segurança"">Codigo Segurança:</label>
                                    <input type=""number"" min=""1"" max=""300"" id=""cod.segurança"">
                                    <p>(Últimos 3 dígitos atrás do cartão ou 4 digitos na frente se for American Express)</p>
                                </div>
                    
                                <div>
                                    <label for=""cpf/cnpj"">CPF ou CNPJ do proprietário do cartão:</label>
                                    <br />
           ");
                WriteLiteral(@"                         <input id=""cpf/cnpj"" type=""cpf"" placeholder=""123.456.789-56""/>
                                </div>
                                <div class=""double-field"">
                                        <label for=""data_evento"">Data Nascimento</label>
                                        <input type=""date"" name=""bday"" min=""1900-01-01"" max=""2020-01-01""><br><br>
                                </div>-->
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
AddHtmlAttributeValue("", 146, Url.Action("Registrar","Orcamento"), 146, 36, false);

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
            BeginContext(10080, 31, true);
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
