using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using Ramsey_Stair_CRUD_Project;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using Ramsey_Stair_CRUD_Project.Repos;

//^^^^MUST HAVE USING DIRECTIVES^^^^

//var config = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json")
//                .Build();
//string connString = config.GetConnectionString("DefaultConnection");
//IDbConnection conn = new MySqlConnection(connString);


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("ramseystair"));
    conn.Open();
    return conn;
});


builder.Services.AddTransient<IMantleRepository, MantleRepository>();
builder.Services.AddTransient<INicheRepository, NicheRepository>();
builder.Services.AddTransient<IRailRepository, RailRepository>();
builder.Services.AddTransient<ITubFrontRepository, TubFrontRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IWallAccessRepository, WallAccessRepository>();
builder.Services.AddTransient<IOrderFullRepository, OrderFullRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();