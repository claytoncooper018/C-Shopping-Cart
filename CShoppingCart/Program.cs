var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSession();  // <-- important for cart storage

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();  // <-- important
app.MapRazorPages();
app.Run();
