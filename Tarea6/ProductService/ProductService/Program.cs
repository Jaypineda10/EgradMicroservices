var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var products = new[] {
new { Id = 1, Name = "Laptop", Price = 1200 },
new { Id = 2, Name = "Mouse", Price = 20 }
};


app.MapGet("/products", () => Results.Ok(products));
app.MapGet("/products/{id:int}", (int id) => {
    var p = products.FirstOrDefault(x => x.Id == id);
    return p is null ? Results.NotFound() : Results.Ok(p);
});


app.Run();