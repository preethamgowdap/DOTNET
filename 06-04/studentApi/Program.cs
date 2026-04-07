using StudentApi.Repositories;
using StudentApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
builder.Services.AddSingleton<IStudentService, StudentService>();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.MapControllers();
app.Run();