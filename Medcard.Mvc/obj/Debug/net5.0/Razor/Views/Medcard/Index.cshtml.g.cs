#pragma checksum "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36b7baf039e14ecb67b4229bb049b58a6df5a61632678c1d41bf15d227f49de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medcard_Index), @"mvc.1.0.view", @"/Views/Medcard/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\_ViewImports.cshtml"
using MedcardMvc

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\_ViewImports.cshtml"
using Medcard.Mvc.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"36b7baf039e14ecb67b4229bb049b58a6df5a61632678c1d41bf15d227f49de2", @"/Views/Medcard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"23c2bb79ee232ec1a648e9cd240457c20f7417885a3ae83c4b65d02254453f0d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medcard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OwnerModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("VetAsist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMedcard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list__remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
  
    ViewData["Title"] = "Card";
    Layout = "_Layout";




#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b7baf039e14ecb67b4229bb049b58a6df5a61632678c1d41bf15d227f49de25754", async() => {
                WriteLiteral(@"
    <div id=""popup"" class=""popup disable"">
        <div class=""popup__box"">
            <input placeholder=""ФИО"" type=""text"" id=""name"" name=""name"">
            <input placeholder=""Номер телефона"" type=""text"" id=""phonenumber"" name=""phone"">
            <input placeholder=""Кличка"" type=""text"" id=""nick"" name=""petName"">
            <input placeholder=""Номер чипа"" type=""text"" id=""chip"" name=""chipNumber"">
            <input placeholder=""Возраст"" type=""text"" id=""age"" name=""petAge"">
            <input placeholder=""Порода"" type=""text"" id=""breed"" name=""petBreed"">

            <button class=""list__more"" type=""submit"">Отправить</button>
            
        </div>
        <p></p>
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 128, 
#nullable restore
#line 11 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                             Url.Action("CreateMedcard", "Medcard")

#line default
#line hidden
#nullable disable
            , 128, 39, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<header class=\"header\">\r\n    <div class=\"logo\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 982, 1);
            WriteAttributeValue("", 951, 
#nullable restore
#line 31 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                  Url.Action("Index", "Medcard")

#line default
#line hidden
#nullable disable
            , 951, 31, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36b7baf039e14ecb67b4229bb049b58a6df5a61632678c1d41bf15d227f49de29019", async() => {
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
            WriteLiteral(@"
        </a>
    </div>
    <button id=""Add"" type=""button"" class=""btn-input"">Добавить</button>
</header>

<div class=""search"">
    <div class=""search__box search-border"">
        <input placeholder=""Поиск"" class=""search__field__input search-border"" type=""search"" id=""search"" name=""search"">
        <button class=""search__field__btn search-border"" type=""button"">Найти</button>
    </div>
</div>

");
#nullable restore
#line 45 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral(@"    <section class=""list"">
        <div class=""list__wrapper shadow"">
            <div class=""list__line-title"">
                <p class=""number""> </p>
                <p class=""name"">ФИО</p>
                <p class=""phone"">Номер телефона</p>
                <p class=""nick"">Кличка</p>
                <p class=""chip"">Номер чипа</p>
                <p class=""age"">Возраст</p>
                <p class=""breed"">Порода</p>
                <p class=""heal"">Параметры</p>
            </div>

            <div class=""list__container"">
");
#nullable restore
#line 61 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <div class=\"list__lines\">\r\n                        <p class=\"number\"> </p>\r\n                        <p class=\"name\">");
            Write(
#nullable restore
#line 65 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        <p class=\"phone\">");
            Write(
#nullable restore
#line 66 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                          item.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 67 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                         foreach (var pet in item.Pets)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <p class=\"nick\">");
            Write(
#nullable restore
#line 69 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                             pet.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <p class=\"chip\">");
            Write(
#nullable restore
#line 70 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                             pet.ChipNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <p class=\"age\">");
            Write(
#nullable restore
#line 71 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                            pet.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <p class=\"breed\">");
            Write(
#nullable restore
#line 72 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                              pet.Breed

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 73 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        \r\n                        <div class=\"list__param\">\r\n                            \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2806, "\"", 2870, 1);
            WriteAttributeValue("", 2813, 
#nullable restore
#line 77 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                      Url.Action("More", "Medcard", new { ownerId = item.Id })

#line default
#line hidden
#nullable disable
            , 2813, 57, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"list__more\">Подробнее</a>\r\n                            \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2966, "\"", 3039, 1);
            WriteAttributeValue("", 2973, 
#nullable restore
#line 79 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                      Url.Action("UpdateMedcard", "Medcard", new { ownerId = item.Id })

#line default
#line hidden
#nullable disable
            , 2973, 66, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"list__more\">Изменить</a>\r\n\r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b7baf039e14ecb67b4229bb049b58a6df5a61632678c1d41bf15d227f49de215547", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3266, "\"", 3282, 1);
                WriteAttributeValue("", 3274, 
#nullable restore
#line 83 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                                       item.Id

#line default
#line hidden
#nullable disable
                , 3274, 8, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" style=\"background: none; border: none; color: white; \">\r\n                                    Удалить\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 91 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 95 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1 style=\"text-align: center;\">Медкард не найдено. Пожалуйста проверьте данные на наличие ошибок или начните ее вести!</h1>\r\n");
#nullable restore
#line 99 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
}

#line default
#line hidden
#nullable disable

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
