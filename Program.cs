using WebApplication1.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptions<ConnectionStrings>()
    .Bind(builder.Configuration.GetSection(ConnectionStrings.Section))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services.AddOptions<APIConfigurations>()
    .Bind(builder.Configuration.GetSection(APIConfigurations.Section))
    .ValidateDataAnnotations()
    .ValidateOnStart();

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

await app.RunAsync();