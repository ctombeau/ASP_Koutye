using Koutye.Data;
using Koutye.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("KoutyeContext") ?? throw new InvalidOperationException("Connection string 'KoutyeContext' not found.");

builder.Services.AddDbContext<KoutyeContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<KoutyeContext>();

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
