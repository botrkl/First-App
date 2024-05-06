using PersonalProjectManagementTool.DAL.Extensions;
using PersonalProjectManagementTool.BLL.Extensions;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.Extensions;

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

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();