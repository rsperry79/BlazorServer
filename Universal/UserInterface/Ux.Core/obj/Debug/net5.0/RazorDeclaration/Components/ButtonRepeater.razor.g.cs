// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ux.Core.Components
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using BlazorCurrentDevice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using BlazorApplicationInsights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\_Imports.razor"
using global::Core.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\Components\ButtonRepeater.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\Components\ButtonRepeater.razor"
using Ux.Common.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class ButtonRepeater : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Users\rsperr\OneDrive\Desktop\Table\Blazor\Universal\UserInterface\Ux.Core\Components\ButtonRepeater.razor"
       
    [Parameter]
    public List<IButton> Buttons { get; set; }

    [Parameter]
    public int Rating { get; set; }

    [Parameter]
    public EventCallback<int> RatingChanged { get; set; }

    public async Task ValueChanged(int sender)
    {
        Rating = sender;
        await RatingChanged.InvokeAsync(sender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INavigationService navigationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageSettingsBase localStorageSettings { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
