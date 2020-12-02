#pragma checksum "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4ad591ca68588faeb37e2b6718cea60c88eb40"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\_Imports.razor"
using BlazorMovies.Shared.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class IndexPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index People</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"person/create\">New Person</a></div>\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.Pagination>(2);
            __builder.AddAttribute(3, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 11 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.BlazorMovies.Client.Pages.People.IndexPeople.TypeInference.CreateGenericList_0(__builder, 7, 8, 
#nullable restore
#line 13 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                   People

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table table-striped");
                __builder2.AddMarkupContent(12, "<thead><tr><th></th>\r\n                    <th>Name</th></tr></thead>\r\n            ");
                __builder2.OpenElement(13, "tbody");
#nullable restore
#line 23 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                 foreach (var item in People)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "tr");
                __builder2.OpenElement(15, "td");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "class", "btn btn-info");
                __builder2.AddAttribute(18, "href", "/person/" + (
#nullable restore
#line 27 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                                                                   item.Id

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 27 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                                                                            item.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "View");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 29 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "td");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "class", "btn btn-success");
                __builder2.AddAttribute(27, "href", "/person/edit/" + (
#nullable restore
#line 31 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                                                                           item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "class", "btn btn-danger");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                                                                       () => DeletePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\gary.hake\source\personal\blazor-bootcamp\05-Http and Entity Framework\Client\Pages\People\IndexPeople.razor"
       

    List<Person> People;
    PaginationDTO paginationDTO = new PaginationDTO() { RecordsPerPage = 1 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadPeople();
        }
        catch
        {

        }
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadPeople();
    }

    private async Task DeletePerson(int id)
    {
        await personRepository.DeletePerson(id);
        await LoadPeople();
    }

    private async Task LoadPeople()
    {
        var paginatedResponse = await personRepository.GetPeople(paginationDTO);
        People = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.IndexPeople
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591