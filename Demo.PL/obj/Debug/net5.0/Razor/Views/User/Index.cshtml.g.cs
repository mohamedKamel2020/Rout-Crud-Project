#pragma checksum "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1deaaf42f029de798403172af457aceda97d8cc937538a095b23efc092896d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1deaaf42f029de798403172af457aceda97d8cc937538a095b23efc092896d75", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7bcbe0ffd9b920fd640d8c60f3b9b6118b078da03fc819c80df24f6d7e3aa2f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"mb-4\">All Users</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1deaaf42f029de798403172af457aceda97d8cc937538a095b23efc092896d755492", async() => {
                WriteLiteral(@"
	<div class=""row align-items-center justify-content-center"">
		<div class=""col-8"">
			<input type=""text"" placeholder=""Search By Name"" name=""SearchValue"" class=""form-control"" />
		</div>
		<div class=""col-4"">
			<input type=""submit"" value=""Search"" class=""btn btn-primary""/>
		</div>
	</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<table class=\"mt-3 table table-hover table-striped\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\r\n\t\t\t\t<th>");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 27 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>Details</th>\r\n\t\t\t\t<th>Update</th>\r\n\t\t\t\t<th>Delete</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
             foreach (var user in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(M=>@user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 38 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(M=>@user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(M=>@user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 40 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(M=>@user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1deaaf42f029de798403172af457aceda97d8cc937538a095b23efc092896d7510516", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 41 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = user.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 43 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
#nullable restore
#line 46 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"mt-5 alert alert-warning\">\r\n\t\t<h3>There is no User</h3>\r\n\t</div>\r\n");
#nullable restore
#line 52 "C:\Users\Dell\Desktop\MY PC\programing\My-code\1-ASP.NET\G02 Demo Solution\Demo.PL\Views\User\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
