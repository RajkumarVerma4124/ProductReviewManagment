using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    /// <summary>
    /// Created The Class For Product Review Manager To Manage Reviews Of Different Product
    /// </summary>
    public class ProductReviewManager
    {
        //Method to add the product review into the list(UC1)
        public static List<ProductReview> AddProductReviewToList(List<ProductReview> products)
        {
            try
            {
                //Adding 25 entries to list
                products.Add(new ProductReview() { ProductId = 1, UserId = 2, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 2, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 3, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 8, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 6, UserId = 6, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new ProductReview() { ProductId = 7, UserId = 9, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 15, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 9, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 5, UserId = 3, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 7, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 5, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 11, UserId = 6, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 1, UserId = 7, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 8, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 9, UserId = 12, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 13, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 10, UserId = 14, Review = "Average", Rating = 3, IsLike = false });
                Console.WriteLine("Added The Products Review To The List Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

        //Method to iterate over the list(UC1)
        public static void IterateOverList(List<ProductReview> products)
        {
            try
            {
                if(products != null)
                {
                    foreach (ProductReview product in products)
                    {
                        Console.WriteLine(product);
                    }
                } 
                else
                    Console.WriteLine("No Products Review Added In The List");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to retrieve top 3 records from  the list based on rating(UC2)
        public static List<ProductReview> RetrieveTopThreeRatingsRecord(List<ProductReview> products)
        {
            //Using Linq sort product list in descending order and take first 3 elements
            if( products != null)
            {
                var productRating = products.OrderByDescending(p => p.Rating).Take(3).ToList();
                Console.WriteLine("\nPrinting Top 3 Products Reviews Records Based On Rating");
                IterateOverList(productRating);
                return productRating;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }            
        }
    }
}
