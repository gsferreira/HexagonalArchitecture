using Adapter.Kafka;
using Adapter.PostgreSQL;
using Core.AddBookRead;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBookReadStore, PostgreBookReadStore>();
builder.Services.AddScoped<IBookReadPublisher, KafkaBookReadPublisher>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.MapPost("/reads", (IAddBookRead read, string isbn) =>  
    read.AddReadAsync(1, isbn));

app.Run();
