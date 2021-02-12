using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Extensions
{
	public static class ReflectionExtension
	{
		public static string GetPropertyValue<T>(this T item, string propertyName)
		{
			var output = item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
			return output;
		}

		public static string Feed<T>( this T dog ,float num)
		{
			return num.ToString();
		}
	}
}
