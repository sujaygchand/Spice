using Spice.Utilities;

namespace Spice.Service
{
	public class EmailOptions
	{
		public string SendGridKey => SessionDetails.SendGridKey;
	}
}