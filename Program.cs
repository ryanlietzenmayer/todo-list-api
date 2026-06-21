using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

// good to have but idc for this purpose
// app.UseHttpsRedirection();

// app.UseRouting();
app.MapControllers();

// var todoSamples = new[]
// {
//     "Milk", "Cheddar", "Yogurt", "Butter", "Brie", "Cream", "Mozzarrralalla", "Almond Milk"
// };

// app.MapGet("/tasks", () =>
// {
//     Console.WriteLine("GET /tasks hit");

//     var forecast = Enumerable.Range(1, 5).Select(index =>
//         new ToDoTask
//         (
//             Random.Shared.Next(-200, 5500),
//             todoSamples[Random.Shared.Next(todoSamples.Length)],
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             true
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetToDoTask");

app.Run();

record ToDoTask(int Id, 
                        String TaskDescription,
                        DateOnly CreatedDate,
                        DateOnly DueDate, 
                        bool Completed)
{

}
