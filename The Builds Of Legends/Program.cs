using The_Builds_of_Legends.Components;
using The_Builds_of_Legends.IComponents;
using The_Builds_of_Legends.IRepositories;
using The_Builds_of_Legends.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRiotComponent, RiotComponent>();
builder.Services.AddScoped<IRiotRepository, RiotRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Documentation");
    });
}

app.UseHttpsRedirection();

/*app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;*/

app.UseAuthorization();
app.MapControllers();

app.Run();
