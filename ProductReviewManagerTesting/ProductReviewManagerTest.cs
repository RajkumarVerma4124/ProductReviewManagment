using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagerTesting
{
    [TestClass]
    public class ProductReviewManagerTest
    {
        public List<ProductReview> reviewList, resProductReviewList;
        //Method to initialize objects
        [TestInitialize]
        public void SetUp()
        {
            reviewList = new List<ProductReview>();
            resProductReviewList = ProductReviewManager.AddProductReviewToList(reviewList);
        }

        //Method to test add product review to list and return product review count(UC1-TC1.1)
        [TestMethod]
        public void GivenListAddProductReviewToList()
        {
            int expected = 25;
            Assert.AreEqual(resProductReviewList.Count, expected);
        }

        //Method to test the count of top 3 records from the list based on rating(UC2-TC2.1)
        [TestMethod]
        public void GivenListReturnTopThreeRatingsRecords()
        {
            int expected = 3;
            var actual = ProductReviewManager.RetrieveTopThreeRatingsRecord(resProductReviewList);
            Assert.AreEqual(actual.Count, expected);
        }

        //Method to test the count of records from the list based on rating and product id(UC3-TC3.1)
        [TestMethod]
        public void GivenListReturnParticularRecords()
        {
            int expected = 6;
            var actual = ProductReviewManager.RetrieveParticularRecords(resProductReviewList);
            Assert.AreEqual(actual.Count, expected);
        }

        //Method to test the count of product id count(UC4-TC4.1)
        [TestMethod]
        public void GivenListReturnProductIdCount()
        {
            int expected = 11;
            var actual = ProductReviewManager.RetrieveProductIdCount(resProductReviewList);
            Assert.AreEqual(actual, expected);
        }
    }
}
