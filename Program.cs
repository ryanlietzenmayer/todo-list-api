var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

// app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/tasks", () =>
{
    Console.WriteLine("GET /tasks hit");

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

record WeatherForecast(int Id, 
                        String TaskDescription,
                        DateOnly CreatedDate,
                        DateOnly DueDate, 
                        bool Completed)
{

}
