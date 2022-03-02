﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        //Method to test that top 3 records from  the list based on rating is retrieved or not(UC2-TC2.1)
        [TestMethod]
        public void GivenListReturnTopThreeRatingsRecords()
        {
            int expected = 3;
            var actual = ProductReviewManager.RetrieveTopThreeRatingsRecord(resProductReviewList);
            Assert.AreEqual(actual.Count, expected);
        }
    }
}
