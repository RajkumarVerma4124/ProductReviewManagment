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
                    Console.WriteLine("1: Add Product Review To List \n2: Show All Product Review \n3: Retreive Top 3 Ratings Record \n4: Exit");
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
