using mangas.Services.Features.Mangas;
using mangas.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<MangaService>();

// Add services to the container.
//builder.Services.AddSingleton<MangaService>();
builder.Services.AddScoped<MangaService>();
builder.Services.AddTransient<MangaRepository>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();