﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
	public abstract class Incentive : Sellable
	{
		#region Private fields
		private Sellable refItem;
		private decimal price;
		#endregion

		#region Constructors
		public Incentive(string incentiveName, Sellable item)
			: base(incentiveName)
		{
			this.refItem = item;
			this.price = price;
		}
		#endregion
	}
}
