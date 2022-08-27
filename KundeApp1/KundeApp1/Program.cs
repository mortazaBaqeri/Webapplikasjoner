// initieerer builder
var builder = WebApplication.CreateBuilder(args);

// konfigurerer bulider før vi "Build-er" den 
builder.Services.AddControllers();

// "Build-er" appen
var app = builder.Build();

// kofigurere appen før vi kjørere appen 
app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
//app.MapGet("/", () => "Hello World!");


// kjører appen
app.Run();

