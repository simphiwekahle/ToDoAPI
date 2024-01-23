using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;

var builder = WebApplication.CreateBuilder(args);

//Register DbContext for dependency injections
builder.Services.AddDbContext<AppDbContext>(
    opt => opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

var app = builder.Build();


//app.UseHttpsRedirection();



app.Run();


