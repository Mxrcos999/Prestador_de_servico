#pragma checksum "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317d21b03cf6c4eba0cc8e6618568564cae1e461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestadors_Index), @"mvc.1.0.view", @"/Views/Prestadors/Index.cshtml")]
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
#line 1 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\_ViewImports.cshtml"
using PrestadorDeServico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\_ViewImports.cshtml"
using Prestadores_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317d21b03cf6c4eba0cc8e6618568564cae1e461", @"/Views/Prestadors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97ce90d00cf0ff0bf0940e77716f503bbaac1e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestadors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prestadores_Domain.Entities.Prestador>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p class=""txtdia""> Profissionais para facilitar o seu dia a dia </p>
<br /><br /><br />
<div class=""container"">
    <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""d-block w-100"" src=""./img/encanador_ps.jpg"" alt=""First slide"">
            </div>
            <div class=""carousel-item"">
                <img class=""d-block w-100"" src=""./img/eletricista_ps.jpg"" alt=""Second slide"">
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only");
            WriteLiteral("\">Next</span>\n        </a>\n    </div>\n</div>\n<br /><br /><br />\n<table class=\"table\">\n    <h1>Prestadores para o serviço</h1>\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 40 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n");
            WriteLiteral("            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 52 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 56 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 59 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 62 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n         \n            </tr>\n");
#nullable restore
#line 66 "C:\Users\MarcosFelipeSilvaCel\OneDrive - Time Share Soluções\Área de Trabalho\Prestador_de_servico-main\PrestadorDeServico\Views\Prestadors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<br /><br /><br />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prestadores_Domain.Entities.Prestador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
