using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/orf", () => "Hello Orf!");
app.MapGet("/redirect/{newUrl}",(string newUrl) => Results.Redirect(newUrl));
app.Run();