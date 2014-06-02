using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohsenApp.DecoratorSolution.ClassLibrary
{
    public abstract class Sellable
	{
		#region Constructors
		public Sellable(string name)
		{
			this.Name = name;
		}
		#endregion

		public string Name { get; private set; }

		public abstract decimal Price { get; }
			
    }
}
