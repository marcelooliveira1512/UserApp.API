using UserApp.API.Service.Extensions;
using UsersAPI.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();
builder.Services.AddJwtBearer();
builder.Services.AddCorsPolicy();

var app = builder.Build();

app.UseSwaggerDoc();
app.UseAuthentication();
app.UseAuthorization();
app.UseCorsPolicy();
app.MapControllers();
app.Run();
