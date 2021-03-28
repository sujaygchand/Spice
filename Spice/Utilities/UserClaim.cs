using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Spice.Utilities
{
	public class UserClaim
	{

		public Claim GetClaim(IIdentity identity)
		{

			var claimsIdentity = (ClaimsIdentity)identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
			return claim;
		}
	}
}
