using FootballManagerUI;
using FootballManagerUI.Services; // Services namespace-ni qo‘shing
using FootballManagerUI.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient bazaviy manzilni backend API manzilingiz bilan almashtiring
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5227/") });

// Xizmatlarni ro'yxatdan o'tkazish
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IMatchService, MatchService>();
builder.Services.AddScoped<IGoalService, GoalService>();
builder.Services.AddScoped<IAuthService, AuthService>();

await builder.Build().RunAsync();
