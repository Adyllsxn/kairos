namespace Kairos.Presentation.Infrastructure.Extensions.Architecture;
public static class SwaggerExtensions
{
    public static void AddSwaggerExtensions(this IServiceCollection services)
    {
        services.AddSwaggerGen();
    }

    public static void UseSwaggerExtensions(this WebApplication app)
    {
        if(app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
