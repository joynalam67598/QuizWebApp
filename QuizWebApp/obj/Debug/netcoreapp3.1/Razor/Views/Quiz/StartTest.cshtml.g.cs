#pragma checksum "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbf5608df5f03bcad13e1cfa87e74418114ddbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_StartTest), @"mvc.1.0.view", @"/Views/Quiz/StartTest.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\_ViewImports.cshtml"
using QuizWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\_ViewImports.cshtml"
using QuizWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbf5608df5f03bcad13e1cfa87e74418114ddbf", @"/Views/Quiz/StartTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f5dc924a7b2c99d375bbd3a259bdb39246ec8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quiz_StartTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuizWebApp.Models.QuizModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowTestResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
  
    ViewData["Title"] = "Start Quiz";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-12 text-center\">\r\n    <h3>Hello Test</h3>\r\n    <h5>Date - ");
#nullable restore
#line 9 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
          Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbf5608df5f03bcad13e1cfa87e74418114ddbf5607", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
      
        int count = 0;
        foreach (var item in Model)
        {
            count += 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbf5608df5f03bcad13e1cfa87e74418114ddbf6177", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 19 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"col-sm-12 bg-light mt-2 p-1 border border-secondary border-1\">\r\n                ");
#nullable restore
#line 21 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 21 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
                   Write(item.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <input type=\"hidden\" name=\"questionId\"");
                BeginWriteAttribute("value", " value=\"", 701, "\"", 717, 1);
#nullable restore
#line 23 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
WriteAttributeValue("", 709, item.Id, 709, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            <div class=\"col-sm-12 row mt-2\">\r\n                <div class=\"col-sm-6 bg-light m-1 border-secondary\">\r\n                    <input type=\"radio\" value=\"A\" required");
                BeginWriteAttribute("name", " name=\"", 896, "\"", 920, 2);
                WriteAttributeValue("", 903, "question_", 903, 9, true);
#nullable restore
#line 26 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
WriteAttributeValue("", 912, item.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <label >a.  ");
#nullable restore
#line 27 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
                           Write(item.OptionA);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-sm-6 bg-light m-1 border-secondary\">\r\n                    <input type=\"radio\" value=\"B\" required");
                BeginWriteAttribute("name", " name=\"", 1132, "\"", 1156, 2);
                WriteAttributeValue("", 1139, "question_", 1139, 9, true);
#nullable restore
#line 30 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
WriteAttributeValue("", 1148, item.Id, 1148, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <label>b.  ");
#nullable restore
#line 31 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
                          Write(item.OptionB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-sm-6 bg-light m-1 border-secondary\">\r\n                    <input type=\"radio\" value=\"C\" required");
                BeginWriteAttribute("name", " name=\"", 1367, "\"", 1391, 2);
                WriteAttributeValue("", 1374, "question_", 1374, 9, true);
#nullable restore
#line 34 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
WriteAttributeValue("", 1383, item.Id, 1383, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <label>c.  ");
#nullable restore
#line 35 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
                          Write(item.OptionC);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-sm-6 bg-light m-1 border-secondary\">\r\n                    <input type=\"radio\" value=\"D\"required");
                BeginWriteAttribute("name", " name=\"", 1601, "\"", 1625, 2);
                WriteAttributeValue("", 1608, "question_", 1608, 9, true);
#nullable restore
#line 38 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
WriteAttributeValue("", 1617, item.Id, 1617, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <label>d.  ");
#nullable restore
#line 39 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
                          Write(item.OptionD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbf5608df5f03bcad13e1cfa87e74418114ddbf12539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Project\Dotnet\QuizWebApp\QuizWebApp\QuizWebApp\Views\Quiz\StartTest.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"col-sm-6\">\r\n        <input type=\"submit\" onclick=\"return confirm(\'Do you want to submit?\')\" value=\"Submit\" class=\"btn btn-block btn-info mt-3  mb-2\" />\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuizWebApp.Models.QuizModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591