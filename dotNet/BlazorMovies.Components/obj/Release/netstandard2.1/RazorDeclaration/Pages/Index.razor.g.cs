#pragma checksum "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d124dc350d34494f230261ee5d04eb6bd2434d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Components.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Shared.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Components.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Components.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\_Imports.razor"
using BlazorMovies.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Index.razor"
      
    private List<Movie> InTheaters;
    private List<Movie> UpcomingReleases;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var response = await moviesRepository.GetIndexPageDTO();
            InTheaters = response.Intheaters;
            UpcomingReleases = response.UpcomingReleases;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
