#pragma checksum "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfb5fb9c88d070c4c1d61785b9573157ad9040b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfb5fb9c88d070c4c1d61785b9573157ad9040b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db14fd8ffa430d8fa6b85ac7fa1384d73999f3b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"banner\">\r\n    <div class=\"owl-carousel\">\r\n");
#nullable restore
#line 4 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
         foreach (Banner item in Model.Banner)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"img\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 187, "\"", 207, 2);
            WriteAttributeValue("", 193, "/img/", 193, 5, true);
#nullable restore
#line 7 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
WriteAttributeValue("", 198, item.Img, 198, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <div class=\"overlay\"></div>\r\n                <div class=\"container\">\r\n                    <div class=\"banner-text col-5\">\r\n                        <h5>");
#nullable restore
#line 11 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                       Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h1>");
#nullable restore
#line 12 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p>\r\n                            ");
#nullable restore
#line 14 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                       Write(Html.Raw(item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 581, "\'", 617, 1);
#nullable restore
#line 16 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
WriteAttributeValue("", 588, Url.Action("Index", "Login"), 588, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"buton\"><span></span>start exploring</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>
<!-- AUCTION -->
<section id=""auction"">
    <div class=""container"">
        <div class=""row"">
            <h2 class=""sec-heading"">live auction</h2>
            <p class=""sec-text col-6"">
                Lorem ipsum, dolor sit amet repudiandae sapiente consectetur
                adipisicing elit. Nobis repudiandae sapiente enim magni possimus
                repudiandae sapiente consectetur.
            </p>
        </div>
        <div class=""row"">
");
#nullable restore
#line 35 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
             foreach (Product item in Model.Products)
            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"auc-item col-4 mb-4\">\r\n                <div class=\"auc-img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1420, "\"", 1442, 2);
            WriteAttributeValue("", 1426, "/img/", 1426, 5, true);
#nullable restore
#line 39 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
WriteAttributeValue("", 1431, item.Image, 1431, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         style=\"width: 100%\" />\r\n                    <div class=\"cooldown\">\r\n                        <ul data-countdown=");
#nullable restore
#line 42 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                                      Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
                            <li data-days=""00"">00</li>
                            <li data-hours=""00"">00</li>
                            <li data-minuts=""00"">00</li>
                            <li data-seconds=""00"">00</li>
                        </ul>
                    </div>
                    <div class=""author-area"">
                        <div class=""author-emo"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9dfb5fb9c88d070c4c1d61785b9573157ad9040b7955", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2047, "~/img/", 2047, 6, true);
#nullable restore
#line 51 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2053, item.AppUser.ProfilePhoto, 2053, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"author-name\">\r\n                            <span>by ");
#nullable restore
#line 54 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                                Write(item.AppUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"auc-text\">\r\n                    <h4>");
#nullable restore
#line 59 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"price\">Bidding Price : <span>$");
#nullable restore
#line 60 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
                                                       Write(item.Prise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    <p class=\"bid\"><a");
            BeginWriteAttribute("href", " href=\"", 2513, "\"", 2537, 2);
            WriteAttributeValue("", 2520, "/Product/", 2520, 9, true);
#nullable restore
#line 61 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
WriteAttributeValue("", 2529, item.Id, 2529, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Place A Bid</a></p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 64 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row d-flex justify-content-center mt-5\">\r\n            <div class=\"view-all col-4\"><a");
            BeginWriteAttribute("href", " href=\'", 2739, "\'", 2777, 1);
#nullable restore
#line 67 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Home\Index.cshtml"
WriteAttributeValue("", 2746, Url.Action("Index", "Product"), 2746, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View All</a></div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
