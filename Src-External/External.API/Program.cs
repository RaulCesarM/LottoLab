using System.Text.Json;
using System.Text.Json.Serialization;
using External.API.Controllers;
using External.API.Quartz;
using External.Di.IOC;
using External.Infra.Context;
using Microsoft.AspNetCore.Mvc.Formatters;
using Quartz;
var builder = WebApplication.CreateBuilder(args);
RepositoryIOC.RegisterServices(builder.Services);
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                  {
                      options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                      options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                  })
                .AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
                );



                
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc(config =>
{
    config.ReturnHttpNotAcceptable = true;
    config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
    config.InputFormatters.Add(new XmlSerializerInputFormatter(config));
});
builder.Services.AddDbContext<LotoChartsContext>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(opcoes => opcoes.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
