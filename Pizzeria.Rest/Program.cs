using Api.Controllers;
using Api.Filters.Filters;
using Api.Swagger;
using Pizzeria.Persistence;
using Pizzeria.Services;

var builder = WebApplication.CreateBuilder(args);
string ReleaseCorsPolicy = "ReleaseCorsPolicy";
{
    builder.Services.AddControllersWithFilters(typeof(HttpExceptionFilter));
    builder.Services.AddAnyCors(ReleaseCorsPolicy);
    builder.Logging.AddSerilogLogging(builder.Configuration);
    builder.Services.AddMemoryCache();
    builder.Services.AddFluentValidationWithValidators(typeof(Program).Assembly);

    var AppBasePath = builder.Configuration.GetValue<string>(WebHostDefaults.ContentRootKey);
    AppBasePath += Path.DirectorySeparatorChar + "bin" + Path.DirectorySeparatorChar;
    builder.Services.AddDefaultSwagger(Prefix, Path.Combine(AppBasePath, $"Pizzeria.Models.xml"));
}
{
    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddServices(builder.Configuration);
}
var app = builder.Build();
{
    app.UseSwaggerWithRoute(Prefix, Prefix);
    app.UseCors(ReleaseCorsPolicy);

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
