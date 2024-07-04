namespace ContactUs
{
    public static class Detailprogram
    {
        public static void Test(IApplicationBuilder app)
        {
            app.Map("/index", config2 =>
            {

                config2.Run(async (context) =>
                {

                    await context.Response.WriteAsync("Run");

                });
            });

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Test", "Hello");

                await next();

            });
            app.Run(async (context) =>
            {
                var text = context.Response.Headers["Test"].ToString();
                if (text == "Hello")
                {
                    await context.Response.WriteAsync("Hello");
                }
                else
                {
                    context.Response.Redirect("/");
                }
            });
        }
        public static void MapWhen(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MapWhen");
            });
        }
    }

    
}
