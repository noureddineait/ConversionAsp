var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();

app.UseMvc(routes => routes.MapRoute("Default", "{controller=Home}/{action=FirstPage}"));

app.UseFileServer();
app.Run();
