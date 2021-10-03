// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ecommerce.Server.Pages.Pages.Authentication
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pages/authentication/reset-password")]
    public partial class Reset : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\D\Ecommerce\Ecommerce.Server\Pages\Pages\Authentication\Reset.razor"
       
    string Password { get; set; }

    bool PasswordVisibility;
    InputType PasswordInput = InputType.Password;
    string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

    void TogglePasswordVisibility()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\D\Ecommerce\Ecommerce.Server\Pages\Pages\Authentication\Reset.razor"
         if (PasswordVisibility)
        {
            PasswordVisibility = false;
            PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            PasswordInput = InputType.Password;
        }
        else
        {
            PasswordVisibility = true;
            PasswordInputIcon = Icons.Material.Filled.Visibility;
            PasswordInput = InputType.Text;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\D\Ecommerce\Ecommerce.Server\Pages\Pages\Authentication\Reset.razor"
         
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
