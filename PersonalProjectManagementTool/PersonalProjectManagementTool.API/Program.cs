using PersonalProjectManagementTool.DAL.Extensions;
using PersonalProjectManagementTool.BLL.Extensions;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.Extensions;
using PersonalProjectManagementTool.API.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ProducesAttribute("application/json"));
    options.Filters.Add(new ConsumesAttribute("application/json"));
});

builder.Services.InjectDAL(builder.Configuration);
builder.Services.InjectBLL();
builder.Services.AddMappers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ExceptionHandlingMiddleware>();
var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:4200")
           .AllowAnyHeader()
           .AllowAnyMethod();
});

app.MapControllers();
app.UseHttpsRedirection();
app.Run();