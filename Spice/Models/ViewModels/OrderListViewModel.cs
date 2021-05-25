﻿using System.Collections.Generic;

namespace Spice.Models.ViewModels
{
	public class OrderListViewModel
	{
		public IList<OrderDetailsViewModel> Orders { get; set; }
		public PagingInfo PagingInfo { get; set; }
	}
}