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
#line 2 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\Chat.razor"
using Ecommerce.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/application/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\D\Ecommerce\Ecommerce.Server\Pages\Applications\Chat\Chat.razor"
 
    bool open;
    Anchor ChatDrawer { get; set; }

    ChatUser[] chatUsers = new ChatUser[]
{
        new ChatUser { UserName = "Garderoben", UserRoleColor = Colors.DeepPurple.Accent4, OnlineStatus = Color.Success, Spotify = true, AvatarUrl = "https://avatars2.githubusercontent.com/u/10367109?s=460&amp;u=2abf95f9e01132e8e2915def42895ffe99c5d2c6&amp;v=4"},
        new ChatUser { UserName = "Henon", UserRoleColor = Colors.DeepPurple.Accent4, OnlineStatus = Color.Success, Spotify = false, AvatarUrl = "https://avatars.githubusercontent.com/u/44090?s=460&v=4"},
        new ChatUser { UserName = "Flaflo", UserRoleColor = Colors.Red.Accent3, OnlineStatus = Color.Success, Spotify = true, AvatarUrl = "https://avatars.githubusercontent.com/u/12973684?s=460&u=ea557f04c5d9c54f902f8c700292baefe59217d0&v=4"},
        new ChatUser { UserName = "porkopek", UserRoleColor = Colors.Red.Accent3, OnlineStatus = Color.Warning, Spotify = false, AvatarUrl = "https://avatars.githubusercontent.com/u/13745954?s=460&u=81ef9118f63113ad64bde35add178cbd9ca3bb38&v=4"},
        new ChatUser { UserName = "mike-gh", UserRoleColor = Colors.Red.Accent3, OnlineStatus = Color.Warning, Spotify = false, AvatarColor = Color.Success},
        new ChatUser { UserName = "tungi52", UserRoleColor = Colors.Red.Accent3, OnlineStatus = Color.Warning, Spotify = false, AvatarColor = Color.Success},
        new ChatUser { UserName = "svenovic", UserRoleColor = Colors.Red.Accent3, OnlineStatus = Color.Dark, Spotify = false, AvatarColor = Color.Success},
        new ChatUser { UserName = "Artroxa", UserRoleColor = Colors.BlueGrey.Lighten1, OnlineStatus = Color.Success, Spotify = false, AvatarUrl = "https://avatars2.githubusercontent.com/u/71094850?s=460&u=66c16f5bb7d27dc751f6759a82a3a070c8c7fe4b&v=4"},
        new ChatUser { UserName = "II ARROWS", UserRoleColor = Colors.BlueGrey.Lighten1, OnlineStatus = Color.Success, Spotify = false, AvatarUrl = "https://avatars.githubusercontent.com/u/14835013?s=460&u=8d9acfca411be6941ceb44f710c4357857350c2a&v=4"},
        new ChatUser { UserName = "rangsk", UserRoleColor = Colors.BlueGrey.Lighten1, OnlineStatus = Color.Success, Spotify = false, AvatarUrl = "https://avatars.githubusercontent.com/u/10701249?s=460&u=f806998af6e29fd4402736ba2efc2649adae9e39&v=4"},
        new ChatUser { UserName = "Svarta ??nkan", UserRoleColor = Colors.BlueGrey.Lighten1, OnlineStatus = Color.Error, Spotify = true, AvatarColor = Color.Error},
        new ChatUser { UserName = "TommyG", UserRoleColor = Colors.BlueGrey.Lighten1, OnlineStatus = Color.Warning, Spotify = false, AvatarUrl = "https://avatars.githubusercontent.com/u/4773183?s=460&u=7d0ebb28e29ae5103a74070471ffd506cdbf03fd&v=4"},
};

    ChatMessage[] chatMessages = new ChatMessage[]
    {
        new ChatMessage { UserName = "Garderoben", Message = "What is CSS?"},
        new ChatMessage { UserName = "Henon", Message = "idk?"},
        new ChatMessage { UserName = "Garderoben", Message = "me neither, anyone else?"},
        new ChatMessage { UserName = "Artroxa", Message = "lololololol"},
        new ChatMessage { UserName = "svenovic", Message = "Cascading Style Sheets"},
        new ChatMessage { UserName = "rangsk", Message = "CSS is a style sheet language used for describing the presentation of a document written in a markup language such as HTML."},
        new ChatMessage { UserName = "II ARROWS", Message = "We're on a mission from Glod."},
        new ChatMessage { UserName = "TommyG", Message = "Wth dude, i love Terry Pratchett"},
        new ChatMessage { UserName = "tungi52", Message = "Did you guys read his discworld book series?"},
        new ChatMessage { UserName = "TommyG", Message = "Yeah! It's great!"},
        new ChatMessage { UserName = "Garderoben", Message = "no more talk about books, this is very serious coder chat!"},
        new ChatMessage { UserName = "Artroxa", Message = "Yes, blazor is cool coding for cool kids" },
        new ChatMessage { UserName = "Flaflo", Message = "@Garderoben hey have you even started working on issue #294 on git?"},
        new ChatMessage { UserName = "Henon", Message = "Don't worry Flaflo, i took care of it."},
    };

    public ChatUser GetUser(string username)
    {
        var chatUser = chatUsers.FirstOrDefault(x => x.UserName == username);
        return chatUser;
    }

    void OpenDrawer(Anchor anchor)
    {
        ChatDrawer = anchor;
        open = true;
    }

    public string IconGift { get; set; } = "<path d=\"M22,12V20A2,2 0 0,1 20,22H4A2,2 0 0,1 2,20V12A1,1 0 0,1 1,11V8A2,2 0 0,1 3,6H6.17C6.06,5.69 6,5.35 6,5A3,3 0 0,1 9,2C10,2 10.88,2.5 11.43,3.24V3.23L12,4L12.57,3.23V3.24C13.12,2.5 14,2 15,2A3,3 0 0,1 18,5C18,5.35 17.94,5.69 17.83,6H21A2,2 0 0,1 23,8V11A1,1 0 0,1 22,12M4,20H11V12H4V20M20,20V12H13V20H20M9,4A1,1 0 0,0 8,5A1,1 0 0,0 9,6A1,1 0 0,0 10,5A1,1 0 0,0 9,4M15,4A1,1 0 0,0 14,5A1,1 0 0,0 15,6A1,1 0 0,0 16,5A1,1 0 0,0 15,4M3,8V10H11V8H3M13,8V10H21V8H13Z\" />";
    public string IconGif { get; set; } = "<path d=\"M11,8H13V16H11V8M7.67,8H4.33C3.53,8 3,8.67 3,9.33V14.67C3,15.33 3.53,16 4.33,16H7.67C8.47,16 9,15.33 9,14.67V12H7V14H5V10H9V9.33C9,8.67 8.47,8 7.67,8M21,10V8H15V16H17V14H19.5V12H17V10H21Z\" />";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
