using External.API.Quartz;
using External.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Quartz;
using Quartz.Impl;

namespace External.API.Controllers
{
  [ApiController]
    [Route("API/Seed")]
    public class SeedController : ControllerBase
    {
        private readonly IScheduler _scheduler;
        private readonly ILotoFacilFeedService _feedService;

        public SeedController(ILotoFacilFeedService feedService)
        {
            _feedService = feedService;
            _scheduler = new StdSchedulerFactory().GetScheduler().Result;
            _scheduler.Start();
            ScheduleJob();
        }

        private void ScheduleJob()
        {
            var job = JobBuilder.Create<FeedJob>()
                .WithIdentity("LotoFacilFeedJob")
                .Build();

            var trigger = TriggerBuilder.Create()
                .WithIdentity("LotoFacilFeedTrigger")
                .WithCronSchedule("*/2 * * * * ?") // agendar a cada 5 minutos
                .Build();

            _scheduler.ScheduleJob(job, trigger);
        }

        [HttpPost]
        public async Task Consumption()
        {
            try
            {
                await _feedService.CheckLast();
            }
            catch (Exception e)
            {
                throw new Exception("erro", e);
            }
        }

       
    }
}