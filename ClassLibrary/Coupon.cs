using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public class Coupon : Incentive
	{
		#region Private fields
		private string couponCode;
		#endregion

		#region Constructors
		public Coupon(string couponCode, Sellable item) : base("Coupon", item)
		{
			this.couponCode = couponCode;
		}
		#endregion

		public override decimal Price
		{
			get { return -100; }
		}
	}
}
