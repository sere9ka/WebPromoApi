using appserverproject.Data;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000");
    });
});

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

app.UseCors("CORSPolicy");

app.MapGet("/getallpromos", async () => 
    await PromosRepository.GetPromosAsync()
).WithTags("Promos EndPoints"); ;
app.MapGet("/getpromo-by-Id/{promoId}", async (int promoId) =>
{
    Promo promoToReturn = await PromosRepository.GetPromoByIdAsync(promoId);

    if (promoToReturn != null)
    {
        return Results.Ok(promoToReturn);
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Promos EndPoints");

app.MapPost("/create-promo", async (Promo promoToCreate) =>
{
    bool createSuccessful = await PromosRepository.CreatePromoAsync(promoToCreate);

    if (createSuccessful)
    {
        return Results.Ok("Create successful.");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Promos EndPoints");

app.MapPut("/update-promo", async (Promo promoToCreate) =>
{
    bool updateSuccessful = await PromosRepository.UpdatePromoAsync(promoToCreate);

    if (updateSuccessful)
    {
        return Results.Ok("Update successful.");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Promos EndPoints");

app.MapDelete("/deletepromo-by-id/{promoId}", async (int promoId) =>
{
    bool deleteSuccessful = await PromosRepository.DeletePromoAsync(promoId);

    if (deleteSuccessful)
    {
        return Results.Ok("Delete successful.");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Promos EndPoints");

app.Run();