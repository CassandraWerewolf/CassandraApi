using Application;
using Application.Features.ProductFeatures.Commands;
using Application.Features.ProductFeatures.Queries;
using Application.Games.Queries;
using Domain.Entities;
using MediatR;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new() { Title = "Cassandra Project", Version = "v1" });
});
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello from Cassandra Project API!").ExcludeFromDescription();

app.MapGet("/product", async (IMediator Mediator, CancellationToken cancellationToken) => 
{
    return Results.Ok(await Mediator.Send(new GetAllProducts(), cancellationToken));
})
.WithName("GetProducts")
.Produces<List<Product>>(200);

app.MapGet("/games", async (IMediator Mediator, CancellationToken cancellationToken) =>
{ 
    return Results.Ok(await Mediator.Send(new GetAllGames(), cancellationToken)); 
})
.WithName("GetGames")
.Produces<List<Game>>(200);


app.MapGet("/product/{id}", async (int id, IMediator Mediator, CancellationToken cancellationToken) =>
{
    return await Mediator.Send(new GetProductById { Id = id }, cancellationToken)
        is Product product
            ? Results.Ok(product)
            : Results.NotFound();
})
.WithName("GetProduct")
.Produces<Product>(200)
.Produces(404);

app.MapPost("/product", async (CreateProduct command, IMediator Mediator) =>
{
    var result = await Mediator.Send(command);
    return Results.CreatedAtRoute("GetProduct", new { Id = result.Id }, result);
})
.WithName("CreateProduct");



app.Run();
