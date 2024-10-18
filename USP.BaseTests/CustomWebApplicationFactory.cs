using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using MongoDB.Entities;

namespace USP.BaseTests;

public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    public CustomWebApplicationFactory()
    {
        Task.Run(async () =>
            {
                await DB.InitAsync("UspBazaZaTestiranje",
                    MongoClientSettings.FromConnectionString(
                        "mongodb+srv://markovojinovic21:JLw3RmDjAewAFbYh@cluster0-usp.d8raq.mongodb.net/"));
            })
            .GetAwaiter()
            .GetResult();
    }
    
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll(typeof(IHostedService));
        });
    }
}