// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Components.Pages.Movies
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
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieForm.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedActors { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();

    private string imageURL;

    protected override void OnInitialized()
    {
        Selected = SelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();

        if (!string.IsNullOrEmpty(Movie.Poster))
        {
            imageURL = Movie.Poster;
            Movie.Poster = null;
        }
    }

    private void PosterSelected(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return await personRepository.GetPeopleByName(searchText);
    }

    private async Task OnDataAnnotationsValidated()
    {
        Movie.MoviesGenres = Selected
            .Select(x => new MoviesGenres { GenreId = int.Parse(x.Key) }).ToList();

        Movie.MovieActors = SelectedActors
            .Select(x => new MovieActors { PersonId = x.Id, Character = x.Character }).ToList();

        if (!string.IsNullOrWhiteSpace(Movie.Poster)) { imageURL = null; }

        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
#pragma warning restore 1591
