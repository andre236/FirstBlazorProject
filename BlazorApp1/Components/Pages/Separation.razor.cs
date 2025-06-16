using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp1.Components.Pages
{
    public partial class Separation
    {
        
        public string Text = "Oi eu sou código c#";

        [Inject]
        public IJSRuntime JSRuntime { get; set; } = default!;

        public async Task CarregarJS()
        {
            var modulo = await JSRuntime
                .InvokeAsync<IJSObjectReference>("import", "./Components/Pages/Separation.razor.js");
            //await JSRuntime.InvokeVoidAsync("ShowMessage");
            await modulo.InvokeVoidAsync("ShowMessageTwo");
        }
    }


}
