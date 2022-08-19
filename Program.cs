var builder = WebApplication.CreateBuilder(args);

// add service to DI container
{
    var services = builder.Services;
    services.AddControllers();
}

var app = builder.Build();

// confige Http request pipeline
{
    app.MapGet("/",  () => "Hello World");
    app.MapControllers();
}

app.Run();