using External.API.Controllers;
using Quartz;

namespace External.API.Quartz
{
    public class ExampleJob : IJob
    {
        private readonly ISeedController _seed;
        public ExampleJob(ISeedController seed)
        {
            _seed = seed;
        }
        public Task Execute(IJobExecutionContext context)
        {
           
           _seed.Consumption();
            Console.WriteLine("Hello, Quartz.NET!");
             return Task.CompletedTask;


        }
    }
}