#pragma checksum "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "accfdd95e14f3cd43dac928b8e50b4f8f3c4f5d0"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Pages
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
#line 2 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tienda/Pedidos")]
    public partial class Pedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    p {\r\n        color: black;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-content page-container");
            __builder.AddAttribute(3, "id", "page-content");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 15 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
     if (Datos != null && Datos.ok == true)
    {
        foreach (var i in Datos.data)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "padding d-flex justify-content-center");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row container d-flex justify-content-center");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card user-card-full");
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row m-l-0 m-r-0");
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.AddMarkupContent(21, @"<div class=""col-sm-4 bg-c-lite-green user-profile"">
                                    <div class=""card-block text-center text-white"">
                                        <div class=""m-b-25""> <img src=""/img/Freeshipping-amico.svg"" style=""width: 50%;"" class=""img-radius"" alt=""User-Profile-Image""> </div>
                                        <h6 class=""f-w-600""></h6>
                                        <h5 style=""font-size: 2em"">Pedido</h5> <i class="" mdi mdi-square-edit-outline feather icon-edit m-t-10 f-16""></i>
                                    </div>
                                </div>
                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-8");
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-block");
            __builder.AddMarkupContent(27, "\r\n                                        ");
            __builder.AddMarkupContent(28, "<h6 class=\"m-b-20 p-b-5 b-b-default f-w-600\">Información de pedido</h6>\r\n                                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.AddMarkupContent(31, "\r\n                                            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-6");
            __builder.AddMarkupContent(34, "\r\n                                                ");
            __builder.AddMarkupContent(35, "<p class=\"m-b-10 f-w-600\">Nombre de cliente</p>\r\n                                                ");
            __builder.OpenElement(36, "h6");
            __builder.AddAttribute(37, "class", "text-muted f-w-400");
            __builder.AddContent(38, " ");
            __builder.AddContent(39, 
#nullable restore
#line 37 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                 i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " ");
            __builder.AddContent(41, 
#nullable restore
#line 37 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                           i.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-sm-6");
            __builder.AddMarkupContent(46, "\r\n                                                ");
            __builder.AddMarkupContent(47, "<p class=\"m-b-10 f-w-600\">Teléfono</p>\r\n                                                ");
            __builder.OpenElement(48, "h6");
            __builder.AddAttribute(49, "class", "text-muted f-w-400");
            __builder.AddContent(50, 
#nullable restore
#line 41 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                i.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row mt-2");
            __builder.AddMarkupContent(56, "\r\n                                            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-sm-6");
            __builder.AddMarkupContent(59, "\r\n                                                ");
            __builder.AddMarkupContent(60, "<p class=\"m-b-10 f-w-600\">Total</p>\r\n                                                ");
            __builder.OpenElement(61, "h6");
            __builder.AddAttribute(62, "class", "text-muted f-w-400");
            __builder.AddContent(63, "RD$ ");
            __builder.AddContent(64, 
#nullable restore
#line 47 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                    i.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-6");
            __builder.AddMarkupContent(69, "\r\n                                                ");
            __builder.AddMarkupContent(70, "<p class=\"m-b-10 f-w-600\">Estado</p>\r\n                                                ");
            __builder.OpenElement(71, "h6");
            __builder.AddAttribute(72, "class", "text-muted f-w-400");
            __builder.AddContent(73, 
#nullable restore
#line 51 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                i.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row mt-2");
            __builder.AddMarkupContent(79, "\r\n                                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-sm-6");
            __builder.AddMarkupContent(82, "\r\n                                                ");
            __builder.AddMarkupContent(83, "<p class=\"m-b-10 f-w-600\">Correo de contacto</p>\r\n                                                ");
            __builder.OpenElement(84, "h6");
            __builder.AddAttribute(85, "class", "text-muted f-w-400");
            __builder.AddContent(86, " ");
            __builder.AddContent(87, 
#nullable restore
#line 57 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                 i.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-6");
            __builder.AddMarkupContent(92, "\r\n                                                ");
            __builder.AddMarkupContent(93, "<p class=\"m-b-10 f-w-600\">Dirección</p>\r\n                                                ");
            __builder.OpenElement(94, "h6");
            __builder.AddAttribute(95, "class", "text-muted f-w-400");
            __builder.AddContent(96, " ");
            __builder.AddContent(97, 
#nullable restore
#line 61 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                 i.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 71 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
     if(Datos != null && Datos.ok == false){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "<div class=\"alert alert-danger text-center\" role=\"alert\">No tiene pedidos...</div>");
#nullable restore
#line 73 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
                                                                                                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
     if (Datos == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "        ");
            __builder.AddMarkupContent(110, "<div class=\"d-flex justify-content-center\">\r\n            <div class=\"spinner-border\" role=\"status\">\r\n                <span class=\"visually-hidden\"></span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 81 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(111, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\Pedidos.razor"
       
    public dynamic Datos { get; set; }
    public dynamic Salir { get; set; }
    public dynamic StorageData { get; set; }
    string IdProducto;
    Api API = new Api();
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
                StorageData = JsonConvert.DeserializeObject(storage);
                string myUrl = "https://super-mini-market.herokuapp.com/api/Seleccionar_Pedidos_Usuario/" + StorageData.IdUsuario;
                Uri url = new Uri(myUrl);
                WebClient client = new WebClient();
                var data = await client.DownloadStringTaskAsync(url);
                Datos = JsonConvert.DeserializeObject(data);
                StateHasChanged();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
