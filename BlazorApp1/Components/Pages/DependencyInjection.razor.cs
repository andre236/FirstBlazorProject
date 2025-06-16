using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages
{
    public partial class DependencyInjection
    {
        [Inject(Key = "whatsapp")]
        public IMensagem MensagemChaveada { get; set; } = default!;
    }
}
