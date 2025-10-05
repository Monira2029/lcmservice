var builder = WebApplication.CreateBuilder(args);

// 🚨 THIS IS IMPORTANT for Railway deployment
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(int.Parse(port));
});

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
