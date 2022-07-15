var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/login", async context =>
{
    var user = context.Request.Query["user"];
    var pass = context.Request.Query["pass"];
   
    Console.WriteLine($"User: {user} Password: {pass}");
    if (user == "admin" && pass == "admin")
    {
        context.Response.StatusCode = 200;
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync("Login successful");
    }
    else
    {
        context.Response.StatusCode = 401;
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync("Login failed");
    }
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();