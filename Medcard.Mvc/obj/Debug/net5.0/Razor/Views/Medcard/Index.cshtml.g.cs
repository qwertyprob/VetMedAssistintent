#pragma checksum "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "209bea7fe38a20b8bfe53acd14ac2a94f0306fc2fdd976c53faf20586dd40ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medcard_Index), @"mvc.1.0.view", @"/Views/Medcard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\_ViewImports.cshtml"
using MedcardMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\_ViewImports.cshtml"
using MedcardMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"209bea7fe38a20b8bfe53acd14ac2a94f0306fc2fdd976c53faf20586dd40ef5", @"/Views/Medcard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"09180920e5912c524d4776c3d951960153164230b13be7020cdf415a84877ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medcard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OwnerModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("VetAsist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
  
    ViewData["Title"] = "Card";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- твоё модальное окно для добавления, можно и для изменения сделать, это уже в js-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209bea7fe38a20b8bfe53acd14ac2a94f0306fc2fdd976c53faf20586dd40ef55315", async() => {
                WriteLiteral(@"
    <div id=""popup"" class=""popup disable"">
        <div class=""popup__box"">
            <input placeholder=""ФИО"" type=""text"" id=""name"" name=""name"">
            <input placeholder=""Номер телефона"" type=""text"" id=""name"" name=""phonenumber"">
            <input placeholder=""Кличка"" type=""text"" id=""nick"" name=""petname"">
            <input placeholder=""Номер чипа"" type=""text"" id=""chip"" name=""chipnumber"">
            <input placeholder=""Возраст"" type=""text"" id=""chip"" name=""age"">
            <input placeholder=""Порода"" type=""text"" id=""nick"" name=""breed"">

            <button class=""list__more"" type=""submit"">Отправить</button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<header class=\"header\">\r\n    <div class=\"logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209bea7fe38a20b8bfe53acd14ac2a94f0306fc2fdd976c53faf20586dd40ef57543", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "209bea7fe38a20b8bfe53acd14ac2a94f0306fc2fdd976c53faf20586dd40ef57783", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
    <div class=""dark-mode"">
        <input type=""checkbox"" class=""checkbox"" id=""checkbox"">
        <label display=""hidden"" for=""checkbox"" class=""checkbox-label"">
            <span class=""ball""></span>
        </label>
    </div>
    <button id=""Add"" type=""button"" class=""btn-input"">Добавить</button>
</header>

<div class=""search"">
    <div class=""search__box search-border"">
        <input placeholder=""Поиск"" class=""search__field__input search-border"" type=""search"" id=""search"" name=""search"">
        <button class=""search__field__btn search-border"" type=""button"">Найти</button>
    </div>
</div>


<section class=""list"">
    <div class=""list__wrapper shadow"">
        <div class=""list__line-title"">
            <p class=""number""> </p>
            <p class=""name"">ФИО</p>
            <p class=""phone"">Номер телефона</p>
            <p class=""nick"">Кличка</p>
            <p class=""chip"">Номер чипа</p>
            <p class=""age"">Возраст</p>
            <p class=""breed"">Порода</p>
      ");
            WriteLiteral("      <p class=\"heal\">Параметры</p>\r\n        </div>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
         if (Model != null && Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list__container\">\r\n");
#nullable restore
#line 59 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"list__lines\">\r\n                        <p class=\"number\"> </p>\r\n                        <p class=\"name\">");
#nullable restore
#line 63 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"phone\">");
#nullable restore
#line 64 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                    Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                         foreach(var pet in item.Pets)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"nick\">");
#nullable restore
#line 67 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                   Write(pet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"chip\">");
#nullable restore
#line 68 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                   Write(pet.ChipNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"age\">");
#nullable restore
#line 69 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                  Write(pet.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"breed\">");
#nullable restore
#line 70 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                    Write(pet.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 71 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list__param\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2871, "\"", 2935, 1);
#nullable restore
#line 73 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
WriteAttributeValue("", 2878, Url.Action("More", "Medcard", new { ownerId = item.Id }), 2878, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list__more\">Подробнее</a>\r\n                            <a class=\"list__more\" type=\"submit\">Изменить</a>\r\n                            <a class=\"list__remove\" type=\"submit\">Удалить</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 78 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""list__line-title"">
                    <p class=""number""> </p>
                    <p class=""name""></p>
                    <p class=""phone""></p>
                    <p class=""nick""></p>
                    <p class=""chip""></p>
                    <p class=""age""></p>
                    <p class=""breed""></p>
                    <p class=""heal""></p>
                </div>
            </div>
");
#nullable restore
#line 90 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
        }
        
           
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 style=\"align-content\">Нет доступных медкарт.</h1>\r\n");
#nullable restore
#line 96 "C:\Users\eqspe\source\repos\MedcardMvcApp\Medcard.Mvc\Views\Medcard\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OwnerModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
