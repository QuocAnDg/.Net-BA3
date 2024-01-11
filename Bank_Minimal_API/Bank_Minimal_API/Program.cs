using Bank_Minimal_API;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
app.MapGet("/calculate_tva", (double price, string country) =>
{
    var controller = new TvaController(); // Instancier votre contrôleur
    return controller.CalculateTva(price, country);
});

app.MapGet("/students", () =>
{
    var controller = new StudentController(); // Instancier votre contrôleur
    return controller.GetStudents();
});
app.MapGet("/Student/{id}", (int id) =>
{
    var controller = new StudentController(); // Instancier votre contrôleur
    return controller.GetById(id);
});
app.MapPost("/student", (String FirstName, String LastName, DateTime Birthday) =>
{
    var controller = new StudentController(); // Instancier votre contrôleur
    return controller.addStudent(FirstName, LastName, Birthday);
});
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}