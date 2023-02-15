using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbFirstContext>(x => x.UseSqlServer("Data Source=LAPTOP-3P5KSU4T\\TEW_SQLEXPRESS;Initial Catalog=DbFirst;Integrated Security=True;Encrypt=False"));
var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithReExecute("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
app.Run();
