#pragma checksum "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c813345cb76ed20bee7d0da75626c29b6018014b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_blogDetail), @"mvc.1.0.view", @"/Views/Home/blogDetail.cshtml")]
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
#line 3 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\_ViewImports.cshtml"
using BlogProjectFront.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\_ViewImports.cshtml"
using BlogProjectFront.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c813345cb76ed20bee7d0da75626c29b6018014b", @"/Views/Home/blogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60452bd323ea9d4c9bb3ab356e82697ae5a78a3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_blogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/AddComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BlogProjectFront.TagHelpers.ImageTagHelper __BlogProjectFront_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
  
    var comments = (List<CommentListModel>)ViewBag.Comments;
        void GetComments(List<CommentListModel> comments)
 {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
     if (comments.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
         foreach (var comment in comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media my-3\">\r\n            <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 360, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">");
#nullable restore
#line 13 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
                            Write(comment.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                ");
#nullable restore
#line 14 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
           Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary float-right\"");
            BeginWriteAttribute("onclick", " onclick=", 585, "", 638, 5);
            WriteAttributeValue("", 594, "showCommentForm(", 594, 16, true);
#nullable restore
#line 15 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
WriteAttributeValue("", 610, comment.Id, 610, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 621, ",", 621, 1, true);
#nullable restore
#line 15 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
WriteAttributeValue("", 622, comment.BlogId, 622, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 637, ")", 637, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Cevapla</button>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 677, "\"", 705, 2);
            WriteAttributeValue("", 682, "commentBox", 682, 10, true);
#nullable restore
#line 16 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
WriteAttributeValue("", 692, comment.Id, 692, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
                  
                    GetComments(@comment.SubComments);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
            
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
     
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Title -->\r\n<h1 class=\"mt-4\">");
#nullable restore
#line 30 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<!-- Author -->\r\n");
            WriteLiteral("\r\n<hr>\r\n\r\n<!-- Date/Time -->\r\n<p>Posted on ");
#nullable restore
#line 41 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
        Write(Model.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Preview Image -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c813345cb76ed20bee7d0da75626c29b6018014b8648", async() => {
            }
            );
            __BlogProjectFront_TagHelpers_ImageTagHelper = CreateTagHelper<global::BlogProjectFront.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__BlogProjectFront_TagHelpers_ImageTagHelper);
#nullable restore
#line 46 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
__BlogProjectFront_TagHelpers_ImageTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __BlogProjectFront_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
__BlogProjectFront_TagHelpers_ImageTagHelper.BlogImageType = BlogImageType.BlogDetail;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("blog-image-type", __BlogProjectFront_TagHelpers_ImageTagHelper.BlogImageType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<hr>\r\n\r\n<!-- Post Content -->\r\n");
#nullable restore
#line 51 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Comments Form -->\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Yorum Yaz: </h5>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c813345cb76ed20bee7d0da75626c29b6018014b10883", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"BlogId\"");
                BeginWriteAttribute("value", " value=\"", 1536, "\"", 1553, 1);
#nullable restore
#line 58 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
WriteAttributeValue("", 1544, Model.Id, 1544, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">   
            <div class=""form-group"">
                <label>G??z??kmesini ??stedi??iniz Ad: </label>
                <input type=""text"" class=""form-control"" name=""AuthorName"" required>
            </div>
            <div class=""form-group"">
                <label>E-mail Adresiniz: </label>
                <input type=""text"" class=""form-control"" name=""AuthorEmail"" required>
            </div>
            <div class=""form-group"">
                <label>Yorumunuz: </label>
                <textarea class=""form-control"" rows=""3"" name=""Description""></textarea>
            </div>
            <button type=""submit"" class=""btn btn-primary"">G??nder</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<!-- Comment with nested comments -->\r\n");
#nullable restore
#line 78 "C:\Users\User\Documents\VisualStudioCodes\BlogProjectFront\Views\Home\blogDetail.cshtml"
  
    GetComments(comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Javascript", async() => {
                WriteLiteral(@"
<script>
      function showCommentForm(id,blogId){
      let html = `<form method=""POST"" action=""/Home/AddComment""> <input type=""hidden"" name=""BlogId"" value=""${blogId}""> <input type=""hidden"" name=""ParentCommentId"" value=""${id}""> <div class=""form-group""> 
        <label class=""mt-3"">G??z??kmesini ??stedi??iniz Ad: </label> <input type=""text"" class=""form-control"" name=""AuthorName"" required> </div><div class=""form-group""> 
        <label>E-mail Adresiniz: </label> <input type=""text"" class=""form-control"" name=""AuthorEmail"" required> </div><div class=""form-group""> 
        <label>Yorumunuz: </label> <textarea class=""form-control"" rows=""3"" name=""Description""></textarea> </div><button type=""submit"" class=""btn btn-warning"" onclick=hideCommentForm(${id})>Vazge??</button> <button type=""submit"" class=""btn btn-primary"">G??nder</button> </form>`;
      $(""#commentBox""+id).html(html);
      }

      function hideCommentForm(id){
            $(""#commentBox""+id).html("""");
      }
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
