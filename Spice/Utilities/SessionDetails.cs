using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Utilities
{
	public static class SessionDetails
	{
		public const string SS_SHOPPING_CART_COUNT = "ssCartCount";
		public const string SS_COUPON_CODE = "ssCouponCode";

		/* Facebook details */
		public static string FacebookAppId => Environment.GetEnvironmentVariable(FACEBOOK_APP_ID);
		public static string FacebookSecretKey => Environment.GetEnvironmentVariable(FACEBOOK_SECRET_KEY_NAME);

		private const String FACEBOOK_APP_ID = "FACEBOOK__APPID";
		private const String FACEBOOK_SECRET_KEY_NAME = "FACEBOOK__SECRETKEY";

		/* Goggle Details */
		public static string GoogleClientId => Environment.GetEnvironmentVariable(GOOGLE_CLIENT_ID);
		public static string GoogleSecretKey => Environment.GetEnvironmentVariable(GOOGLE_SECRET_KEY);

		private const String GOOGLE_CLIENT_ID = "GOOGLE__CLIENTID";
		private const String GOOGLE_SECRET_KEY = "GOOGLE__SECRETKEY";
		
		/* Send Grid, used for sending emails */
		public static string SendGridKey => Environment.GetEnvironmentVariable(SEND_GRID_KEY);

		private const String SEND_GRID_KEY = "SENDGRID__KEY";
	}
}
