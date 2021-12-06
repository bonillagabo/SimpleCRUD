#pragma checksum "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67227d42d3745b0680c6e95328eee95f3d48022d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67227d42d3745b0680c6e95328eee95f3d48022d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleCRUD.Models.IndexVM>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67227d42d3745b0680c6e95328eee95f3d48022d2561", async() => {
                WriteLiteral("\r\n\r\n    <div style=\"text-align:center\">\r\n\r\n        <h1>Simple CRUD</h1>\r\n        <br />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
       Write(Html.LabelFor(m=>m.Buscar));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>: </span>\r\n");
#nullable restore
#line 14 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
       Write(Html.EditorFor(m=>m.Buscar));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input name=\"BuscarBtn\"\r\n                   type=\"submit\"\r\n                   value=\"Buscar\" />\r\n");
                WriteLiteral("            <br /><br />\r\n");
                WriteLiteral("            <input name=\"AgregarBtn\"\r\n                   type=\"submit\"\r\n                   value=\"Agregar Nuevo Cliente\" />\r\n            <br /><br />\r\n");
#nullable restore
#line 26 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
         if (Model.clientes.Count == 0)
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span style=\"color:red\">No existen Clientes Actualmente</span>\r\n");
#nullable restore
#line 31 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
         }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table border=""1"" style=""margin: 0 auto;"">
                <tr>
                    <th>Nro Socio</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Dni</th>
                    <th>Celular</th>
                    <th>Domicilio</th>
                    <th>Email</th>
                </tr>
");
#nullable restore
#line 44 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                 foreach (var cliente in Model.clientes)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.NroSocio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Apellido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Dni);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Celular);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Domicilio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(cliente.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Modificar", "Modificar", new { NroSocio = cliente.NroSocio }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Eliminar", "Eliminar", new { NroSocio = cliente.NroSocio }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 59 "C:\Users\Gabriel\Desktop\SimpleCRUD\SimpleCRUD\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    \r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleCRUD.Models.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
