#pragma checksum "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbd2547809145c57f958971cd91da6d22996f3d"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Pages.AdminPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using FinalAmadis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Clientes")]
    public partial class Clientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.AddAttribute(5, "style", "background-color: #fff");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col d-inline");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<div class=\"col-8\">\r\n                        <h3 class=\"d-inline\">Cumpleaños por mes</h3>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-4");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "id", "Drop");
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                                     HandleSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "00");
            __builder.AddAttribute(27, "disabled", true);
            __builder.AddContent(28, "Seleccione");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "01");
            __builder.AddContent(32, "Enero");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "02");
            __builder.AddContent(36, "Febrero");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "03");
            __builder.AddContent(40, "Marzo");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "04");
            __builder.AddContent(44, "Abril");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "05");
            __builder.AddContent(48, "Mayo");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "06");
            __builder.AddContent(52, "Junio");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "07");
            __builder.AddContent(56, "Julio");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "08");
            __builder.AddContent(60, "Agosto");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "09");
            __builder.AddContent(64, "Septiembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "10");
            __builder.AddContent(68, "Octubre");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "11");
            __builder.AddContent(72, "Noviembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "12");
            __builder.AddContent(76, "Diciembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col d-inline");
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "title", "Exportar");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                                   ExportarCSV

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "class", "btn btn-primary mr-2 d-inline float-right");
            __builder.AddMarkupContent(89, "<i class=\"fas fa-download\"></i> Exportar");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "title", "Recargar");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                                   Reload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "class", "btn btn-primary mr-2 d-inline float-right");
            __builder.AddMarkupContent(95, "<i class=\"fas fa-sync-alt\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "card-body");
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.OpenElement(103, "table");
            __builder.AddAttribute(104, "class", "table table-dark table-borderless");
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.AddMarkupContent(106, "<thead>\r\n                <tr>\r\n                    <th>Nombre</th>\r\n                    <th>Fecha de nacimiento</th>\r\n                    <th>Correo</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(107, "tbody");
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 54 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                 if (Datos != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                     foreach (var prov in Datos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "                        ");
            __builder.OpenElement(110, "tr");
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 59 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                 prov.Nombre_Usuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 60 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                 prov.Fecha_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                            ");
            __builder.OpenElement(118, "td");
            __builder.AddContent(119, 
#nullable restore
#line 61 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                                 prov.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 63 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 67 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
         if (alerta)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "            ");
            __builder.AddMarkupContent(126, "<div class=\"alert alert-danger text-center\" role=\"alert\">\r\n                No se encontraron registros...\r\n            </div>\r\n");
#nullable restore
#line 72 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
         if (Datos == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "            ");
            __builder.AddMarkupContent(128, "<div class=\"d-flex justify-content-center\">\r\n                <div class=\"spinner-border\" role=\"status\">\r\n                    <span class=\"visually-hidden\"></span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 80 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Clientes.razor"
       
    List<DatosUsuarios> personas = new List<DatosUsuarios>();
    public dynamic Datos { get; set; }
    string mes = "00";
    bool alerta = false;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Usuarios");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected async Task Reload()
    {
        try
        {
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Mostrar_Usuarios");
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
            alerta = false;
        }
        catch (Exception)
        {
            throw;
        }
    }
    private async Task HandleSubmit(ChangeEventArgs e)
    {
        try
        {
            alerta = false;
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Sacar_Cumpleaños/" + e.Value.ToString());
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            Datos = JsonConvert.DeserializeObject(data);
            if (Datos.ok == false)
            {
                await Reload();
                alerta = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private async Task ExportarCSV()
    {
        personas.Clear();
        foreach (var i in Datos)
        {
            personas.Add(new DatosUsuarios() { IdUsuario = i.IdUsuario, Nombre = i.Nombre_Usuario, Apellido = i.Apellido_Usuario, Fecha_Nacimiento = i.Fecha_Nacimiento, Correo = i.Correo });
        }

        using (var memoryStream = new MemoryStream())
        {
            using (var writer = new StreamWriter(memoryStream))
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(personas);
                }

                var arr = memoryStream.ToArray();
                await JSRuntime.InvokeAsync<object>("saveAsFile",
                "personas.csv",
                Convert.ToBase64String(arr));
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
    }
}
#pragma warning restore 1591
