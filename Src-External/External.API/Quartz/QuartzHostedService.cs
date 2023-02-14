using External.API.Controllers;
using Quartz;
using Quartz.Impl;


namespace External.API.Quartz
{

    public class QuartzHostedService : IHostedService
    {
        private readonly IScheduler _scheduler;

        public QuartzHostedService()
        {
            var schedulerFactory = new StdSchedulerFactory();
            _scheduler = schedulerFactory.GetScheduler().Result;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var jobType = typeof(FeedJob);
            var jobKey = new JobKey(jobType.Name);

            var trigger = TriggerBuilder.Create()
                .WithIdentity("LotoFacilFeedTrigger")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithInterval(TimeSpan.FromSeconds(1))
                    .RepeatForever())
                .Build();

            var jobDetail = JobBuilder.Create(jobType)
                .WithIdentity(jobKey)
                .Build();

            _scheduler.ScheduleJob(jobDetail, trigger).Wait();
            _scheduler.Start().Wait();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return _scheduler.Shutdown();
        }

    }
}