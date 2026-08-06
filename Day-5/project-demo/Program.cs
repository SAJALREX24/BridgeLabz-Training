var builder = WebApplication.CreateBuilder(args);

// 1. Tell the app to use Controllers and Register your Repository
builder.Services.AddControllers();
builder.Services.AddScoped<project_demo.Repo.IProductRepository, project_demo.Repo.ProductRepository>();

builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(); 

var app = builder.Build();

app.MapOpenApi();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();

// 2. Map your controller endpoints
app.MapControllers();

app.Run();