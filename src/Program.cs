using DestinyWebApi.Controllers;
using Microsoft.AspNetCore.Identity.Data;
using Destiny.Secrets;
using Microsoft.AspNetCore.DataProtection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Authentication for api and bungie
builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie", options => 
    {

    });
    // .AddOAuth("bungie", options => 
    // {

    //     // options.SignInScheme = "cookie";
    //     // options.ClientId = BungieSecrets.OAUTH_CLIENT_ID;
    //     // options.ClientSecret = BungieSecrets.OAUTH_CLIENT_SECRET;
    //     // options.SaveTokens = false;

    //     // options.AuthorizationEndpoint = BungieSecrets.OAUTH_APP_AUTHORIZATION_URL;
    //     // options.TokenEndpoint = BungieSecrets.OAUTH_TOKEN_URL;
    //     // options.CallbackPath = "/auth/bungie-cb";

    // });

builder.Services.AddAuthorization(builder =>
{
    builder.AddPolicy("bungie-enabled", policyBuilder =>
    {
        policyBuilder.AddAuthenticationSchemes("cookie")
        .RequireClaim("bungie-token", "y")
        .RequireAuthenticatedUser();
    });

    builder.AddPolicy("bungie-enabled", policyBuilder =>
    {
        policyBuilder.AddAuthenticationSchemes("cookie")
        .RequireClaim("bungie-token", "y")
        .RequireAuthenticatedUser();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
