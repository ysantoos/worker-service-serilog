namespace Worker_Service_Serilog
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("You can see this message in the Azure Application Insights trace", DateTimeOffset.Now);
                await Task.Delay(120000, stoppingToken);
            }
        }
    }
}
