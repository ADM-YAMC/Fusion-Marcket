// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Usuarios.razor"
using FinalAmadis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Usuarios.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Usuarios.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Usuarios.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuarios")]
    public partial class Usuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "C:\Users\Jairo Melo\source\repos\FINALDELOFINALE\FinalAmadis\FinalAmadis\Pages\AdminPages\Usuarios.razor"
       
    public dynamic Datos { get; set; }
    public dynamic Editable { get; set; }
    string jsonString;
    string Rol;
    public dynamic StorageData { get; set; }
    private RegistroUsuario user = new RegistroUsuario();
    DateTime fecha;
    Api consume = new Api();
    public string Buscar { get; set; }

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

        }
        catch (Exception)
        {

            throw;
        }

    }
    public bool IsVisible(dynamic cate)
    {
        if (string.IsNullOrEmpty(Buscar))
            return true;
        if (cate.Nombre_Usuario.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        if (cate.Apellido_Usuario.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        if (cate.Fecha_Nacimiento.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        if (cate.Correo.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        if (cate.Rol.ToString().Contains(Buscar, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    public async Task RegisterUser()
    {
        try
        {
            user.Rol = "Administrador";
            user.Fecha_Nacimiento = fecha.ToString("dd/MM/yyyy");
            jsonString = JsonConvert.SerializeObject(user);
            string myUrl = "https://super-mini-market.herokuapp.com/api/Registro_Admins/" + StorageData.IdUsuario;
            Uri url = new Uri(myUrl);
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                Datos = null;
                await Reload();
                Mensajes();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public async Task Handleupdate()
    {
        try
        {
            DeleteUser modificar = new DeleteUser();
            modificar.IdAdmin = StorageData.IdUsuario;
            modificar.IdUsuario = user.IdUsuario.ToString();
            jsonString = JsonConvert.SerializeObject(modificar);
            string myUrl = "https://super-mini-market.herokuapp.com/api/Modificar_Usuarios/" + Rol;
            Uri url = new Uri(myUrl);
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                Datos = null;
                await Reload();
                Mensajes();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private async Task HandleDelete()
    {
        try
        {
            DeleteUser borrado = new DeleteUser();
            borrado.IdAdmin = StorageData.IdUsuario;
            borrado.IdUsuario = user.IdUsuario.ToString();

            jsonString = JsonConvert.SerializeObject(borrado);
            Uri url = new Uri("https://super-mini-market.herokuapp.com/api/Borrar_Usuarios");
            WebClient client = new WebClient();
            var data = await client.UploadStringTaskAsync(url, jsonString);
            Editable = JsonConvert.DeserializeObject(data);
            if (Editable != null)
            {
                Datos = null;
                await Reload();
                Mensajes();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public async Task<dynamic> data(dynamic select)
    {

        await Task.Delay(10);
        if (select != null)
        {
            user.IdUsuario = select.IdUsuario;
            user.Nombre = select.Nombre_Usuario;
            user.Correo = select.Correo;
        }
        return null;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                var storage = await JSRuntime.InvokeAsync<string>("storagePicker");
                StorageData = JsonConvert.DeserializeObject(storage);
                StateHasChanged();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    private async Task Mensajes()
    {
        if (Editable.ok == true)
        {
            await JSRuntime.InvokeVoidAsync("Confirmar", "success", "¡Exito!", "Su solicitud fue aprobada!");
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("Confirmar", "error", "Vaya!", "Ocurrio un error...");
        }

    }
    public void Clear()
    {
        user = new RegistroUsuario();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
