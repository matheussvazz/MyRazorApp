var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); // adiciona suporte para páginas Razor

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages(); // Auxilia no mapeamento das paginas 

app.Run();
