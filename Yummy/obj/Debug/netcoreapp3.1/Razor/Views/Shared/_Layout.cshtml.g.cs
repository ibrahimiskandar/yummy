#pragma checksum "C:\Users\ibrahimiskandar\source\repos\Yummy\Yummy\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4a4342b73e25b2deec63614df0a78c57216d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\ibrahimiskandar\source\repos\Yummy\Yummy\Views\_ViewImports.cshtml"
using Yummy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrahimiskandar\source\repos\Yummy\Yummy\Views\_ViewImports.cshtml"
using Yummy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4a4342b73e25b2deec63614df0a78c57216d76", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a82cf5cb21e746c28c7c6be02617b0a090178ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4a4342b73e25b2deec63614df0a78c57216d764728", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"" />
    <link href=""https://fonts.googleapis.com/css2?family=Inter:wght@700&family=Prata&family=Rubik:wght@300&display=swap""
          rel=""stylesheet"" />
    <link href=""https://fonts.googleapis.com/css2?family=Amatic+SC:wght@700&family=Inter:wght@700&family=Prata&family=Rubik:wght@300&display=swap""
          rel=""stylesheet"" />
    <link rel=""stylesheet""
          href=""https://techsolutionshere.com/wp-content/themes/techsolution/assets/blog-post-css-js/meanmenu.css"" />
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor""
          crossorigin=""anonymous"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed4a4342b73e25b2deec63614df0a78c57216d765929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>\r\n        ");
#nullable restore
#line 20 "C:\Users\ibrahimiskandar\source\repos\Yummy\Yummy\Views\Shared\_Layout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4a4342b73e25b2deec63614df0a78c57216d768082", async() => {
                WriteLiteral(@"
    <header>
        <!-- Start Navbar Area -->
        <div class=""navbar-area fixed-top"">
            <!-- Menu For Mobile Device -->
            <div class=""mobile-nav"">
                <a href=""#"" class=""logo""> Logo </a>
            </div>

            <!-- Menu For Desktop Device -->
            <div class=""main-nav"">
                <div class=""container"">
                    <nav class=""navbar navbar-expand-md navbar-light"">
                        <div class=""collapse navbar-collapse mean-menu justify-content-between""
                             id=""navbarSupportedContent"">
                            <a class=""navbar-brand"" href=""#""> Yummy<span>.</span> </a>
                            <ul class=""navbar-nav ml-auto"">
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link dropdown-toggle active"">Home</a>
                                    <ul class=""dropdown-menu"">
                                        <li class=""n");
                WriteLiteral(@"av-item"">
                                            <a href=""#"" class=""nav-link"">Home Page 2</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Home Page 3</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Home Page 4</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Home Page 5</a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link"">About</a>
                                </li>
                        ");
                WriteLiteral(@"        <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link"">Services</a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link"">Team</a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link"">Testimonials</a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link"">Contact</a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" class=""nav-link dropdown-toggle"">Pages</a>
                                    <ul class=""dropdown-menu"">
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">About</a>");
                WriteLiteral(@"
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Services</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Team</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Testimonials</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link"">Contact</a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""#"" clas");
                WriteLiteral(@"s=""nav-link dropdown-toggle"">Dropdown</a>
                                    <ul class=""dropdown-menu"">
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link dropdown-toggle"">Submenu 1</a>
                                            <ul class=""dropdown-menu"">
                                                <li class=""nav-item"">
                                                    <a href=""#"" class=""nav-link"">Item 1</a>
                                                </li>
                                                <li class=""nav-item"">
                                                    <a href=""#"" class=""nav-link"">Item 2</a>
                                                </li>
                                            </ul>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#"" class=""nav-link dropdow");
                WriteLiteral(@"n-toggle"">Submenu 2</a>
                                            <ul class=""dropdown-menu"">
                                                <li class=""nav-item"">
                                                    <a href=""#"" class=""nav-link"">Item 1</a>
                                                </li>
                                                <li class=""nav-item"">
                                                    <a href=""#"" class=""nav-link"">Item 2</a>
                                                </li>
                                                <li class=""nav-item"">
                                                    <a href=""#"" class=""nav-link dropdown-toggle"">Submenu 3</a>
                                                    <ul class=""dropdown-menu"">
                                                        <li class=""nav-item"">
                                                            <a href=""#"" class=""nav-link"">Item 1</a>
                                              ");
                WriteLiteral(@"          </li>
                                                        <li class=""nav-item"">
                                                            <a href=""#"" class=""nav-link"">Item 2</a>
                                                        </li>
                                                        <li class=""nav-item"">
                                                            <a href=""#"" class=""nav-link"">Item 3</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                            <a class=""btn btn-danger""");
                BeginWriteAttribute("href", " href=\"", 8112, "\"", 8119, 0);
                EndWriteAttribute();
                WriteLiteral(">Book a Table</a>\r\n                        </div>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- End Navbar Area -->\r\n    </header>\r\n    ");
#nullable restore
#line 143 "C:\Users\ibrahimiskandar\source\repos\Yummy\Yummy\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n     <footer>\r\n      <!DOCTYPE html>\r\n      <html lang=\"en\" dir=\"ltr\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4a4342b73e25b2deec63614df0a78c57216d7616453", async() => {
                    WriteLiteral(@"
          <meta charset=""UTF-8"" />
          <link rel=""stylesheet"" href=""style.css"" />
          <meta
            name=""viewport""
            content=""width=device-width, initial-scale=1.0""
          />
          <link
            rel=""stylesheet""
            href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css""
          />
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4a4342b73e25b2deec63614df0a78c57216d7617872", async() => {
                    WriteLiteral(@"
          <footer>
            <div class=""article"">
              <div class=""left box"">
                <div class=""upper"">
                  <div class=""topic"">About us</div>
                  <p>
                    ""PakaInfo was founded in January 2018 with the aim of
                    sharing a place for General Information languages articles.
                  </p>
                </div>
                <div class=""lower"">
                  <div class=""topic"">Contact us</div>
                  <div class=""phone"">
                    <a href=""#""
                      ><i class=""fas fa-phone-volume""></i>+007 9898 015*</a
                    >
                  </div>
                  <div class=""email"">
                    <a href=""#""
                      ><i class=""fas fa-envelope""></i
                      >yourgmaailname@gmail.com</a
                    >
                  </div>
                </div>
              </div>
              <div class=""middle box"">
        ");
                    WriteLiteral(@"          <div class=""topic"">Our Services</div>
                  <div><a href=""#"">Software source aPI, Development</a></div>
                  <div><a href=""#"">Software dev Source code, Reasearch</a></div>
                  <div><a href=""#"">Software User Interface Source code</a></div>
                  <div><a href=""#"">Laravel Development, Source code</a></div>
                  <div><a href=""#"">Mobile Application Source code</a></div>
                  <div><a href=""#"">Blogging & Earning</a></div>
              </div>
              <div class=""right box"">
                <div class=""topic"">Subscribe us</div>
                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4a4342b73e25b2deec63614df0a78c57216d7619890", async() => {
                        WriteLiteral("\r\n                  <input type=\"text\" placeholder=\"Enter Your email address\" />\r\n                  <input type=\"submit\"");
                        BeginWriteAttribute("name", " name=\"", 10619, "\"", 10626, 0);
                        EndWriteAttribute();
                        WriteLiteral(@" value=""Send"" />
                  <div class=""media-icons"">
                    <a href=""#""><i class=""fab fa-facebook-f""></i></a>
                    <a href=""#""><i class=""fab fa-instagram""></i></a>
                    <a href=""#""><i class=""fab fa-twitter""></i></a>
                    <a href=""#""><i class=""fab fa-youtube""></i></a>
                    <a href=""#""><i class=""fab fa-linkedin-in""></i></a>
                  </div>
                ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n              </div>\r\n            </div>\r\n            <div class=\"bottom\">\r\n              <p>\r\n                Copyright © 2022 <a href=\"#\">Pakainfo</a> All rights reserved\r\n              </p>\r\n            </div>\r\n          </footer>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      </html>
    </footer>
    <!-- JavaScript Bundle with Popper -->
    <!-- JQuery Min JS -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <!-- MeanMenu JS -->
    <script src=""https://techsolutionshere.com/wp-content/themes/techsolution/assets/blog-post-css-js/jquery.meanmenu.js""></script>
    <script>
      // Mean Menu
      jQuery("".mean-menu"").meanmenu({
        meanScreenWidth: ""991"",
      });
    </script>
    <script
      src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
      integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
      crossorigin=""anonymous""
    ></script>
    <script src=""/assets/js/main.js""></script>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
