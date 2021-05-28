using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Spice.Utilities;
using Stripe;
using File = System.IO.File;

namespace Spice
{
	public class Program
	{
		public static void Main(string[] args)
		{
			InitlialiseEnv();
			CreateHostBuilder(args).Build().Run();
		}
		
		public static void InitlialiseEnv()
		{
			string filePath = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), ".env");
			
			if (!File.Exists(filePath))
				return;

			foreach (var line in File.ReadAllLines(filePath))
			{
				var parts = line.Split(
					'=',
					StringSplitOptions.RemoveEmptyEntries);

				if (parts.Length != 2)
					continue;

				Environment.SetEnvironmentVariable(parts[0].Trim(), parts[1].Trim());
			}
			
			StripeConfiguration.ApiKey = StripeSettings.SecretKey;
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
