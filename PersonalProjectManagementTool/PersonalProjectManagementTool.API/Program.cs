using PersonalProjectManagementTool.DAL.Extensions;
using PersonalProjectManagementTool.BLL.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectDAL(builder.Configuration);
builder.Services.InjectBLL();

var app = builder.Build();

app.Run();