using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public class Car : Sellable
	{
		#region Constructors
		public Car(string carName) : base(carName)
		{
		}
		#endregion

		public override decimal Price
		{
			get { return 15000M; }
		}
	}
}
