using Spice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Utilities
{
	public static class StaticDetails
	{
		public const string DEFAULT_FOOD_IMAGE = "default_food.png";

		// User Roles
		public const string ManagerUser = "Manager";
		public const string KitchenUser = "Kitchen";
		public const string FrontDeskUser = "FrontDesk";
		public const string CustomerEndUser = "Customer";

		public const string StatusSubmitted = "Submitted";
		public const string StatusInProcess = "Being Prepared";
		public const string StatusReady = "Ready for Pickup";
		public const string StatusCompleted = "Completed";
		public const string StatusCancelled = "Cancelled";

		public const string PaymentStatusPending = "Pending";
		public const string PaymentStatusApproved = "Approved";
		public const string PaymentStatusDeclined = "Declined";

		public const string SecretKey = "SecretKey";

		public static string ConvertToRawHtml(string source)
		{
			var charArray = new char[source.Length];
			int arrayIndex = 0;
			bool inside = false;

			for (int i = 0; i < source.Length; i++)
			{
				char let = source[i];

				if (let == '<')
				{
					inside = true;
					continue;
				}
				else if (let == '>')
				{
					inside = false;
					continue;
				}

				if (!inside)
				{
					charArray[arrayIndex] = let;
					arrayIndex++;
				}
			}

			return new string(charArray, 0, arrayIndex);
		}

		public static double DiscountedPrice(Coupon couponFromDb, double originalOrderTotal)
		{
			if (couponFromDb == null)
				return originalOrderTotal;

			if (couponFromDb.MinimumAmount > originalOrderTotal)
				return originalOrderTotal;

			// Dollar Discount
			if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Dollar)
				return Math.Round(originalOrderTotal - couponFromDb.Discount, 2);

			// Percentage Discount
			if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Percent)
				return Math.Round(originalOrderTotal - (originalOrderTotal* couponFromDb.Discount/100f), 2);

			return originalOrderTotal;
		}
	}
}
