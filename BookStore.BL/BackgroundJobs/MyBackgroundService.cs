using Amazon.Util.Internal.PlatformServices;
using BookStore.Models.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.BackgroundJobs
{
    public class MyBackgroundService : BackgroundService
    {
        private IOptions<Appsettings> _appsettings;

        public MyBackgroundService(IOptions<Appsettings> appsettings) 
        {
            _appsettings = appsettings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while(!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"{nameof(MyBackgroundService)}-{DateTime.Now}");
                await Task.Delay(_appsettings.Value.DelayInterval, stoppingToken);
            }

           
        }
    }
}
