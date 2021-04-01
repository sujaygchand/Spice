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
	}
}
