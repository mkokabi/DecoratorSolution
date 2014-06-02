using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public class Sale
	{
		#region Private fields
		private Sellable[] items;
		private DateTime saleDate;
		#endregion

		#region Constructors
		public Sale(DateTime saleDate, params Sellable[] items)
		{
			this.items = items;
			this.saleDate = saleDate;
		}
		#endregion

		#region Public properties
		public decimal TotalPrice
		{
			get
			{
				return this.items.Sum(i => i.Price);
			}
		}

		public int ItemsCount
		{
			get
			{
				return this.items.Count();
			}
		}
		#endregion
	}
}
