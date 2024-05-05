using PersonalProjectManagementTool.DAL.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectDAL(builder.Configuration);

var app = builder.Build();

app.Run();