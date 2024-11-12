//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Ajouter les services nécessaires à Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Utiliser les fichiers statiques (HTML, CSS, JS) depuis wwwroot
app.UseStaticFiles();

// Configurer les pages Razor (si vous en utilisez)
app.MapRazorPages();

// Lancer l'application
app.Run();

