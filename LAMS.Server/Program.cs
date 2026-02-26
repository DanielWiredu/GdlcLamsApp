using BusinessLogic.Repository;
using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using Hangfire;
using LAMS.Server.Components;
using LAMS.Server.Components.Account;
using LAMS.Server.Data;
using LAMS.Server.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = true;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 5000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string 'Default' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddSingleton<IEmailService, EmailServiceMailKit>();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
//builder.Services.AddHttpContextAccessor();

builder.Services.AddHangfire(x =>
    x.UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage(builder.Configuration.GetConnectionString("HangFire"))
);
builder.Services.AddHangfireServer(x =>
{
    x.SchedulePollingInterval = TimeSpan.FromSeconds(60);
    x.Queues = new[] { builder.Configuration["HangfireSettings:QueueName"] ?? "default" };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    //Authorization = [new HangfireBasicAuthFilter(builder.Configuration.GetSection("HangfireLogin"))]
    Authorization = new[] { new HangfireIdentityAuthFilter() }
});

app.UseWhen(
    context => context.Request.Path.StartsWithSegments("/swagger"),
    appBuilder =>
    {
        appBuilder.UseAuthentication();
        appBuilder.UseAuthorization();

        appBuilder.Use(async (context, next) =>
        {
            if (!context.User.Identity?.IsAuthenticated ?? true)
            {
                context.Response.Redirect("/account/login");
                return;
            }

            await next();
        });
    });
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.UseStatusCodePagesWithRedirects("/error-404");

app.Run();
