#pragma checksum "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1489f52589e62cf063aebbcabeac5ebb7b1232be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Search), @"mvc.1.0.view", @"/Views/Blog/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1489f52589e62cf063aebbcabeac5ebb7b1232be", @"/Views/Blog/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/blog/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("application/x-www-form-urlencoded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
  
    ViewData["Title"] = "Search Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"list-search-blog\">\r\n    <div class=\"card px-1\">\r\n        <div class=\"card-header py-0\">\r\n            <h4>Search Blog</h4>\r\n        </div>\r\n        <div class=\"card-body px-1\">\r\n            <div class=\"search-blog py-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1489f52589e62cf063aebbcabeac5ebb7b1232be4691", async() => {
                WriteLiteral(@"
                    <div class=""row  align-items-center"">
                        <div class=""col-md-2"">
                            <label for=""inputSearchTitleBlog"" class=""col-form-label"">Tiêu đề</label>
                        </div>
                        <div class=""col-md-10"">
                            <input type=""text"" name=""Title"" id=""inputSearchTitleBlog"" class=""form-control "" placeholder=""Tiêu đề""");
                BeginWriteAttribute("value", " value=\"", 808, "\"", 834, 1);
#nullable restore
#line 20 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
WriteAttributeValue("", 816, ViewBag.SearchStr, 816, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-12 py-3\">\r\n                            <button class=\"btn btn-success\" type=\"submit\"> Search</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            </div>
            <div class=""table table-list-blog"">
                <h4>List Blogs</h4>
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""row-id"" scope=""col"">ID</th>
                            <th class=""col-md-4"" scope=""col"">Tin</th>
                            <th class=""col-md-1"" scope=""col"">Loại</th>
                            <th class=""col-md-1"" scope=""col"">Trạng thái</th>
                            <th class=""col-md-1"" scope=""col"">Vị trí</th>
                            <th class=""col-md-2"" scope=""col"">Ngày public</th>
                            <th class=""col-md-1"" scope=""col"">Edit</th>
                            <th");
            BeginWriteAttribute("class", " class=\"", 1878, "\"", 1886, 0);
            EndWriteAttribute();
            WriteLiteral(" scope=\"col\">Delete</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 44 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                         foreach (BlogModel blog in ViewBag.listSearchBlog)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 47 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                           Write(blog.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 48 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Otto</td>\r\n");
#nullable restore
#line 50 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                  
                                    if (blog.Is_active)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Yes</td>\r\n");
#nullable restore
#line 54 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>No</td>\r\n");
#nullable restore
#line 58 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>");
#nullable restore
#line 60 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(blog.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 61 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(blog.Public_Date_Str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"link-primary\"");
            BeginWriteAttribute("href", " href=\'", 2953, "\'", 2998, 3);
#nullable restore
#line 63 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
WriteAttributeValue("", 2960, Url.Action("Edit","Blog"), 2960, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2986, "?id=", 2986, 4, true);
#nullable restore
#line 63 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
WriteAttributeValue("", 2990, blog.Id, 2990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span>Edit</span></a>\r\n                                </td>\r\n                                <td>\r\n                                    <button class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\'", 3175, "\'", 3205, 3);
            WriteAttributeValue("", 3185, "deleteBlog(", 3185, 11, true);
#nullable restore
#line 66 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
WriteAttributeValue("", 3196, blog.Id, 3196, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3204, ")", 3204, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
