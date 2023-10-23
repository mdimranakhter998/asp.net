using Ecommerce.BusinessAccessLayer.Repository.Admin.Product;
using Ecommerce.BusinessAccessLayer.Repository.Admin.User;
using Ecommerce.BusinessAccessLayer.Repository.Services.Admin.Product;
using Ecommerce.BusinessAccessLayer.Repository.Services.Admin.User;
using Ecommerce.DataAccessLayer;


using EcommerceUI.Admin.Validators.Gender;
using FluentValidation.AspNetCore;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();



//Connection with Sql Server

builder.Services.AddDbContext<Context>(options =>
{
    
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

//Dependency Injection
builder.Services.AddScoped<IStatus, Status>();
builder.Services.AddScoped<ICategory, Category>();
builder.Services.AddScoped<IGender, Gender>();
builder.Services.AddScoped<IUserType, UserType>();
builder.Services.AddScoped<IUserStatus,UserStatus>();
builder.Services.AddScoped<IAddressType, AddressType>();






////Fluent Validation Service
//builder.Services.AddScoped<IValidator<GenderModel>, GenderValidator>();

// Fluent Validation Configuration
//builder.Services.AddFluentValidationClientsideAdapters();

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
