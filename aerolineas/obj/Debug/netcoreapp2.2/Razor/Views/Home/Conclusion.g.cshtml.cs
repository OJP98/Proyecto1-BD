#pragma checksum "C:\Users\wuser\Documents\UVG\3er Año\Base de Datos\Proyecto\Proyecto1-BD\aerolineas\Views\Home\Conclusion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f6909eed26880742a6587e645afa284f0fd94b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Conclusion), @"mvc.1.0.view", @"/Views/Home/Conclusion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Conclusion.cshtml", typeof(AspNetCore.Views_Home_Conclusion))]
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
#line 1 "C:\Users\wuser\Documents\UVG\3er Año\Base de Datos\Proyecto\Proyecto1-BD\aerolineas\Views\_ViewImports.cshtml"
using aerolineas;

#line default
#line hidden
#line 2 "C:\Users\wuser\Documents\UVG\3er Año\Base de Datos\Proyecto\Proyecto1-BD\aerolineas\Views\_ViewImports.cshtml"
using aerolineas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f6909eed26880742a6587e645afa284f0fd94b0", @"/Views/Home/Conclusion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec430c8b95dc6af6a6b8ff50be57899e9795c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Conclusion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\wuser\Documents\UVG\3er Año\Base de Datos\Proyecto\Proyecto1-BD\aerolineas\Views\Home\Conclusion.cshtml"
  
    ViewData["Title"] = "Conclusiones";

#line default
#line hidden
            BeginContext(48, 1589, true);
            WriteLiteral(@"
<style>

html{
    background: url(""../images/fondo.jpg"") no-repeat center center fixed;
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
    padding: 0px 0px;
    margin: 0;
}

.navbar{
  position: relative;
}

.center {
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 80%;
}

.column {
  float: left;
  width: 33.33%;
}

/* Clear floats after the columns */
.row:after {
  content: """";
  display: table;
  clear: both;
}

</style>

<br><br>
<div style=""text-align: center"">
    <h1>Conclusiones del análisis</h1>
    <br><hr><br>
    <p style=""text-align: justify"">
        Conforme el análisis hecho previamente, se sumó el total de puntos que obtuvo cada una de las aerolíneas y se designó
        las mejores 3 a un área específica. Por áreas, nos referimos a distancias recorridas, puntualidad y rendimiento.
    </p>
</div>

<br><br>

<div class=""row"">
    <div cl");
            WriteLiteral(@"ass=""column"">

        <h3 style=""text-align: center"">Puntualidad</h3>
        <br>
        <img src=""../images/puntualidad.jpg"" class=""center""/>

    </div>

    <div class=""column"">

        <h3 style=""text-align: center"">Distancias</h3>
        <br>
        <img src=""../images/distancia.jpg"" class=""center"" height=""78%""/>

    </div>

    <div class=""column"">

        <h3 style=""text-align: center"">Rendimiento</h3>
        <br>
        <img src=""../images/rendimiento.jpg"" class=""center""/>

    </div>
</div>

<br><br><br><br><br><br>");
            EndContext();
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
