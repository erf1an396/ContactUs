var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Use(async (context, next) =>
{
    var url = context.Request.Path.ToString();
    if (url.ToLower() == "/home/index")
    {
        context.Response.Headers.Add("CustomeHeader", $"{url}");
        await context.Response.WriteAsync("App.user called");
    }

    await next();
});


app.Use(async (context, next) =>
{
    var url = context.Request.Path.ToString();
    if (url.ToLower() == "/home/index")
    {
        context.Response.Headers.Add("CustomeHeader", $"{url}");
        await context.Response.WriteAsync("App.user called");
    }

    await next();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

