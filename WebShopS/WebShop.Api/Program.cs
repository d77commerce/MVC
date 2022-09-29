using Microsoft.OpenApi.Models;
using WebShopS.Core.Contracts;
using WebShopS.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "My Web Shop",
        Description = "Web Demo Shop - Bakery",
        License = new Microsoft.OpenApi.Models.OpenApiLicense()
        {
            Name = "TEST v 1.0"
        }
    });
    c.IncludeXmlComments("WebShopDocumentation.xml");
});

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
