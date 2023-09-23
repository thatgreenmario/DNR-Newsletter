using Quartz;

namespace Main.DNRDataFetcher
{
    public class FetchDNRDataJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Hello, Quartz.NET!");
            return Task.CompletedTask;
        }
    }
}
