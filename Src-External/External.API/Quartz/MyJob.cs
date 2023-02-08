
using External.Domain.Interfaces.IServices;
using Quartz;

namespace External.API.Quartz
{
    public class MyJob : IJob
    {
        private readonly ILotoFacilService _lotoService;
        private readonly ILotoFacilFeedService _FeedService;
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.Cancel(false);
                var final = await _FeedService.CheckLast();


            }
            catch (Exception e)
            {
                throw new Exception("erro", e);
            }
            await Task.CompletedTask;

        }

    }
}