#pragma checksum "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4568e239ceea0f9406aa734b089bde4740db1fa9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Components.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorMovies.Client.App.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 1 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                       AppMode.WebAssembly

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(4);
                __builder2.AddAttribute(5, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "AdditionalAssemblies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(
#nullable restore
#line 3 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                                  new[] { typeof(Component1).Assembly }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(9);
                    __builder3.AddAttribute(10, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n                    ");
                        __builder4.AddMarkupContent(14, "<text>Custom authorizing...</text>\r\n                ");
                    }
                    ));
                    __builder3.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(16, "\r\n                    ");
                        __builder4.AddMarkupContent(17, "<text>Custom not authorized</text>\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(19, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(24);
                        __builder4.AddAttribute(25, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "C:\Users\gary.hake\source\personal\blazor-bootcamp\09-Server Side\BlazorMovies\Client\App.razor"
                                     typeof(MainLayout)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(27, "\r\n                    ");
                            __builder5.OpenComponent<BlazorMovies.Components.Shared.CustomNotFound>(28);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(29, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorMovies.Client.App
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
