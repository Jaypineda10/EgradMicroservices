var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var customers = new[] {
new { Id = 1, Name = "Ana Perez", Email = "ana@example.com" },
new { Id = 2, Name = "Luis Gomez", Email = "luis@example.com" }
};


app.MapGet("/customers", () => Results.Ok(customers));
app.MapGet("/customers/{id:int}", (int id) => {
    var c = customers.FirstOrDefault(x => x.Id == id);
    return c is null ? Results.NotFound() : Results.Ok(c);
});


app.Run();