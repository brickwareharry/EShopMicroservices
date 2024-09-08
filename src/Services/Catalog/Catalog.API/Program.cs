var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCarter();//note: Carter cannot be installed in BuildingBlocks since the configuration does not work, details see chapter 54
                                // Carter have to be installed in Catalog.API
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(opts => 
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();// UseLightweightSessions is a session type of Marten Library

var app = builder.Build();

// Configure the HTTP request pipeline
app.MapCarter();

app.Run();
