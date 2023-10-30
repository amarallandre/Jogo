using Jogo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<DataBase>();
builder.Services.AddSession(); // Adiciona suporte a sess�o

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

app.UseSession(); // Habilita o uso de sess�es

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Personagem",
        pattern: "{controller=Personagem}/{action=CriarPersonagem}/{id?}");

    endpoints.MapControllerRoute(
        name: "SelecionarPersonagem",
        pattern: "{controller=Personagem}/{action=SelecionarPersonagem}/{id?}");

    endpoints.MapDefaultControllerRoute();
});

app.Run();
