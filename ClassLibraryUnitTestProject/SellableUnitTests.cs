using Microsoft.VisualStudio.TestTools.UnitTesting;
using MohsenApp.DecoratorSolution.ClassLibrary;
using System;

namespace MohsenApp.DecoratorSolution.ClassLibraryUnitTestProject
{
	[TestClass]
	public class SellableUnitTests
	{
		[TestMethod]
		public void CreateSellabeItemsAndDecorateThemWithExtraFeatures_ExpectedPrice()
		{
			var myCar = new Car("Camry");
			Assert.AreEqual(15000M, myCar.Price);

			var myFeeature1 = new Spoiler("Spolier X", 500M, myCar);
			Assert.AreEqual(500M, myFeeature1.Price);

			var myIncentive1 = new Coupon("SUMMERSALE", myCar);
			Assert.AreEqual(-100M, myIncentive1.Price);
		}
	}
}
