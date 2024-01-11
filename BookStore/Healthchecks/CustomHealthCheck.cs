using BookStore.BL.Interfaces;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStore.BL.Services
{

    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
           HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = true;

            // ...

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}

