using External.Domain.Interfaces.IServices;
using Quartz;

namespace External.API.Quartz
{
    public class FeedJob : IJob
        {
            private readonly ILotoFacilFeedService _feedService;

            public FeedJob(ILotoFacilFeedService feedService)
            {
                _feedService = feedService;
            }

            public async Task Execute(IJobExecutionContext context)
            {
               await _feedService.CheckLast();
                Console.WriteLine("YEYE");
            }
        }
}