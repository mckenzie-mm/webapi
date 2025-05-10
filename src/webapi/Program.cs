using webapi.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

{
    // configure services (DI)
    builder.Services.AddScoped<ProductsService>();
    builder.Services.AddControllers();
}

WebApplication app = builder.Build();
{
    // configure request pipeline
    app.MapControllers();
}

app.Run();