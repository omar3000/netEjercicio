#pragma checksum "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac26a6bae2733b6310f50e64657aeba19757b596"
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\_ViewImports.cshtml"
using NetEjercicio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\_ViewImports.cshtml"
using NetEjercicio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac26a6bae2733b6310f50e64657aeba19757b596", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521ecfa54ce6673cb243742608474ead3b2110ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bienvenidos</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"p-2\">\r\n\r\n            ");
#nullable restore
#line 13 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\Home\Index.cshtml"
       Write(Html.TextBox("UserId", "", new { @class = "form-control", @placeholder = "busqueda por Id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <button type=""button"" id=""btnBuscar"" class=""btn btn-block btn-info""> buscar </button>
        </div>
        <div class=""p-2"" id=""busqueda"">

        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""p-2"">
            <button type=""button"" id=""btnMostrar"" class=""btn btn-block btn-info"">Actualizar Lista</button>
        </div>
        <div class=""EstiloBAMSA"" id=""lista"">
            <div id=""loader"" class=""d-flex align-items-center"" style=""display:none!important"">
                <strong>Cargando...</strong>
                <div class=""spinner-border ms-auto"" role=""status"" aria-hidden=""true""></div>
            </div>
        </div>
    </div>
    <div class=""col-md-12"">
        ");
#nullable restore
#line 32 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\Home\Index.cshtml"
   Write(Html.TextBox("frmUserId", "", new { @class = "form-control", @placeholder = "Id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\Lenovo\Documents\GitHub\NetEjercicio\NetCoreAjax\Views\Home\Index.cshtml"
   Write(Html.TextBox("frmUserName", "", new { @class = "form-control", @placeholder = "Nombre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" id=\"userAdd\" class=\"btn btn-block btn-info\">Agregar elemento</button>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
