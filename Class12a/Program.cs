using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Class12a.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Class12aContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Class12aContext") ?? throw new InvalidOperationException("Connection string 'Class12aContext' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
