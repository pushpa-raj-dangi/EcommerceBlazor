#pragma checksum "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354316c3ee6249237d539c1cbf8127006030a8ce"
// <auto-generated/>
#pragma warning disable 1591
namespace Ecommerce.Server.Pages.Applications.Chat
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.DummyData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using Ecommerce.Server.Services.FileUpload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\D\Ecommerce\Ecommerce.Server\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudListItem>(0);
            __builder.AddAttribute(1, "Class", "pa-0 px-2");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "d-flex flex-row mt-n1 mb-n1");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "mr-4");
                __builder2.OpenComponent<MudBlazor.MudBadge>(7);
                __builder2.AddAttribute(8, "Bottom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Dot", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Overlap", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                                                      OnlineStatus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Bordered", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Class", "my-2");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 6 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                 if (!String.IsNullOrEmpty(AvatarUrl))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudAvatar>(15);
                    __builder3.AddAttribute(16, "Image", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                       AvatarUrl

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 9 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudAvatar>(17);
                    __builder3.AddAttribute(18, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                       AvatarColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(20);
                        __builder4.AddAttribute(21, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                        DiscordIcon

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "Style", "font-size: 1.8rem;");
                        __builder4.AddAttribute(23, "ViewBox", "0 0 48 48");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 15 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.OpenComponent<MudBlazor.MudText>(26);
                __builder2.AddAttribute(27, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                           Typo.body2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                                                $"color:{@UserRoleColor};"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Class", "mt-3 mb-n2");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(31, "b");
#nullable restore
#line 19 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
__builder3.AddContent(32, UserName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
             if (ListeningToSpotify)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudText>(33);
                __builder2.AddAttribute(34, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 22 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
                               Typo.caption

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, "Listening to ");
                    __builder3.AddMarkupContent(37, "<b>Spotify</b>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\User.razor"
       
    [Parameter] public string UserName { get; set; }
    [Parameter] public string AvatarUrl { get; set; }
    [Parameter] public Color OnlineStatus { get; set; }
    [Parameter] public Color AvatarColor { get; set; }
    [Parameter] public string UserRoleColor { get; set; }
    [Parameter] public bool ListeningToSpotify { get; set; }

    public string DiscordIcon = "<path d=\"M40 12s-4.586-3.59-10-4l-.488.977C34.406 10.176 36.652 11.89 39 14c-4.047-2.066-8.04-4-15-4-6.96 0-10.953 1.934-15 4 2.348-2.11 5.02-4.016 9.488-5.023L18 8c-5.68.535-10 4-10 4s-5.121 7.426-6 22c5.16 5.953 13 6 13 6l1.64-2.184C13.856 36.848 10.716 35.121 8 32c3.238 2.45 8.125 5 16 5s12.762-2.55 16-5c-2.715 3.121-5.855 4.848-8.64 5.816L33 40s7.84-.047 13-6c-.879-14.574-6-22-6-22zM17.5 30c-1.934 0-3.5-1.79-3.5-4s1.566-4 3.5-4 3.5 1.79 3.5 4-1.566 4-3.5 4zm13 0c-1.934 0-3.5-1.79-3.5-4s1.566-4 3.5-4 3.5 1.79 3.5 4-1.566 4-3.5 4z\"/>";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591