using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Utilities
{
	public static class StripeSettings
	{
		public static string SecretKey => Environment.GetEnvironmentVariable(SECRET_KEY_NAME);
		public static string PublishableKey => Environment.GetEnvironmentVariable(PUBLISHABLE_KEY_NAME);

		private const String SECRET_KEY_NAME = "STRIPE__SECRETKEY";
		private const String PUBLISHABLE_KEY_NAME = "STRIPE__PUBLISHABLEKEY";

	}
}
