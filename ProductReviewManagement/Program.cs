using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        //Declaring variable
        public static List<ProductReview> productList;
        //Entry of the main program
        public static void Main(string[] args)
        {
            //Displaying welcome message
            Console.WriteLine("Welcome To The Product Review Management Program");
            //Creating object of product review
            List<ProductReview> products = new List<ProductReview>();
            try
            {
                while(true)
                {
                    Console.WriteLine("1: Add Product Review To List \n2: Show All Product Review \n3: Retreive Top 3 Ratings Record \n4: Retreive Records Based On Rating And Product Id"+
                        "\n5: Count Product Id \n6: Retrieve ProductId And Review \n7: Retreive All Records By Skipping Top 5 \n8: Create DataTable And Add Values \n9: Retreive datatable records where islike is true"+
                        "\n10: Average Rating Based On ProductId \n11: Retrieve Good Records \n12: Exit");
                    Console.Write("Enter a choice from above : ");
                    bool flag = int.TryParse(Console.ReadLine(), out int choice);
                    if(flag)
                    {
                        switch (choice)
                        {
                            case 1:
                                //Calling the method of adding product review to list(UC1)
                                productList = ProductReviewManager.AddProductReviewToList(products);
                                break;
                            case 2:
                                //Calling the method to show the product review list(UC1)
                                ProductReviewManager.IterateOverList(productList);
                                break;
                            case 3:
                                //Calling the method to retrieve top 3 ratings records(UC2)
                                ProductReviewManager.RetrieveTopThreeRatingsRecord(productList);
                                break;
                            case 4:
                                //Calling the method to retrieve records based on rating and product id(UC3)
                                ProductReviewManager.RetrieveParticularRecords(productList);
                                break;
                            case 5:
                                //Calling the method to retrieve product id and there count(UC4)
                                ProductReviewManager.RetrieveProductIdCount(productList);
                                break;
                            case 6:
                                //Calling the method to retrieve product id and review(UC5 && UC7)
                                ProductReviewManager.RetrieveProductIdAndReview(productList);
                                ProductReviewManager.RetrieveProductIdAndReviewBySelect(productList);
                                break;
                            case 7:
                                //Calling the method to retrieve all products records by skiping top 5(UC6)
                                ProductReviewManager.SkipTopFiveRecords(productList);
                                break;
                            case 8:
                                //Calling the method to create datatable and add values(UC8)
                                ProductReviewManager.CreateDataTable(productList);
                                break;
                            case 9:
                                //Calling the method to show datatable rows where islike is true(UC9)
                                ProductReviewManager.RetreiveRecordsBasedOnIsLike(productList);
                                break;
                            case 10:
                                //Calling the method to show average ratings based on productid(UC10)
                                ProductReviewManager.GetAverageRatingsBasedOnPId(productList);
                                break;
                            case 11:
                                //Calling the method to get good records based on reviews(UC11)
                                ProductReviewManager.GetGoodRatingsRecordsFromTable(productList);
                                break;
                            case 12:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Wrong choice choose again");
                                continue;
                        }
                    }
                    else
                        Console.WriteLine("Enter some choice"); 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
