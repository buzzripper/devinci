using Devinci.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Devinci
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			var configuration = BuildConfiguration();
			var appConfig = GetAppConfig(configuration);
			var host = CreateHostBuilder(configuration, appConfig).Build();

			ApplicationConfiguration.Initialize();

			Application.Run(host.Services.GetRequiredService<Form1>());
		}

		private static IConfiguration BuildConfiguration()
		{
			// Configuration
			return new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
				.Build();
		}

		private static AppConfig GetAppConfig(IConfiguration configuration)
		{
			var appConfig = configuration.GetSection("AppConfig").Get<AppConfig>();
			if (appConfig == null)
				throw new ApplicationException("Unable to retrieve ApplicationConfig section from appsettings.json file.");

			return appConfig;
		}

		private static IHostBuilder CreateHostBuilder(IConfiguration configuration, AppConfig appConfig)
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices(services =>
				{
					services.AddSingleton<Form1>(serviceProvider =>
					{
						return new Form1(appConfig, serviceProvider.GetRequiredService<IHttpClientFactory>());
					});

					services.AddHttpClient();
				});
		}
	}
}
