#pragma checksum "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9e5e8954612fb401d6fa81ef63a1cef071feec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9e5e8954612fb401d6fa81ef63a1cef071feec", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "List Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""list-blog"">
    <div class=""card px-1"">
        <div class=""card-header p-0"">
            <h4>List Blog</h4>
        </div>
        <div class=""card-body"">
            <div class=""table table-list-blog"">
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
            BeginWriteAttribute("class", " class=\"", 928, "\"", 936, 0);
            EndWriteAttribute();
            WriteLiteral(" scope=\"col\">Delete</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 26 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Index.cshtml"
                         foreach (BlogModel blog in ViewBag.listBlog)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 29 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Index.cshtml"
                                           Write(blog.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>mdo</td>
                                <th>1</th>
                                <td>Mark</td>
                                <td>
                                    <a class=""link-primary""> <span>Edit</span></a>
                                </td>
                                <td>
                                    <button class=""btn btn-outline-danger"">Delete</button>
                                </td>
                            </tr>
");
#nullable restore
#line 42 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
