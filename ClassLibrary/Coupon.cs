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
		private decimal price;
		#endregion

		#region Constructors
		public Coupon(string couponCode, decimal price, Sellable item) : base("Coupon", item)
		{
			this.couponCode = couponCode;
			this.price = price;
		}
		#endregion

		public override decimal Price
		{
			get { return -100; }
		}
	}
}
