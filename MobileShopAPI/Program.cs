using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MobileShopAPI.Entities;
using MobileShopAPI.Repositories;
using MobileShopAPI.Services;
using Swashbuckle.AspNetCore.Swagger;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:defaultConnection").Value));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();
builder.Services.AddScoped<IPlaceOrderService, PlaceOrderService>();



builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MobileWebApi", Version = "v1" });
});

builder.Services.AddControllers();


var app = builder.Build();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MobileWebApi v1"));
// Configure the HTTP request pipeline.



app.Run();