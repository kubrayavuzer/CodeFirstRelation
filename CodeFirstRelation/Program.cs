using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("default");

builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
