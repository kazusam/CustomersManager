using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CustomersManager.API
{
    public class GETHealthChecks : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://localhost:44392/api/Customer");

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return (HealthCheckResult.Healthy("API online"));
            else
                return (HealthCheckResult.Unhealthy("API offline"));
        }
    }
}