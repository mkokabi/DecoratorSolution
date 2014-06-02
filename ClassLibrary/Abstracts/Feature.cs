using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public abstract class Feature : Sellable
	{
		#region Private fields
		private Sellable refItem;
		private decimal price;
		#endregion

		#region Constructors
		public Feature(string featureName, decimal price, Sellable item)
			: base(featureName)
		{
			this.refItem = item;
			this.price = price;
		}
		#endregion
	}
}
