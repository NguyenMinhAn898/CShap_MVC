#pragma checksum "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef985861820db35e2dfd891a290cf38c3570423b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Create), @"mvc.1.0.view", @"/Views/Blog/Create.cshtml")]
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
#line 1 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef985861820db35e2dfd891a290cf38c3570423b", @"/Views/Blog/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Create.cshtml"
  
    ViewData["Title"] = "New Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"create-blog\">\r\n    <div class=\"card px-1\">\r\n        <div class=\"card-header py-0\">\r\n            <h4>New Blogs</h4>\r\n        </div>\r\n        <div class=\"card-body p-2 with-50\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b3708", async() => {
                WriteLiteral(@"
                <div class=""row align-items-center"">
                    <div class=""col-12 m-1"">
                        <label for=""inputNewTitleBlog"" class=""col-form-label"">Tiêu đề</label>
                        <input type=""password"" id=""inputNewTitleBlog"" class=""form-control "">
                    </div>

                    <div class=""col-12 m-1"">
                        <label for=""inputShortDescTitleBlog"" class=""col-form-label"">Mô tả ngắn</label>
                        <input type=""password"" id=""inputShortDescTitleBlog"" class=""form-control"">
                    </div>

                    <div class=""col-12 m-1"">
                        <label for=""inputDescTitleBlog"" class=""col-form-label"">Chi tiết</label>
                        <textarea class=""form-control"" rows=""7"" id=""floatingTextarea2"" style=""height: 100px""></textarea>
                    </div>

                    <div class=""col-md-12 m-1 input-img-create-blog"">
                        <label for=""formFile"" class=""col-f");
                WriteLiteral(@"orm-label"">Hình ảnh</label>
                        <input class=""form-control "" id=""formFile"" type=""file"">
                    </div>

                    <div class=""col-md-12 m-1"">
                        <label for=""inputState"" class=""col-form-label"">Loại</label>
                        <select id=""inputState"" class=""form-control with-25"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b5466", async() => {
                    WriteLiteral("Thời sự");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b6832", async() => {
                    WriteLiteral("Thế giới");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b7876", async() => {
                    WriteLiteral("Kinh doanh");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b8922", async() => {
                    WriteLiteral("Giải trí");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b9966", async() => {
                    WriteLiteral("Thể thao");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef985861820db35e2dfd891a290cf38c3570423b11010", async() => {
                    WriteLiteral("Pháp luật");
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
                WriteLiteral(@"
                        </select>
                    </div>

                    <div class=""col-md-12 m-1"">
                        <div class=""col-md-12"">
                            <label class=""col-form-label"">Vị trí</label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2366, "\"", 2374, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeVietName"" checked>
                            <label class=""form-check-label"" for=""placeVietName"">
                                Việt Nam
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2724, "\"", 2732, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeAsian"" >
                            <label class=""form-check-label"" for=""placeAsian"">
                                Châu Á
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 3067, "\"", 3075, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeEuro"" >
                            <label class=""form-check-label"" for=""placeEuro"">
                                Châu Âu
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 3409, "\"", 3417, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeAmerica"" >
                            <label class=""form-check-label"" for=""placeAmerica"">
                                Châu Mỹ
                            </label>
                        </div>
                    </div>
                    <div class=""col-md-12 m-1"">
                        <div>
                            <label class=""col-form-label""> Public</label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"">
                            <label class=""form-check-label"" for=""flexRadioDefault1"">
                                Yes
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"" checked>
                            <label class=""form-che");
                WriteLiteral(@"ck-label"" for=""flexRadioDefault2"">
                                No
                            </label>
                        </div>
                    </div>
                    <div class=""col-12 m-1"">
                        <label for=""inputNewTitleBlog"" class=""col-form-label"">Date public</label>
                        <input type=""date"" id=""inputNewTitleBlog"" class=""form-control with-30"" placeholder=""mm/dd/yyyy"">
                    </div>

                    <div class=""col-12 pt-3 text-center"">
                        <button class=""btn btn-success"">Submit</button>
                        <button class=""btn btn-primary""> Clear</button>
                    </div>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
