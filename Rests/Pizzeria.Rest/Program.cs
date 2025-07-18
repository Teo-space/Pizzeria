using Api.Filters.Filters;
using Pizzeria.Input;
using Pizzeria.Persistence;
using Pizzeria.Services;

var builder = WebApplication.CreateBuilder(args);
string ReleaseCorsPolicy = "ReleaseCorsPolicy";
{
    builder.Services.AddAnyCors(ReleaseCorsPolicy);

    builder.Services.AddControllersWithFilters(typeof(HttpExceptionFilter)).AddResponseCaching();

    builder.AddSerilogLogging("Pizzeria");


    builder.Services.AddFluentValidationWithValidators(typeof(InputModel).Assembly);

    string appBasePath = builder.Configuration.GetValue<string>(WebHostDefaults.ContentRootKey);

    builder.Services.AddDefaultSwagger(Prefix,
        Path.Combine(appBasePath, $"Pizzeria.Rest.xml"),
        Path.Combine(appBasePath, $"Pizzeria.Models.xml"),
        Path.Combine(appBasePath, $"Pizzeria.Input.xml"));
}
{
    builder.Services.AddInfrastructureUseSqlite(builder.Configuration);
    builder.Services.AddServices(builder.Configuration);
}
var app = builder.Build();
{
    app.UseSwaggerWithRoute(Prefix, Prefix);
    app.UseCors(ReleaseCorsPolicy);

    app.UseHttpsRedirection();

    app.UseResponseCaching();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
