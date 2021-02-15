using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
	public class MenuItem
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public string Description { get; set; }

		public string Spicyness { get; set; }
		public enum ESpicy { 
			[Display(Name = @"N/A")]
			NA=0,
			[Display(Name = "Mild")]
			Mild =1,
			[Display(Name = "Spicy")]
			Spicy =2,
			[Display(Name = "Very Spicy")]
			VerySpicy =3
		}

		public string Image { get; set; }
		
		[Display(Name="Category")]
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }

		[Display(Name = "SubCategory")]
		public int SubCategoryId { get; set; }

		[ForeignKey("SubCategoryId")]
		public virtual SubCategory SubCategory { get; set; }

		[Range(0.1f, int.MaxValue, ErrorMessage = " Price should be greater than ${1}")]
		public double Price { get; set; }

		public string DisplayPrice { get => Price.ToString("n2"); }
	}
}
