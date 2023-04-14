using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentAdminPortalAPI.DataModels;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddDbContext<StudentAdminContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("StudentAdminPortalDb")));

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
