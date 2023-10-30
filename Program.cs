using Jogo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<DataBase>();
builder.Services.AddSession(); // Adiciona suporte a sessão

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession(); // Habilita o uso de sessões

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Personagem}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "jogo",
        pattern: "Jogo/Jogo/{id:int}",
        defaults: new { controller = "Personagem", action = "Jogo" }
    );
});

app.Run();
