using LotoCharts.Domain.Interfaces.Utilities;

namespace LotoCharts.Worker;

public class LotoFacilWorker : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    public LotoFacilWorker(ILogger<LotoFacilWorker> logger, IServiceScopeFactory scopeFactory, IConfiguration configuration)
    {
        _scopeFactory = scopeFactory;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                try
                {
                    var supplyLotoFacil = scope.ServiceProvider.GetRequiredService<ISupplyLotoFacil>();
                    var lastRaffle = await supplyLotoFacil.CheckLast();
                    string message = $"[{DateTime.Now}] concurso atual no banco nº  {lastRaffle}";
                    Log(message);
                }
                catch (Exception ex)
                {
                    string message = $"[{DateTime.Now}] Erro:  {ex}";
                    Log(message);
                }
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
    public static void Log(string message)
    {
        string logPath = "Log/log.txt";
        using (StreamWriter streamWriter = new StreamWriter(logPath, true))
        {
            streamWriter.WriteLine($"{DateTime.Now.ToString()} {message}");
        }
    }
}


