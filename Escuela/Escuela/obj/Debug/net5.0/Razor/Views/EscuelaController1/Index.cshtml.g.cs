#pragma checksum "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f2c887cf50d99bd2cae90752449274f34e6d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EscuelaController1_Index), @"mvc.1.0.view", @"/Views/EscuelaController1/Index.cshtml")]
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
#line 1 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f2c887cf50d99bd2cae90752449274f34e6d84", @"/Views/EscuelaController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_EscuelaController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script src=\"https://kit.fontawesome.com/8da59f9c4f.js\" crossorigin=\"anonymous\"></script>\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css\" />\r\n");
            WriteLiteral("<h1>Bienvenido</h1>\r\n<h2>¿Donde desea acceder?</h2>\r\n<div  class=\"animate__animated animate__backInUp\">\r\n    <br />\r\n    <i class=\"fa fa-user-circle\"></i>\r\n    ");
#nullable restore
#line 12 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
Write(Html.ActionLink("Ver Estudiantes", "TablaEstudiantes","Estudiantes", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <i class=\"fa fa-book-reader\"></i>\r\n    ");
#nullable restore
#line 16 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
Write(Html.ActionLink("Registrar Nuevos Estudiantes", "RegistroEstudiantes","Estudiantes", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <i class=\"fa fa-align-justify\"></i>\r\n    ");
#nullable restore
#line 20 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
Write(Html.ActionLink("Ver Cursos","VerCursos", "Cursos", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <i class=\"fa fa-book\"></i>\r\n    ");
#nullable restore
#line 24 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
Write(Html.ActionLink("Registrar Nuevos Cursos", "RegistrarCursos","Cursos", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <i class=\"fa fa-address-book\"></i>\r\n    ");
#nullable restore
#line 28 "E:\UNIVERSIDAD\Ciclo 04\Programacion 2\Clases_PrograII_2021\Escuela\Escuela\Views\EscuelaController1\Index.cshtml"
Write(Html.ActionLink("Registrar Estudiantes en un curso", "Inscripcion","Inscripcion", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\n");
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
