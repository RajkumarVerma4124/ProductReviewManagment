using System;
using System.Collections.Generic;
using System.Data;
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
                products.Add(new ProductReview() { ProductId = 2, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 8, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 6, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new ProductReview() { ProductId = 7, UserId = 9, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 1, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 9, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 11, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 2, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 5, UserId = 3, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 7, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 5, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 11, UserId = 6, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 1, UserId = 7, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 8, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 10, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 9, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 10, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
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
                if (products != null)
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
            if (products != null)
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

        //Method to retrieve records from the list based on rating and product id(UC3)
        public static List<ProductReview> RetrieveParticularRecords(List<ProductReview> products)
        {
            //Using Linq retreiving particular records
            if (products != null)
            {
                var resProductList = (from product in products where (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product).ToList();
                Console.WriteLine("\nPrinting Records Based On Rating And ProductId");
                IterateOverList(resProductList);
                return resProductList;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }
        }

        //Method to retrieve count of review present for each product id records from the list (UC4)
        public static int RetrieveProductIdCount(List<ProductReview> products)
        {
            //Using Linq retreive product id count records
            if (products != null)
            {
                int pCount = 0;
                var resProductCount = products.GroupBy(x => x.ProductId).Select(p => new { productId = p.Key, count = p.Count() });
                Console.WriteLine("\nPrinting Count Of Product Review Based On Product Id");
                foreach (var product in resProductCount)
                {
                    Console.WriteLine($"Product Id : {product.productId}  \tProduct Count : {product.count}\n");
                    pCount++;
                }
                return pCount;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }
        }

        //Method to retrieve only productId and review from the list for all records(UC5)
        public static int RetrieveProductIdAndReview(List<ProductReview> products)
        {
            //Using Linq retreive only productId and review
            if (products != null)
            {
                int pCount = 0;
                var productList = products.Select(p => new { productId = p.ProductId, review = p.Review }).ToList();
                Console.WriteLine("\nPrinting Product Id and Product Review records");
                foreach (var product in productList)
                {
                    Console.WriteLine($"Product Id : {product.productId}  \tProduct Reviews : {product.review}");
                    pCount++;
                }
                return pCount;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }
        }

        //Method to retrieve all records by skipping top 5(UC6)
        public static List<ProductReview> SkipTopFiveRecords(List<ProductReview> products)
        {
            //Using Linq sort to sort rating in descending order and skip 5 elements
            if (products != null)
            {
                var resProductList = (from p in products orderby p.Rating descending select p).Skip(5).ToList();
                Console.WriteLine("Printing Records By Skipping Top 5 Records");
                IterateOverList(resProductList);
                return resProductList;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }
        }

        //Method to retrieve only productId and review from the list for all records by select (UC7)
        public static void RetrieveProductIdAndReviewBySelect(List<ProductReview> products)
        {
            //Using select to retreive records
            if (products != null)
            {
                var productList = from p in products select p;
                Console.WriteLine("\nPrinting Product Id and Product Review records by using select");
                foreach (var product in productList)
                    Console.WriteLine($"Product Id : {product.ProductId}  \tProduct Reviews : {product.Review}");
            }
            else
                Console.WriteLine("No Products Review Added In The List");
        }

        //Method to create data table and add values(UC8)
        public static DataTable CreateDataTable(List<ProductReview> products)
        {
            if (products != null)
            {
                //Initializing datatable
                DataTable dataTable = new DataTable();
                //Adding columns names to data table and thre type
                dataTable.Columns.Add("ProductId", typeof(int));
                dataTable.Columns.Add("UserId", typeof(int));
                dataTable.Columns.Add("Rating", typeof(double));
                dataTable.Columns.Add("Review", typeof(string));
                dataTable.Columns.Add("IsLike", typeof(bool));
                //Adding values to datatable
                foreach (var data in products)
                {
                    //adding rows from product list to data table rows
                    dataTable.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
                }
                Console.WriteLine("Added The Rows Successfully In The Table Columns");
                return dataTable;
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
                return default;
            }

        }

        //Method to retreive records where is like is true(UC9)
        public static int RetreiveRecordsBasedOnIsLike(List<ProductReview> products)
        {
            int rCount = 0;
            if(products != null)
            {
                DataTable dataTable = CreateDataTable(products);
                var resRows = from table in dataTable.AsEnumerable() where table.Field<bool>("IsLike") == true select table;
                Console.WriteLine($"ProductId \tUserId \t\tRating  \tReview    \tIsLike");
                foreach (var row in resRows)
                {
                    Console.WriteLine($"{row["ProductId"]} \t\t{row["UserId"]} \t\t{row["Rating"]}  \t\t{row["Review"]}    \t{row["IsLike"]}");
                    rCount++;
                }
                return rCount;
            }
            else
            {
                Console.WriteLine("No Products Review Found");
                return default;
            }           
        }

        //Method to retreive average rating based on id(UC10)
        public static double GetAverageRatingsBasedOnPId(List<ProductReview> products)
        {
            if (products != null)
            {
                double totalAverage = 0;
                DataTable dataTable = CreateDataTable(products);
                var resatingAverage = from columns in dataTable.AsEnumerable() group columns by columns.Field<int>("ProductId") into temp select new { productid = temp.Key, average = Math.Round(temp.Average(x => x.Field<double>("Rating")), 2) };
                foreach (var row in resatingAverage)
                {
                    Console.WriteLine("Product Id: {0} \tAverage Ratings: {1}", row.productid, row.average);
                    totalAverage += row.average;
                }
                return totalAverage;
            }
            else
            {
                Console.WriteLine("No Products Review Found");
                return default;
            }
        }

        //Method to retreive good rating based on reviews from datatable(UC11)
        public static double GetGoodRatingsRecordsFromTable(List<ProductReview> products)
        {
            if (products != null)
            {
                int rCount = 0;
                DataTable dataTable = CreateDataTable(products);
                var resRows = from table in dataTable.AsEnumerable() where table.Field<string>("Review").Contains("Very Good") || table.Field<string>("Review").Contains("Good") select table;
                Console.WriteLine($"ProductId \tUserId \t\tRating  \tReview    \tIsLike");
                foreach (var row in resRows)
                {
                    Console.WriteLine($"{row["ProductId"]} \t\t{row["UserId"]} \t\t{row["Rating"]}  \t\t{row["Review"]}    \t{row["IsLike"]}");
                    rCount++;
                }
                return rCount;
            }
            else
            {
                Console.WriteLine("No Products Review Found");
                return default;
            }
        }

        //Method to retreive records from datatable using userid(UC12)
        public static double GetRecordsBasedOnUserId(List<ProductReview> products, int userId)
        {
            if (products != null && userId < 12)
            {
                int rCount = 0;
                DataTable dataTable = CreateDataTable(products);
                var resRows = (from table in dataTable.AsEnumerable() where table.Field<int>("UserId") == userId orderby table.Field<double>("Rating") select table).ToList();
                Console.WriteLine($"ProductId \tUserId \t\tRating  \tReview    \tIsLike");
                foreach (var row in resRows)
                {
                    Console.WriteLine($"{row["ProductId"]} \t\t{row["UserId"]} \t\t{row["Rating"]}  \t\t{row["Review"]}    \t{row["IsLike"]}");
                    rCount++;
                }
                return rCount;
            }
            else
            {
                Console.WriteLine("No Products Review Found");
                return default;
            }
        }
    }
}
