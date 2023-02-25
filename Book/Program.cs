var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapControllerRoute("default","{controller=home}/{action=index}");
app.MapControllerRoute("default", "Nav", new {controller="home", action="index"});

app.Run();
