var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var orders = new[] {
new { Id = 1, CustomerId = 1, Total = 1220.0, Items = new[]{ "Laptop" } },
new { Id = 2, CustomerId = 2, Total = 20.0, Items = new[]{ "Mouse" } }
};


app.MapGet("/orders", () => Results.Ok(orders));
app.MapGet("/orders/{id:int}", (int id) => {
    var o = orders.FirstOrDefault(x => x.Id == id);
    return o is null ? Results.NotFound() : Results.Ok(o);
});


app.Run();