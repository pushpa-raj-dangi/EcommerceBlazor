#pragma checksum "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830db2111ff7cbdf355bcf1871a26869ba4e36ac"
// <auto-generated/>
#pragma warning disable 1591
namespace Ecommerce.Server.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 4 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                         _themeManager.Theme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(9);
                __builder2.AddAttribute(10, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                          _themeManager.AppBarElevation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudHidden>(12);
                    __builder3.AddAttribute(13, "Breakpoint", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 10 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                               Breakpoint.SmAndDown

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(15);
                        __builder4.AddAttribute(16, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                            Icons.Custom.Brands.MudBlazor

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 11 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                 Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(19);
                    __builder3.AddAttribute(20, "Breakpoint", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 13 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                               Breakpoint.MdAndUp

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(22);
                        __builder4.AddAttribute(23, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                  Icons.Material.Outlined.Menu

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                       Color.Inherit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 14 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                            Edge.Start

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                   (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(28);
                    __builder3.AddAttribute(29, "Breakpoint", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 16 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                               Breakpoint.Xs

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(31);
                        __builder4.AddAttribute(32, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Class", "ml-4");
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(35, "Admin Dashboard");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(37);
                    __builder3.AddAttribute(38, "Breakpoint", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 19 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                               Breakpoint.Xs

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Invert", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(41);
                        __builder4.AddAttribute(42, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                           Typo.subtitle2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(44, "Admin Dashboard");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(46);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(48);
                    __builder3.AddAttribute(49, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                        Icons.Material.Outlined.Translate

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                  Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                            Direction.Bottom

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "OffsetY", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(55);
                        __builder4.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(57, "English");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(59);
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(61, "Swedish");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(63);
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, "Old Norse");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(67);
                    __builder3.AddAttribute(68, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                        Icons.Material.Outlined.Widgets

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                          Direction.Bottom

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "OffsetY", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(74);
                        __builder4.AddAttribute(75, "Link", "https://mudblazor.com/");
                        __builder4.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(77, "MudBlazor");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(79);
                        __builder4.AddAttribute(80, "Link", "https://github.com/Garderoben/MudBlazor.Templates");
                        __builder4.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(82, "Source Code");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(84);
                    __builder3.AddAttribute(85, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 32 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                            Direction.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "OffsetX", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "Class", "mt-1 ml-4");
                    __builder3.AddAttribute(89, "ActivatorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(90);
                        __builder4.AddAttribute(91, "Image", "images/avatar_jonny.jpg");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Ecommerce.Server.Shared.PersonCard>(93);
                        __builder4.AddAttribute(94, "Class", "mt-n2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudDivider>(96);
                        __builder4.AddAttribute(97, "Class", "mb-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(98, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudListItem>(99);
                        __builder4.AddAttribute(100, "Text", "Account");
                        __builder4.AddAttribute(101, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                   Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "Href", "/personal/account");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudListItem>(104);
                        __builder4.AddAttribute(105, "Text", "Logout");
                        __builder4.AddAttribute(106, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                  Icons.Material.Outlined.Login

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(107, "Href", "/pages/authentication/login");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(109);
                __builder2.AddAttribute(110, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                   _themeManager.DrawerElevation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ClipMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerClipMode>(
#nullable restore
#line 44 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                            _themeManager.DrawerClipMode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Ecommerce.Server.Shared.NavMenu>(115);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(117);
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudHidden>(119);
                    __builder3.AddAttribute(120, "Breakpoint", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 48 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                               Breakpoint.SmAndDown

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(122);
                        __builder4.AddAttribute(123, "DisableGutters", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(125);
                            __builder5.AddAttribute(126, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                      Icons.Material.Outlined.Menu

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(127, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 50 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                           Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(128, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                     (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(129, "Class", "ml-3");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(130, "\n                ");
                            __builder5.OpenComponent<MudBlazor.MudBreadcrumbs>(131);
                            __builder5.AddAttribute(132, "Items", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MudBlazor.BreadcrumbItem>>(
#nullable restore
#line 51 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                       _items

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(133, "\n                ");
                            __builder5.OpenComponent<MudBlazor.MudSpacer>(134);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(135, "\n                ");
                            __builder5.OpenComponent<MudBlazor.MudButton>(136);
                            __builder5.AddAttribute(137, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 53 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                    Variant.Text

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(138, "Link", "https://mudblazor.com/");
                            __builder5.AddAttribute(139, "Style", "color:#594AE2;");
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(141, "MudBlazor");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(142, "\n                ");
                            __builder5.OpenComponent<MudBlazor.MudButton>(143);
                            __builder5.AddAttribute(144, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 54 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                    Variant.Text

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(145, "Link", "https://github.com/Garderoben/MudBlazor.Templates");
                            __builder5.AddAttribute(146, "Style", "color:#424242;");
                            __builder5.AddAttribute(147, "Class", "mr-3");
                            __builder5.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(149, "Source Code");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(150, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudContainer>(151);
                    __builder3.AddAttribute(152, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 57 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                MaxWidth.False

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(153, "Class", "mt-4");
                    __builder3.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 58 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
__builder4.AddContent(155, Body);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\n    ");
                __builder2.OpenComponent<MudBlazor.ThemeManager.MudThemeManagerButton>(157);
                __builder2.AddAttribute(158, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                      (e) => OpenThemeManager(true)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\n    ");
                __builder2.OpenComponent<MudBlazor.ThemeManager.MudThemeManager>(160);
                __builder2.AddAttribute(161, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                           _themeManagerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 62 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                           OpenThemeManager

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(163, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ThemeManager.ThemeManagerTheme>(
#nullable restore
#line 62 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                    _themeManager

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "ThemeChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.ThemeManager.ThemeManagerTheme>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.ThemeManager.ThemeManagerTheme>(this, 
#nullable restore
#line 62 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
                                                                                                                 UpdateTheme

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\D\Ecommerce\Ecommerce.Server\Shared\MainLayout.razor"
       
    private ThemeManagerTheme _themeManager = new ThemeManagerTheme
    {
        Theme = new MudBlazorAdminDashboard(),
        DrawerClipMode = DrawerClipMode.Always,
        FontFamily = "Montserrat",
        DefaultBorderRadius = 6,
        AppBarElevation = 1,
        DrawerElevation = 1
    };

    public bool _drawerOpen = true;
    public bool _themeManagerOpen = false;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    void OpenThemeManager(bool value)
    {
        _themeManagerOpen = value;
    }

    void UpdateTheme(ThemeManagerTheme value)
    {
        _themeManager = value;
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        StateHasChanged();
    }

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Personal", href: "#"),
        new BreadcrumbItem("Dashboard", href: "#"),
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
