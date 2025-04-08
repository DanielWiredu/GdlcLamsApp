using AppMain.Client.Pages;
using AppMain.Components;
using BusinessLogic.Repository;
using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using Syncfusion.Blazor;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using Hangfire;
using Microsoft.AspNetCore.Mvc.Filters;
using AppMain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//begin my services
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddDbContext<GdlcdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddMudServices();

builder.Services.AddControllers();

builder.Services.AddHangfire(x =>
    x.UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage(builder.Configuration.GetConnectionString("HangFire"))
);
builder.Services.AddHangfireServer(x =>
{
    x.SchedulePollingInterval = TimeSpan.FromSeconds(60);
    x.Queues = new[] { builder.Configuration["GdlcBranch"] };
});
//end my services

var app = builder.Build();
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzM0NDg0M0AzMjM2MmUzMDJlMzBHbUVRSWphRmpqSUlFTnVTWXFFYjJBK1lKTWhPT3dxWjJSU3dhMWNjM1lJPQ==");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXhcdXVVRmVcWUZwXEA=");

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    //Authorization = new[] { new HttpsAuthorizationFilter() }, // Optional: Add authorization filters
    Authorization = [new HangfireBasicAuthFilter()],
    AppPath = null, // Set to null to prevent users from being redirected away from the dashboard
    DisplayStorageConnectionString = false, // Optional: Hide storage connection string in the dashboard UI
    IgnoreAntiforgeryToken = true // Optional: Disable antiforgery token validation
});


app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(AppMain.Client._Imports).Assembly);

app.Run();
