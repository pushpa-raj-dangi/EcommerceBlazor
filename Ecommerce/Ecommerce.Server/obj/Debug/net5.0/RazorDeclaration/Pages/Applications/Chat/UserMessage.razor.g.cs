// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\UserMessage.razor"
using Ecommerce.Server.Models;

#line default
#line hidden
#nullable disable
    public partial class UserMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\UserMessage.razor"
       
    [Parameter] public string UserName { get; set; }
    [Parameter] public string Message { get; set; }
    [Parameter] public ChatUser ChatUser { get; set; }

    public string DiscordIcon = "<path d=\"M40 12s-4.586-3.59-10-4l-.488.977C34.406 10.176 36.652 11.89 39 14c-4.047-2.066-8.04-4-15-4-6.96 0-10.953 1.934-15 4 2.348-2.11 5.02-4.016 9.488-5.023L18 8c-5.68.535-10 4-10 4s-5.121 7.426-6 22c5.16 5.953 13 6 13 6l1.64-2.184C13.856 36.848 10.716 35.121 8 32c3.238 2.45 8.125 5 16 5s12.762-2.55 16-5c-2.715 3.121-5.855 4.848-8.64 5.816L33 40s7.84-.047 13-6c-.879-14.574-6-22-6-22zM17.5 30c-1.934 0-3.5-1.79-3.5-4s1.566-4 3.5-4 3.5 1.79 3.5 4-1.566 4-3.5 4zm13 0c-1.934 0-3.5-1.79-3.5-4s1.566-4 3.5-4 3.5 1.79 3.5 4-1.566 4-3.5 4z\"/>";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
