#pragma checksum "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dcb117c820719b6c189259596920f6088d87ba9"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Movies</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                 filterMoviesDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-inline");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group mb-2");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<label for=\"title\" class=\"sr-only\">Title</label>\r\n            ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "title");
                __builder2.AddAttribute(16, "placeholder", "Movie Title");
                __builder2.AddAttribute(17, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                  (KeyboardEventArgs e) => TitleKeyPress(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                filterMoviesDTO.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.Title = __value, filterMoviesDTO.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "select");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                                filterMoviesDTO.GenreId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.GenreId = __value, filterMoviesDTO.GenreId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value", "0");
                __builder2.AddMarkupContent(32, "\r\n                    --Select a Genre--\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n");
#nullable restore
#line 21 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                 foreach (var genre in Genres)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "                    ");
                __builder2.OpenElement(35, "option");
                __builder2.AddAttribute(36, "value", 
#nullable restore
#line 23 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                    genre.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(37, 
#nullable restore
#line 23 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                               genre.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
#nullable restore
#line 24 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(39, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "type", "checkbox");
                __builder2.AddAttribute(47, "class", "form-check-input");
                __builder2.AddAttribute(48, "id", "upcomingReleases");
                __builder2.AddAttribute(49, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                          filterMoviesDTO.UpcomingReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.UpcomingReleases = __value, filterMoviesDTO.UpcomingReleases));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.AddMarkupContent(52, "<label class=\"form-check-label\" for=\"upcomingReleases\">\r\n                Upcoming Releases\r\n            </label>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "checkbox");
                __builder2.AddAttribute(59, "class", "form-check-input");
                __builder2.AddAttribute(60, "id", "upcomingReleases");
                __builder2.AddAttribute(61, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                          filterMoviesDTO.InTheaters

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.InTheaters = __value, filterMoviesDTO.InTheaters));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.AddMarkupContent(64, "<label class=\"form-check-label\" for=\"inTheaters\">\r\n                In Theaters\r\n            </label>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n        ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "type", "button");
                __builder2.AddAttribute(68, "class", "btn btn-primary mb-2 mx-sm-3");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                                                             SearchForMovies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Filter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "type", "button");
                __builder2.AddAttribute(74, "class", "btn btn-danger mb-2");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                                                    Clear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "Clear");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenComponent<BlazorMovies.Components.Shared.MoviesList>(80);
            __builder.AddAttribute(81, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 46 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                    Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Components.Shared.Pagination>(83);
            __builder.AddAttribute(84, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                         filterMoviesDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                                                                 totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 49 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies.Components\Pages\Movies\MovieFilter.razor"
       
    private List<Movie> Movies;
    private FilterMoviesDTO filterMoviesDTO = new FilterMoviesDTO();
    private int totalAmountPages;
    private List<Genre> Genres = new List<Genre>();

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var queryStrings = navigationManager.GetQueryStrings(navigationManager.Uri);
            Genres = await genreRepository.GetGenres();
            if (queryStrings != null)
            {
                FillFilterWithQueryStrings(queryStrings);
            }
            await LoadMovies();
            StateHasChanged();
        }
    }

    private void FillFilterWithQueryStrings(Dictionary<string, string> queryStrings)
    {
        if (queryStrings.ContainsKey("genreId"))
        {
            filterMoviesDTO.GenreId = int.Parse(queryStrings["genreId"]);
        }

        if (queryStrings.ContainsKey("title"))
        {
            filterMoviesDTO.Title = queryStrings["title"];
        }

        if (queryStrings.ContainsKey("intheaters"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["intheaters"]);
        }

        if (queryStrings.ContainsKey("upcomingReleases"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["upcomingReleases"]);
        }

        if (queryStrings.ContainsKey("page"))
        {
            filterMoviesDTO.Page = int.Parse(queryStrings["page"]);
        }
    }

    private async Task SelectedPage(int page)
    {
        filterMoviesDTO.Page = page;
        await LoadMovies();
    }

    private async Task LoadMovies()
    {
        var queryString = GenerateQueryString();
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            queryString = $"?{queryString}";
            navigationManager.NavigateTo("movies/search" + queryString);
        }

        var paginatedResponse = await moviesRepository.GetMoviesFiltered(filterMoviesDTO);
        Movies = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private string GenerateQueryString()
    {
        var queryStringsDict = new Dictionary<string, string>();
        queryStringsDict["genreId"] = filterMoviesDTO.GenreId.ToString();
        queryStringsDict["title"] = filterMoviesDTO.Title ?? "";
        queryStringsDict["intheaters"] = filterMoviesDTO.InTheaters.ToString();
        queryStringsDict["upcomingReleases"] = filterMoviesDTO.UpcomingReleases.ToString();
        queryStringsDict["page"] = filterMoviesDTO.Page.ToString();

        var defaultValue = new List<string>() { "false", "", "0" };

        // genreId=4&title=spider....

        return string.Join("&", queryStringsDict
            .Where(x => !defaultValue.Contains(x.Value.ToLower()))
            .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());

    }

    private async Task SearchForMovies()
    {
        await LoadMovies();
    }

    private async Task Clear()
    {
        filterMoviesDTO.Title = "";
        filterMoviesDTO.GenreId = 0;
        filterMoviesDTO.UpcomingReleases = false;
        filterMoviesDTO.InTheaters = false;
        await LoadMovies();
    }

    private async Task TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await SearchForMovies();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
