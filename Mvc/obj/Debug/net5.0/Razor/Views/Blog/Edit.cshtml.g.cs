#pragma checksum "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c33efde3cee752b290953f74ef9bcf5c20bfaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Edit), @"mvc.1.0.view", @"/Views/Blog/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c33efde3cee752b290953f74ef9bcf5c20bfaf", @"/Views/Blog/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Edit.cshtml"
  
    ViewData["Title"] = "Edit Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"edit-blog\">\r\n    <div class=\"card px-1\">\r\n        <div class=\"card-header py-0\">\r\n            <h4>New Blogs</h4>\r\n        </div>\r\n        <div class=\"card-body p-2 with-50\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf3695", async() => {
                WriteLiteral(@"
                <div class=""row align-items-center"">
                    <div class=""col-12 m-1"">
                        <label for=""inputNewTitleBlog"" class=""col-form-label"">Ti??u ?????</label>
                        <input type=""password"" id=""inputNewTitleBlog"" class=""form-control "">
                    </div>

                    <div class=""col-12 m-1"">
                        <label for=""inputShortDescTitleBlog"" class=""col-form-label"">M?? t??? ng???n</label>
                        <input type=""password"" id=""inputShortDescTitleBlog"" class=""form-control"">
                    </div>

                    <div class=""col-12 m-1"">
                        <label for=""inputDescTitleBlog"" class=""col-form-label"">Chi ti???t</label>
                        <textarea class=""form-control"" rows=""5"" id=""floatingTextarea2"" style=""height: 100px""></textarea>
                    </div>

                    <div class=""col-md-12 m-1 input-img-create-blog"">
                        <label for=""formFile"" class=""col-f");
                WriteLiteral(@"orm-label"">H??nh ???nh</label>
                        <input class=""form-control "" id=""formFile"" type=""file"">
                    </div>

                    <div class=""col-md-12 m-1"">
                        <label for=""inputState"" class=""col-form-label"">Lo???i</label>
                        <select id=""inputState"" class=""form-control with-25"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf5453", async() => {
                    WriteLiteral("Th???i s???");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf6819", async() => {
                    WriteLiteral("Th??? gi???i");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf7863", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf8909", async() => {
                    WriteLiteral("Gi???i tr??");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf9953", async() => {
                    WriteLiteral("Th??? thao");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c33efde3cee752b290953f74ef9bcf5c20bfaf10997", async() => {
                    WriteLiteral("Ph??p lu???t");
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
                            <label class=""col-form-label"">V??? tr??</label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2365, "\"", 2373, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeVietName"" checked>
                            <label class=""form-check-label"" for=""placeVietName"">
                                Vi???t Nam
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2723, "\"", 2731, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeAsian"">
                            <label class=""form-check-label"" for=""placeAsian"">
                                Ch??u ??
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 3065, "\"", 3073, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeEuro"">
                            <label class=""form-check-label"" for=""placeEuro"">
                                Ch??u ??u
                            </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 3406, "\"", 3414, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""placeAmerica"">
                            <label class=""form-check-label"" for=""placeAmerica"">
                                Ch??u M???
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
                            <label class=""form-chec");
                WriteLiteral(@"k-label"" for=""flexRadioDefault2"">
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
