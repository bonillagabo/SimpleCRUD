#pragma checksum "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ccfb01c3fbf3b9506e9a31619ec2e72a66d78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NuevoCliente), @"mvc.1.0.view", @"/Views/Home/NuevoCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ccfb01c3fbf3b9506e9a31619ec2e72a66d78a", @"/Views/Home/NuevoCliente.cshtml")]
    public class Views_Home_NuevoCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleCRUD.Models.NuevoClienteVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
Write(Html.ActionLink("Volver al Menu Principal", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"text-align:center\">\r\n\r\n    <h1>Nuevo Cliente</h1>\r\n    <br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
     using (Html.BeginForm("Agregar", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table border=\"0\" style=\"margin: 0 auto;\">        \r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.ValidationMessageFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>      \r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.ValidationMessageFor(m => m.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>      \r\n            </tr>        \r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.ValidationMessageFor(m => m.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>      \r\n            </tr>      \r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.ValidationMessageFor(m => m.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>      \r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Domicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Domicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>    \r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>: </span>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
               Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>    \r\n            </tr>           \r\n        </table>\r\n        <br />\r\n        <input value=\"Agregar\"\r\n               type=\"submit\" />\r\n");
#nullable restore
#line 77 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\NuevoCliente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleCRUD.Models.NuevoClienteVM> Html { get; private set; }
    }
}
#pragma warning restore 1591