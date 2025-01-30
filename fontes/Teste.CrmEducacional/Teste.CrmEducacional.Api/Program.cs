using Teste.CrmEducacional.Domain.Configurations;
using Teste.CrmEducacional.Domain.Configurations.MapeamentoDTOs;
using Teste.CrmEducacional.Repository.Repository;
using Teste.CrmEducacional.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<TesteCrmEducacionalDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL"), b => b.MigrationsAssembly("Teste.CrmEducacional.Api")));

    builder.Services.AddScoped<ICandidatoRepository,CandidatoRepository>();
    builder.Services.AddAutoMapper(typeof(EntitiesToDtoMappings));

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

app.Run();
