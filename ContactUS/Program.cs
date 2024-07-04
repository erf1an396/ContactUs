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
       
    }

   

    await next();
});

app.Use(async (context, next) =>
{
    var url = context.Request.Path.ToString();
   

    context.Items.Add("item", "First User");

    await next();
});


app.Run(async (context) =>
{
    var item = context.Items["item"].ToString();
    await context.Response.WriteAsync($"<h1>app.Run() called - {item}</h1>");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

