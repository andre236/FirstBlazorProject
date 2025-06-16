using BlazorApp1.Components;
using BlazorApp1.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Transicent Resumo : Uma instancia para cada necessidade de inje��o
//builder.Services.AddTransient<RandomNumber>(); // Resumo : 

//AddScoped Resumo : Uma instancia para cada requisi��o HTTP (escopo) � a requisi��o
//builder.Services.AddScoped<RandomNumber>(); // Se comporta como singleton por�m a a��o � por cada client

//AddSingleton : Uma instancia para a aplica��o inteira.
//builder.Services.AddSingleton<RandomNumber>();
builder.Services.AddSingleton<RandomNumber>();
builder.Services.AddSingleton<IMensagem, MensagemEmail>();

builder.Services.AddKeyedSingleton<IMensagem, MensagemWhatsApp>("whatsapp"); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithRedirects("/StatusCode/{0}");

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
