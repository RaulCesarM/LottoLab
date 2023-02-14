// using System.Text.Json;
// using System.Text.Json.Serialization;
// using External.API.Quartz;
// using External.Di.IOC;
// using External.Infra.Context;
// using Microsoft.AspNetCore.Mvc.Formatters;

// var builder = WebApplication.CreateBuilder(args);
// RepositoryIOC.RegisterServices(builder.Services);
// builder.Services.AddControllers()
//                 .AddJsonOptions(options =>
//                   {
//                       options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
//                       options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
//                   })
//                 .AddJsonOptions(x =>
//                 x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
//                 );



// //builder.Services.AddHostedService<QuartzHostedService>();                
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
// builder.Services.AddMvc(config =>
// {
//     config.ReturnHttpNotAcceptable = true;
//     config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
//     config.InputFormatters.Add(new XmlSerializerInputFormatter(config));
// });
// builder.Services.AddDbContext<LotoChartsContext>();
// var app = builder.Build();
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
// app.UseCors(opcoes => opcoes.AllowAnyOrigin()
//                         .AllowAnyMethod()
//                         .AllowAnyHeader());
// //app.UseHttpsRedirection();
// app.UseAuthentication();
// app.UseAuthorization();
// app.MapControllers();
// app.Run();



using System;
using System.Threading.Tasks;
using External.API.Quartz;
using External.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Impl;

namespace External.API
{
   class Program
    {
        static async Task Main(string[] args)
        {
            var scheduler = await GetScheduler();
            await ScheduleJob(scheduler);
        }

        private static async Task<IScheduler> GetScheduler()
        {
            var schedulerFactory = new StdSchedulerFactory();
            return await schedulerFactory.GetScheduler();
        }

        private static async Task ScheduleJob(IScheduler scheduler)
        {
          //  var feedService = new LotoFacilFeedService(); // Use a injeção de dependência aqui caso esteja disponível.
            var job = JobBuilder.Create<FeedJob>()
                .WithIdentity("LotoFacilFeedJob")
                .Build();

            var trigger = TriggerBuilder.Create()
                .WithIdentity("LotoFacilFeedTrigger")
                .WithCronSchedule("*/2 * * * * ?") // agendar a cada 2 segundos
                .Build();

            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();

         //   await feedService.CheckLast(); // O job será executado automaticamente depois disso.
        }
    }
}