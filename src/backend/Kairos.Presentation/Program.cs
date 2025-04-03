var builder = WebApplication.CreateBuilder(args);
    builder.AddArchitectureExtensions();
    
var app = builder.Build();
    app.UseArchitectureExtensions();
