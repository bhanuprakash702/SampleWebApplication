using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using WebApplication1.Constants;
using WebApplication1.Data;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.Configure<UrlInfo>(builder.Configuration.GetSection("UrlInfo"));
//Register repo here.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase(databaseName: "InMemoryDb"));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



//register services here.
//builder.Services.AddScoped<IDataService, DataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
