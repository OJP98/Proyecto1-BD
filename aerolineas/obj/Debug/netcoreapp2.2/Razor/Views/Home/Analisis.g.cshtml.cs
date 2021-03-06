#pragma checksum "C:\Users\Usuario\Documents\VS Projects\Proyecto1-BD\aerolineas\Views\Home\Analisis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f47301632f3eaeb88e961b4f3ea14ce0932063b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Analisis), @"mvc.1.0.view", @"/Views/Home/Analisis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Analisis.cshtml", typeof(AspNetCore.Views_Home_Analisis))]
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
#line 1 "C:\Users\Usuario\Documents\VS Projects\Proyecto1-BD\aerolineas\Views\_ViewImports.cshtml"
using aerolineas;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Documents\VS Projects\Proyecto1-BD\aerolineas\Views\_ViewImports.cshtml"
using aerolineas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f47301632f3eaeb88e961b4f3ea14ce0932063b", @"/Views/Home/Analisis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec430c8b95dc6af6a6b8ff50be57899e9795c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Analisis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Usuario\Documents\VS Projects\Proyecto1-BD\aerolineas\Views\Home\Analisis.cshtml"
  
    ViewData["Title"] = "Análisis";

#line default
#line hidden
            BeginContext(44, 17973, true);
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

body{
  padding: 0px 0px;
  margin: 0;
}

header{
  padding: 0px 0px;
  margin: 0;
}

/* Se agrega el efecto parallax */
.parallax {

    background-image: url(""../images/analisis.jpg"");
    height: 570px;
    width: 100%;
    background-attachment: fixed;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    text-align: center;
}

.column {
  float: left;
  width: 50%;
}

/* Clear floats after the columns */
.row:after {
  content: """";
  display: table;
  clear: both;
}

code {
  color: rgb(49,49,49);
  font-family: Consolas,monospace,Menlo,Monaco,Lucida Console,Liberation Mono,DejaVu Sans Mono,Bitstream Vera Sans Mono,Couri");
            WriteLiteral(@"er New,monospace,sans-serif;
  background-color: rgba(245, 245, 245, 0.5);
  margin-right: 35px;
  padding-left: 3px;
  border: 1px solid;
  box-shadow: 2px 2px 5px grey;
}

</style>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<!-- Imagen  parallax con título en el centro -->
<br><hr><br>
<div class=""parallax"">

  <br><br>
  <h1>Análisis de los Datos</h1>

</div>


<!-- Línea de división con el resto de la página -->
<br>
<hr>
<br>

<!-- Comienzo de las mecánicas principales -->
<div style=""text-align: center"">
  <h1>Mecánicas principales del análisis</h1>
  <p style=""text-align: justify"">
    La idea principal del análisis está basasda en consultar características importantes que hace de una aerolínea, eficiente.
    En principio, una buena aerolínea consiste de una variedad de destinos, puntualidad tanto en despegues como en aterrizajes, actividad que ha tenido, entre otros aspectos.
    Es por ello, que planteamos 10 preguntas l");
            WriteLiteral(@"as cuales consideramos que toda buena aerolínea debe cumplir. Aquellas que mejor cumplan con los requisitos planteados, se le sumarán más puntos que el resto para así considerar una gama más alta de aerolíneas a tomar en cuenta.
    Finalmente, se sumó la cantidad de puntos que tuvieron las aerolíneas y, junto con un amplio análisis, se llegó a las top 3 aerolíneas más fiables para invertir.
  </p>
</div>

<br>

<h2 style=""text-align: center"">10  preguntas para determinar las mejores aerolíneas</h2>

<br>

<!-- PRIMER QUERY -->
<div style=text-align:center>
  <h3>1. ¿Qué tan a menudo se retrasan los vuelos en comparación a la cantidad de estos por aerolína?</h3>
  <p style=""text-align: justify"">
    Esta pregunta la seleccionamos debido a que nos interesa saber con que frecuencia se 
    retrasan las aerolíneas. Esto es importante ya que si pasa con mucha frecuencia los 
    clientes se disgustarán. Así mismo, nos interesa comparar esta frecuencia contra 
    la cantidad de vuelos que esta a");
            WriteLiteral(@"erolínea genera. La mejor aerolínea la tomaremos 
    como la que tenga más vuelos y menor frecuencia de retraso. </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT o.Reporting_Airline, <br />
        &nbsp &nbsp (((SELECT COUNT(*) <br />
        &nbsp &nbsp FROM ontime o1 <br />
        &nbsp &nbsp WHERE o1.DepDelayMinutes != 0 <br />
        &nbsp &nbsp &nbsp AND o1.Month >= 9 <br />
        &nbsp &nbsp &nbsp AND o1.Year = 2018 <br />
        &nbsp &nbsp &nbsp AND o.Reporting_Airline = o1.Reporting_Airline) / 3.0) / <br />
        &nbsp &nbsp ((SELECT COUNT(*) <br />
        &nbsp &nbsp FROM ontime o2 <br />
        &nbsp &nbsp WHERE o2.Month >= 9 and o2.Year = 2018 <br />
        &nbsp &nbsp &nbsp AND o.Reporting_Airline = o2.Reporting_Airline) / 3.0)) * <br />
              100 AS ""FRECUENCIA"" <br />
        FROM ontime o <br />
        GROUP BY o.Reporting_Ai");
            WriteLiteral(@"rline <br />
        ORDER BY FRECUENCIA ASC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart1""></div>
  </div>
</div>

<br><br>

<!-- SEGUNDO QUERY -->
<div style=text-align:center>
  <h3>2. ¿Qué proporción de vuelos se cancelan debido al código A (Carrier)?</h3>
  <p style=""text-align:justify"">
    En el día a día, una gran cantidad de vuelos son cancelados.
    De hecho, las razones por las que se cancela un vuelo son: Debido al clima, seguridad, tráfico aéreo y por culpa de la misma aerolínea.
    En este query, se consideró esta última razón como la más importante. Lo que en realidad nos interesa saber es la proporción de vuelos
    que se cancelan por culpa de la propia aerolínea.
    </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT c.Description as AEROLINEA,CAST (");
            WriteLiteral(@"count (*) AS float) / ( <br />
        &nbsp SELECT count(*) <br />
        &nbsp FROM ontime o1 <br />
        &nbsp WHERE o1.Cancelled = 0 <br />
        &nbsp &nbsp AND o1.Reporting_Airline = o.Reporting_Airline <br />
        &nbsp ) * 100 AS PROPORCION <br />
        FROM ontime o <br />
        INNER JOIN carrier_history c ON o.Reporting_Airline = c.Code <br />
        WHERE Cancelled = 1 <br />
        &nbsp AND CancellationCode = 'A' <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY PROPORCION ASC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart2"" style=""width: 700x; height: 300px;""></div>
  </div>
</div>
<br><br>
<div id=""chart2A""></div>

<br><br>

<!-- TERCER QUERY -->
<div style=text-align:center>
  <h3>3. ¿Cuál es el promedio de vuelos mensuales que realizan las aerolíneas?</h3>
  <p style=""text-align:justify"">Elegimos esta pregunta ya que nos interesa saber que aerolí");
            WriteLiteral(@"nea esta 
    generando más vuelos al mes. Esto significa que genera más entradas de dinero al mes. </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT o.Reporting_Airline, <br />
        &nbsp ((SELECT COUNT(*)  <br />
        &nbsp FROM ontime o1  <br />
        &nbsp WHERE o1.Year = 2018  <br />
        &nbsp &nbsp AND o.Reporting_Airline = o1.Reporting_Airline <br />
        &nbsp ) / 11) as ""PROMEDIO"" <br />
        FROM ontime o <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY PROMEDIO DESC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart3""></div>
  </div>
</div>

<br><br>

<!-- CUARTO QUERY -->
<div style=text-align:center>
  <h3>4. ¿Qué aerolíneas tienen la mayor cantidad de destinos?</h3>
  <p style=""text-align:justify"">
    Cuando deseamos vi");
            WriteLiteral(@"ajar a sitios no tan populares, es importante saber qué aerolíneas nos pueden llevar
    a dichos lugares. Por ello, esta consulta nos hará saber que aerolíneas serán capaces de llegar a lugares que 
    otras no.
  </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT c.Description, count(DISTINCT o.DestCityName) as TOTAL <br />
        FROM ontime o <br />
        INNER JOIN carrier_history c ON o.Reporting_Airline = c.Code <br />
        GROUP BY c.Code <br />
        ORDER BY TOTAL DESC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart4""></div>
  </div>
</div>

<br><br>

<!--  QUINTO QUERY -->
<div style=text-align:center>
  <h3>5. ¿Qué tan puntuales son los vuelos de las aerolíneas en comparación a la cantidad de viajes?</h3>
  <p style=""text-align:justify"">
    Se tomó ");
            WriteLiteral(@"en cuenta el retraso tanto en llegada como en salida promedio de cada 
    día en comparación a la cantidad de vuelos promedio por día. Lo que nos interesa 
    saber es que tan puntuales son las aerolíneas, puesto que lo ideal es que respeten 
    los horarios o tengan el menor retraso. La mejor aerolínea consideramos que es la que 
    tenga mayor cantidad de vuelos y menor retraso.  </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT o.Reporting_Airline, <br />
        &nbsp ( <br />
        &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp SELECT SUM(o1.DepDelayMinutes) <br />
        &nbsp &nbsp &nbsp FROM ontime o1 <br />
        &nbsp &nbsp &nbsp WHERE o.Reporting_Airline = o1.Reporting_Airline <br />
        &nbsp &nbsp &nbsp &nbsp AND o1.Year = 2018 <br />
        &nbsp &nbsp &nbsp GROUP BY o1.Month, o1.DayofMonth <br />
    ");
            WriteLiteral(@"    &nbsp &nbsp &nbsp ) + <br />
        &nbsp &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp SELECT SUM(o2.ArrDelayMinutes) <br />
        &nbsp &nbsp &nbsp FROM ontime o2 <br />
        &nbsp &nbsp &nbsp WHERE o.Reporting_Airline = o2.Reporting_Airline <br />
        &nbsp &nbsp &nbsp &nbsp AND o2.Year = 2018 <br />
        &nbsp &nbsp &nbsp GROUP BY o2.Month, o2.DayofMonth <br />
        &nbsp &nbsp ) <br />
        &nbsp ) / 334 <br />
        ) AS ""MINUTOS_DE_RETRASO_POR_DIA"",        <br />
        &nbsp ( <br />
        &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp SELECT COUNT() <br />
        &nbsp &nbsp &nbsp FROM ontime o3 <br />
        &nbsp &nbsp &nbsp WHERE o.Reporting_Airline = o3.Reporting_Airline <br />
        &nbsp &nbsp &nbsp &nbsp AND o3.Year = 2018 <br />
        &nbsp &nbsp &nbsp GROUP BY o3.Month, o3.DayofMonth <br />
        &nbsp &nbsp ) * 1.0 / 334 <br />
        &nbsp ) AS ""CANT_VUELOS_POR_DIA"" <br />
        FROM ontime o <br />
        GROUP BY o.Reporting_Ai");
            WriteLiteral(@"rline <br />
        ORDER BY MINUTOS_DE_RETRASO_POR_DIA ASC, CANT_VUELOS_POR_DIA DESC
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart5A"" style=""width: 700x; height: 500px;""></div>
  </div>
</div>

<br><br>

<!-- SEXTO QUERY -->
<div style=text-align:center>
  <h3>6. ¿Qué tan frecuentemente un vuelo sale tarde por culpa propia de la aerolínea en comparación con la cantidad de vuelos?</h3>
  <p style=""text-align:justify"">
    Muchos vuelos son atrasados diariamente ya sea por la seguridad, el tráfico aereo, el clima o bien por culpa propia de la aerolínea. 
    Este último aspecto nos hará saber con que frecuencia la aerolínea comete errores y en efecto atrasa el vuelo. Aquellas con
    una menor proporicón, son las que operan más consistentemente.
  </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
");
            WriteLiteral(@"      <p>
        SELECT c.Description as AEROLINEA,CAST (count (*) AS float) / ( <br />
        &nbsp SELECT count(*) <br />
        &nbsp FROM ontime o1 <br />
        &nbsp WHERE o1.Cancelled = 0  <br />
        &nbsp &nbsp AND o1.Reporting_Airline = o.Reporting_Airline <br />
        &nbsp ) * 100 AS PROPORCION <br />
        FROM ontime o <br />
        INNER JOIN carrier_history c ON o.Reporting_Airline = c.Code <br />
        WHERE o.CarrierDelay > 0 AND o.DepDelay > 0  <br />
        &nbsp AND o.Cancelled = 0 <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY PROPORCION ASC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart6"" style=""width: 700x; height: 350px;""></div>
  </div>
</div>

<br><br>

<!-- SEPTIMO QUERY -->
<div style=text-align:center>
  <h3>7. ¿Qué aerolíneas han tenido un aumento en la realización de sus vuelos a lo largo del 2018?</h3>
  <p style=""text-align:just");
            WriteLiteral(@"ify"">
    Esta pregunta consiste en determinar que aerolíneas han crecido a 
    lo largo del 2018, puesto que uno esperaría que conforme avance el 
    tiempo la aerolínea prospere y tenga más vuelos. La mejor aerolínea 
    consideramos que es la que tiene mayor porcentaje de aumento y que sea un porcentaje positivo. 
    </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT o.Reporting_Airline, <br />
        ( <br />
        &nbsp ( <br />
        &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp SELECT COUNT(*) <br />
        &nbsp &nbsp &nbsp FROM ontime o1 <br />
        &nbsp &nbsp &nbsp WHERE o1.Month = 11 and o1.Year = 2018  <br />
        &nbsp &nbsp &nbsp &nbsp AND o.Reporting_Airline = o1.Reporting_Airline <br />
        &nbsp &nbsp ) - <br />
        &nbsp &nbsp ( <br />
        &nbsp &nbsp &nbsp SELECT COUNT(*) <br />
        &nbsp &nbsp &nbsp FROM onti");
            WriteLiteral(@"me o2 <br />
        &nbsp &nbsp &nbsp WHERE o2.Month = 1 and o2.Year = 2018  <br />
        &nbsp &nbsp &nbsp &nbsp AND o.Reporting_Airline = o2.Reporting_Airline <br />
        &nbsp &nbsp ) <br />
        &nbsp ) * 1.0 / <br />
        &nbsp ( <br />
        &nbsp &nbsp SELECT COUNT(*) <br />
        &nbsp &nbsp FROM ontime o3 <br />
        &nbsp &nbsp WHERE o.Reporting_Airline = o3.Reporting_Airline <br />
        &nbsp &nbsp &nbsp AND o3.Year = 2018 <br />
        &nbsp &nbsp GROUP BY o3.Month <br />
        &nbsp &nbsp ORDER BY COUNT(*) DESC <br />
        &nbsp &nbsp LIMIT 1 <br />
        &nbsp ) <br />
        ) * 100 AS ""PROPORCION_DE_AUMENTO"" <br />
        FROM ontime o <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY PROPORCION_DE_AUMENTO DESC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart7"" style=""width: 700x; height: 500px;""></div>
  </div>
</div>

<br><br>

<!");
            WriteLiteral(@"-- OCTAVO QUERY -->
<div style=text-align:center>
  <h3>8. ¿Qué aerolíneas recorren distancias más grandes?</h3>
  <p style=""text-align:justify"">
    Es un hecho que es más económico hacer escalas para llegar a un destino final, que viajar directamente a él.
    Pero también sabemos, que es muy tedioso y tardado bajarse en cada aeropuerto solo para entrar a otro avión.
    Este query tiene como finalidad saber qué aerolíneas viajan distancias más grandes y conocer cuales están dispuestas
    a ahorrarnos múltiples paradas en múltiples aeropuertos.
  </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT ch.Description as AEROLINEA, MAX(o.Distance) as DIST <br />
        FROM carrier_history ch <br />
        INNER JOIN ontime o ON ch.Code = o.Reporting_Airline <br />
        GROUP BY ch.Code <br />
        ORDER BY DIST DESC;
      </p>
    </code>
  </div>
  <div c");
            WriteLiteral(@"lass=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart8""></div>
  </div>
</div>

<br><br>

<!-- NOVENO QUERY -->
<div style=text-align:center>
  <h3>9. ¿Qué aerolíneas tienen más vuelos en un día durante el 2018?</h3>
  <p style=""text-align:justify"">
    La finalidad de esta pregunta es saber que aerolínea tiene mayor 
    productividad durante el día.  La mejor aerolínea consideramos que 
    es la que tenga mayor cantidad de vuelos durante un día. </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p>
        SELECT o.Reporting_Airline, <br />
        ( <br />
        &nbsp ( <br />
        &nbsp &nbsp SELECT COUNT() <br />
        &nbsp &nbsp FROM ontime o3 <br />
        &nbsp &nbsp WHERE o.Reporting_Airline = o3.Reporting_Airline <br />
        &nbsp &nbsp &nbsp AND o3.Year = 2018 <br />
        &nbsp &nbsp GROUP BY o3.Month, o3.Dayo");
            WriteLiteral(@"fMonth <br />
        &nbsp ) * 1.0 / 334 <br />
        ) AS ""CANT_VUELOS_POR_DIA"" <br />
        FROM ontime o <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY CANT_VUELOS_POR_DIA DESC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart9""></div>
  </div>
</div>

<br><br>

<!-- DECIMO QUERY -->
<div style=text-align:center>
  <h3>10. ¿Qué tan activa ha sido una aerolínea en los últimos tres meses?</h3>
  <p>Para hacer uso de nuestro conocimiento financiero, es importante evaluar el desempeño actual de cada empresa.
    Por ello, un análisis de los últimos tres meses nos harán saber si la aerolínea tiene tendencia a hacer vuelos
    constantemente o no; está será una buena forma de decidir si invertir en una aerlínea.
  </p>
</div>

<br>
<div class=""row"">
  <div class=""column"">
    <p style=text-align:center>Resolución del query: </p>
    <code style=""display: block"">
      <p st");
            WriteLiteral(@"yle=""text-align:justify"">
        SELECT ch.Description as AEROLINEA, CAST (count(*)/3 as float) as PROM_3M <br />
        FROM carrier_history ch <br />
        INNER JOIN ontime o ON ch.Code = o.Reporting_Airline <br />
        WHERE o.Year = 2018 AND o.Month >= 9 <br />
        GROUP BY o.Reporting_Airline <br />
        ORDER BY PROM_3M DESC;
      </p>
    </code>
  </div>
  <div class=""column"">
    <p style=text-align:center>Gráfica representativa:</p>
    <div id=""chart10""></div>
  </div>
</div>

<br><br><br><br><br><br><br><br><br><br>");
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
