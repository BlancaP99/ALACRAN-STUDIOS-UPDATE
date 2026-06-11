var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Permite cargar archivos estáticos desde wwwroot:
// index.html, css, js, imágenes, fuentes, etc.
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();