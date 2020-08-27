using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionDemo
{
    public static class TimerTrig
    {
        [FunctionName("TimerTrig")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            //https://youtu.be/HJRrWy0Edjs
            //https://arminreiter.com/2017/02/azure-functions-time-trigger-cron-cheat-sheet/
            //log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            //log.LogInformation($"C# Timer trigger function completed at: {DateTime.Now}");
            log.LogInformation($"Rakshan executed at: {DateTime.Now}");
            Action<int> print = (p) => { for (int i = 0; i < p; i++) Console.WriteLine("Rakshan Sah"); };
            print(5);
            log.LogInformation($"Priyangi completed at: {DateTime.Now}");
        }
    }
}
