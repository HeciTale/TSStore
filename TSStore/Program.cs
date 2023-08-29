using Microsoft.EntityFrameworkCore;
using TSStore.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Database:Connection"]);
});
var app = builder.Build();

app.MapDefaultControllerRoute();
app.UseStaticFiles();


app.Run();
