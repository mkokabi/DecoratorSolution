using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public class Spoiler : Feature
	{
		#region Constructors
		public Spoiler(string spoilerName, decimal price, Sellable item)
			: base(spoilerName, price, item)
		{
		}
		#endregion

		public override decimal Price
		{
			get { return 500M; }
		}
	}
}
