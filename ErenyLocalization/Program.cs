using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

//1- Resource path
builder.Services.AddLocalization(option=>option.ResourcesPath="Resources");




//2-- add mvc view localization
builder.Services.AddMvc()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();




//3-add supported languages

builder.Services.Configure<RequestLocalizationOptions>(options =>
{

    var supportedCulture = new[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("ar-EG")
    };


    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(culture: "en-US", uiCulture: "en-US");
    options.SupportedCultures= supportedCulture;
    options.SupportedUICultures= supportedCulture;
});







// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

//4-

 app.UseRequestLocalization();



app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
