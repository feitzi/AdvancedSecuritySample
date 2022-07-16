using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/minimalApi/redirect/{newUrl}",(string newUrl) => Results.Redirect(newUrl));

app.MapControllers();

app.Run();