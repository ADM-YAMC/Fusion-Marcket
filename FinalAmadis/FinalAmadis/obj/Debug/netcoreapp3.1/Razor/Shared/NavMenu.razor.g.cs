#pragma checksum "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158fed2147933d4127e88afd273edb051c68f9a9"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalAmadis.Shared
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
#line 1 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "ftco-section");
            __builder.AddAttribute(2, "style", "position: -webkit-sticky; position: sticky; top: 0; z-index: 999;");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "nav");
            __builder.AddAttribute(8, "class", "navbar navbar-expand-lg ftco_navbar ftco-navbar-light");
            __builder.AddAttribute(9, "id", "ftco-navbar");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<a class=\"navbar-brand\" href=\"/Tienda\">Fusion Market | Mercado</a>\r\n                ");
            __builder.AddMarkupContent(15, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""fa fa-bars""></span>
                </button>
                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "collapse navbar-collapse");
            __builder.AddAttribute(18, "id", "ftco-nav");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "navbar-nav ml-auto mr-md-3");
            __builder.AddAttribute(22, "style", "justify-content: space-between;");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<li class=\"nav-item\"><a href=\"/Tienda/Pedidos\" class=\"nav-link\">Pedidos <i class=\"fas fa-box-open\"></i></a></li>\r\n                        ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/Tienda/Carrito");
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddMarkupContent(30, "Carrito <i class=\"fas fa-shopping-cart\"></i>\r\n");
#nullable restore
#line 18 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                             if (myCarrito != null && myCarrito.ok == true) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "position-absolute top-0 start-100 translate-middle badge rounded-pill bg-primary");
            __builder.AddContent(33, 
#nullable restore
#line 18 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                                                                                             myCarrito.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                                                                                                                      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/Tienda/MiCuenta");
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 20 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                             if (StorageData != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "h6");
            __builder.AddAttribute(42, "class", "ml-3");
            __builder.AddContent(43, 
#nullable restore
#line 21 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                               StorageData.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, " ");
            __builder.AddContent(45, 
#nullable restore
#line 21 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                   StorageData.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, " <i class=\"fas fa-user-circle\"></i>");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                                                                               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.AddMarkupContent(49, "<li class=\"nav-item\"><a href=\"/Tienda/About\" class=\"nav-link\">Acerca de <i class=\"fas fa-info-circle\"></i></a></li>\r\n                        ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "nav-item");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", "/");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
                                                                   CerrarSesion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddMarkupContent(56, "Cerrar sesión <i class=\"fas fa-sign-out-alt\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Shared\NavMenu.razor"
      
    public dynamic StorageData { get; set; } = null;
    public dynamic Salir { get; set; }
    public dynamic myCarrito { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
                StorageData = JsonConvert.DeserializeObject(storage);
                await Loadcarrito();
                StateHasChanged();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public async Task Loadcarrito()
    {
        try
        {
            string myUrl2 = "https://super-mini-market.herokuapp.com/api/Cantidad_Producto_Carrito/" + StorageData.IdUsuario;
            Uri url = new Uri(myUrl2);
            WebClient client = new WebClient();
            var data = await client.DownloadStringTaskAsync(url);
            myCarrito = JsonConvert.DeserializeObject(data);
        }
        catch (Exception)
        {
            throw;
        }

    }
    async Task CerrarSesion()
    {
        string myUrl = "https://fusion-super-mini-market.herokuapp.com/api/CerrarSesion/" + StorageData.IdUsuario;
        Uri url = new Uri(myUrl);
        WebClient client = new WebClient();
        var data = await client.UploadStringTaskAsync(url, "");
        Salir = JsonConvert.DeserializeObject(data);

        if (Salir != null)
        {
            await Task.Delay(1000);
            NavigationManager.NavigateTo("/");
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