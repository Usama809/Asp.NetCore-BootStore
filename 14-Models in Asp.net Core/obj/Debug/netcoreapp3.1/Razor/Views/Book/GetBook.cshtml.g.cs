#pragma checksum "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5484dfb6d2acbb59befb0eed58be29f6c2bfa05b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5484dfb6d2acbb59befb0eed58be29f6c2bfa05b", @"/Views/Book/GetBook.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_14_Models_in_Asp.net_Core.Models.BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
   
ViewData["Title"] = "Book Detail"+ Model.Title;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Book Store</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
");
#nullable restore
#line 15 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 17 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 563, "\"", 594, 1);
#nullable restore
#line 17 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 571, i==0 ? "active" : "", 571, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 18 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 23 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 839, "\"", 897, 1);
#nullable restore
#line 25 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 847, i==0 ? "carousel-item active" : "carousel-item", 847, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 955, "\"", 982, 1);
#nullable restore
#line 26 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 961, Model.Gallery[i].URL, 961, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "  alt=\"", 983, "\"", 1012, 1);
#nullable restore
#line 26 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 990, Model.Gallery[i].Name, 990, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 28 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 45 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"label  label-primary\">By: </span>\r\n                    <span class=\"text-monospace\">");
#nullable restore
#line 51 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">");
#nullable restore
#line 57 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <a class=""btn btn-outline-danger"" data-toggle=""model"" data-target=""#exampleModel"">
                    Read Now</a>
                </div>
            </div>
            <hr />
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span>");
#nullable restore
#line 70 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                                                                        Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages - </span>");
#nullable restore
#line 71 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                                                                           Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language - </span>");
#nullable restore
#line 72 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
                                                                                        Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

            </ul>
        </div>   
    </div>
    <div class=""model fade"" id=""exampleModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModelLebdy"">
        <div class=""model-dialog modal-lg"" role=""document"">
            <div class=""model-content"">
                <div class=""model-header"">
                    <button type=""button"" class=""close"" data-dismiss=""model"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""model-body"">
                    <embed");
            BeginWriteAttribute("src", " src=\"", 3609, "\"", 3632, 1);
#nullable restore
#line 86 "E:\Dot net Projects\Asp.net core project\14-Models in Asp.net Core\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 3615, Model.BookPdfUrl, 3615, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\">\r\n");
            WriteLiteral(@"
                </div>
                <div class=""model-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""model"">Close</button>
                </div>

            </div>
        </div>
    </div>

</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_14_Models_in_Asp.net_Core.Models.BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
