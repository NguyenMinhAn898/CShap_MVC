#pragma checksum "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0566778783ef1bf7c4ae617a9fd3fc5696cb1a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0566778783ef1bf7c4ae617a9fd3fc5696cb1a", @"/Views/Blog/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
  
    ViewData["Title"] = "Search Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"list-search-blog\">\r\n    <div class=\"card px-1\">\r\n        <div class=\"card-header py-0\">\r\n            <h4>Search Blog</h4>\r\n        </div>\r\n        <div class=\"card-body px-1\">\r\n            <div class=\"search-blog py-3\">\r\n");
#nullable restore
#line 14 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                 using (Html.BeginForm("Search", "Blog", FormMethod.Get, new { @class = "needs-validation", enctype = "application/x-www-form-urlencoded" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row  align-items-center"">
                        <div class=""col-md-2"">
                            <label for=""Title"" class=""col-form-label"">Tiêu đề</label>
                        </div>
                        <div class=""col-md-10"">
                            ");
#nullable restore
#line 21 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                       Write(Html.TextBox("Title", Model.Title_Search, new { @class = "form-control", placeholder = "Tiêu đề" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-12 py-3\">\r\n                            <button class=\"btn btn-success\" type=\"submit\"> Search</button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 27 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
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
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1915, 0);
            EndWriteAttribute();
            WriteLiteral(" scope=\"col\">Delete</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 45 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                         foreach (BlogModel blog in Model.listBlogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 48 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                           Write(Html.DisplayFor(Id => blog.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td> ");
#nullable restore
#line 49 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                Write(Html.DisplayFor(title => blog.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    Thời sự\r\n                                </td>\r\n");
#nullable restore
#line 53 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                  
                                    if (blog.Is_active)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Yes</td>\r\n");
#nullable restore
#line 57 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>No</td>\r\n");
#nullable restore
#line 61 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 64 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(Html.DisplayFor(place => blog.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(Html.DisplayFor(place => blog.Public_Date_Str));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", "Blog", new { id = blog.Id }, new { @class = "link-primary tex-center" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <button class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\'", 3532, "\'", 3562, 3);
            WriteAttributeValue("", 3542, "deleteBlog(", 3542, 11, true);
#nullable restore
#line 73 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
WriteAttributeValue("", 3553, blog.Id, 3553, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3561, ")", 3561, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 76 "F:\MyWork\AspNet\DevFast\Learning\Mvc\Mvc\Views\Blog\Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
