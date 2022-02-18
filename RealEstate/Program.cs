using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models.Owner;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<AccountBase>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


// TODO Change controllers name
// app.MapControllerRoute(
//     name: "categories-and-websites-slug",
//     pattern: "{controller:regex(Categories|Websites)}/{Slug}",
//     defaults: new {controller = "controller", action = "Details"}
// );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Homepage}/{action=Index}/{slug?}");

app.MapAreaControllerRoute(
    name: "adminRoute",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);


app.MapRazorPages();

app.Run();