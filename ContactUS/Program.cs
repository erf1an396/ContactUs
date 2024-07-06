using ContactUs;
using ContactUs.Middleware;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
app.UseHsts();
}


static void ConfigureServices(IServiceCollection services)
{

    services.AddControllersWithViews();

}

static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    var enviroment = env.EnvironmentName;
    if (env.IsProduction())
    {
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(enviroment);
        });
    }
    if (env.IsDevelopment())
    {

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(enviroment);
        });

    }
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync(enviroment);
    });
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



//app.MapWhen(context => context.Request.Query.ContainsKey("test"),Detailprogram.MapWhen);
//app.Map("/home", Detailprogram.Test);

app.UseTest();
//app.UseMiddleware<Test>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "customRoute",
    pattern: "/codeyad/{name}",
    defaults:new {Controller = "Home", Action = "Messages"});

app.Run();


