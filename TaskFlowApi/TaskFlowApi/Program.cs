using TaskFlowApi.Repositories;
using TaskFlowApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskRepository>();
builder.Services.AddScoped<TaskService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

