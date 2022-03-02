using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    /// <summary>
    /// Created Class For Declaring Product Review Properties(UC1)
    /// </summary>
    public class ProductReview
    {
        //Declaring properties
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        //Method to override tostring
        public override string ToString()
        {
            return $"Product Id : {ProductId}  \tUser Id : {UserId}  \tProduct Rating : {Rating}  \tProduct Review : {Review}    \tIsLike : {IsLike}";
        }
    }
}
