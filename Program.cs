using LearnJava.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DATABASE
builder.Services.AddDbContext<GameDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("ConnectionStrings:GameDbCOntextConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();

app.Run();
