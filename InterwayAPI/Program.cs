
using InterwayAPI.Services.Extensions;
using InterwayAPI.Services.Implementations;
using InterwayAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;


var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
builder.Services.InjectDbContext(connectionString);
builder.Services.InjectRepositories();
builder.Services.InjectService();
builder.Services.InjectAutoMapper();
builder.Services.InjectFluentValidators();
builder.Services.AddHttpClient<IGeoTrackerService, GeoTrackerService>();

builder.Services
	.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	// Configures cookie-specific settings:
	.AddCookie(options =>
	{
		options.LoginPath = "/Users/Login";
		options.ExpireTimeSpan = TimeSpan.FromHours(1);
		options.SlidingExpiration = true;
	}
	);
builder.Services.AddAuthorization();

// Configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>
	{
		c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product Inventory API V1");
		c.RoutePrefix = string.Empty;
	});
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
