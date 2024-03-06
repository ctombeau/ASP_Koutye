using Koutye.Data;
using Koutye.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("KoutyeContext") ?? throw new InvalidOperationException("Connection string 'KoutyeContext' not found.");

builder.Services.AddDbContext<KoutyeContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<IdentityUser>(options => {
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = true;

    
    })
    .AddEntityFrameworkStores<KoutyeContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience="",
        ValidIssuer = "",
        RequireExpirationTime=true,
        IssuerSigningKey= new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Voici la cle...")),
        ValidateIssuerSigningKey=true
    };
});

// Add services to the container.
/*
builder.Services.AddDbContext<KoutyeContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("KoutyeDB")));
*/

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();;

app.UseAuthorization();

//app.MapIdentiyApi<IdentityUser>();

app.MapControllers();

app.Run();
