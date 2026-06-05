var builder = WebApplication.CreateBuilder(args);
Console.WriteLine("ltz CreateBuilder!"); // Prints with newline

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();
Console.WriteLine("ltz builder.Build!"); // Prints with newline

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    Console.WriteLine("ltz MapOpenApi!"); // Prints with newline

    app.MapOpenApi();
}

// app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/tasks", () =>
{
    Console.WriteLine("ltz MapGetWeatherforcast!"); // Prints with newline

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            Random.Shared.Next(-200, 5500),
            summaries[Random.Shared.Next(summaries.Length)],
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            true
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();
Console.WriteLine("ltz below Run!"); // Prints with newline

record WeatherForecast(int Id, 
                        String TaskDescription,
                        DateOnly CreatedDate,
                        DateOnly DueDate, 
                        bool Completed)
{

}
