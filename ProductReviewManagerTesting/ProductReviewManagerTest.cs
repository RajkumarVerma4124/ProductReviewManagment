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

        //Method to test the count of product id and review(UC5-TC5.1)
        [TestMethod]
        public void GivenListReturnProductIdAndReviewCount()
        {
            int expected = 25;
            var actual = ProductReviewManager.RetrieveProductIdAndReview(resProductReviewList);
            Assert.AreEqual(actual, expected);
        }

        //Method to test the count of products by skipping top 5 records(UC6-TC6.1)
        [TestMethod]
        public void GivenListReturnCountAfterSkipRecords()
        {
            int expected = 20;
            var actual = ProductReviewManager.SkipTopFiveRecords(resProductReviewList);
            Assert.AreEqual(actual.Count, expected);
        }

        //Method to test the create datatable method and count 25 values added or not(UC8-TC8.1)
        [TestMethod]
        public void GivenListCreateDatatable()
        {
            int expected = 25;
            var actual = ProductReviewManager.CreateDataTable(resProductReviewList);
            Assert.AreEqual(actual.Rows.Count, expected);
        }

        //Method to test the count of datatable records where islike is true(UC9-TC9.1)
        [TestMethod]
        public void GivenTableReturnDtblRecordsBasedOnIsLike()
        {
            int expected = 15;
            var actual = ProductReviewManager.RetreiveRecordsBasedOnIsLike(resProductReviewList);
            Assert.AreEqual(actual, expected);
        }

        //Method to test the average ratings based on product id(UC10-TC10.1)
        [TestMethod]
        public void GivenTableReturnTotalAverageRatings()
        {
            double expected = 40.99;
            var actual = ProductReviewManager.GetAverageRatingsBasedOnPId(resProductReviewList);
            Assert.AreEqual(actual, expected);
        }
    }
}
