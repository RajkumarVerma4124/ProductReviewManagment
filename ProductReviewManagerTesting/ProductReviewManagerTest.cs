using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagerTesting
{
    [TestClass]
    public class ProductReviewManagerTest
    {
        public List<ProductReview> reviewList;
        //Method to initialize objects
        [TestInitialize]
        public void SetUp()
        {
            reviewList = new List<ProductReview>();
        }

        //Method to test add product review to list and return product review count(UC1-TC1.1)
        [TestMethod]
        public void TestMethodForAddProductReviewToList()
        {
            int expected = 25;
            var actual = ProductReviewManager.AddProductReviewToList(reviewList);
            Assert.AreEqual(actual.Count, expected);
        }
    }
}
