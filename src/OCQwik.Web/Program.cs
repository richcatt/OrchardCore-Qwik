﻿using OrchardCore.Logging;

namespace OrchardCore_Qwik.Web
{
	public class Program
	{

		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureLogging(logging => logging.ClearProviders())
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseNLogWeb();
					webBuilder.UseStartup<Startup>();
				});
	}
}
