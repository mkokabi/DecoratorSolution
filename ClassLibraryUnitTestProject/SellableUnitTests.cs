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

			var myIncentive1 = new Coupon("SUMMERSALE", -100M, myCar);
			Assert.AreEqual(-100M, myIncentive1.Price);
		}

		[TestMethod]
		public void CreateSaleAndShowTheTotalPrice_ExpectedTotalPrice()
		{
			var myCar = new Car("Camry");
			var myFeeature1 = new Spoiler("Spolier X", 500M, myCar);
			var myIncentive1 = new Coupon("SUMMERSALE", -100M, myCar);

			var aSale = new Sale(DateTime.Now, myCar, myFeeature1, myIncentive1);
			Assert.AreEqual(3, aSale.ItemsCount);
			Assert.AreEqual(15400M, aSale.TotalPrice);
		}
	}
}
