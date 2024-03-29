using DAL.Repositories;
using Logic.Animes;
using Logic.Characters;
using Logic.Mangas;
using Logic.Profiles;
using Logic.Reviews;
using Logic.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Log4Net.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
    loggingBuilder.AddLog4Net();
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(120);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login";
        options.AccessDeniedPath = "/Error";
    });

builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAnimeManager, AnimeManager>();
builder.Services.AddSingleton<IAnimeRepository, AnimeRepository>();
builder.Services.AddScoped<IMangaManager, MangaManager>();
builder.Services.AddSingleton<IMangaRepository, MangaRepository>();
builder.Services.AddScoped<ICharacterManager, CharacterManager>();
builder.Services.AddSingleton<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IListManager, ListManager>();
builder.Services.AddSingleton<ICustomListRepository, CustomListRepository>();
builder.Services.AddScoped<IProfileManager, ProfileManager>();
builder.Services.AddSingleton<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IReviewManager, ReviewManager>();
builder.Services.AddSingleton<IReviewRepository, ReviewRepository>();

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

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
