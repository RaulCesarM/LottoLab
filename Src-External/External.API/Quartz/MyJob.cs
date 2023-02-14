using Quartz;

namespace External.API.Quartz
{
   public class MyJob : IJob
{
    private readonly ILogger<MyJob> _logger;

    public MyJob(ILogger<MyJob> logger)
    {
        _logger = logger;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation("MyJob is running...");
        await Task.CompletedTask;
    }
}
}