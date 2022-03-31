using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/Detail");
    options.Conventions.AuthorizeFolder("/Detail/Management","IsEmployee");
    options.Conventions.AuthorizeFolder("/Detail/Management/openingHour","IsManagement");
    options.Conventions.AuthorizeFolder("/Detail/Management/Employment","IsManagement");
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.LoginPath = new PathString("/Login");
    options.AccessDeniedPath = new PathString("/Index");
}
);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IsEmployee", policy =>
     policy.RequireRole("Management", "Employee","Volunteer"));
    options.AddPolicy("IsManagement", policy =>
     policy.RequireRole("Management"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapRazorPages();

app.Run();
