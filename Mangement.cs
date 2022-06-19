using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_review_management
{
   public class management
    
        /// <summary>
        /// UC2
        /// <\summary>
        /// <param  name="listProductReview"></param>
        // public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)

        {

            var recordedData = (from productReviews in listProductReview

                                orderby productReviews.Rating descending

                                select productReviews).Take(3);




            foreach (var list in recordedData)

            {

                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID

                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);

            }



        }

    /// <summary>
    /// UC3
    /// <\summary>
    /// <param  name="listProductReview"></param>

    public void SelectedRecords(List<ProductReview> listProductReview)

        {

            var recordedData = from productReviews in listProductReview

                               where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)

                               && productReviews.Rating > 3

                               select productReviews;

            //Console.WriteLine(recordedData);

            foreach (var list in recordedData)

            {

                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID

                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);

            }


        }



    /// <summary>
    /// UC4
    /// <\summary>
    /// <param  name="listProductReview"></param>
    public void RetrieveCountOfRecords(List<ProductReview> listProductReview)

        {

            var recordedData = listProductReview.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });




            foreach (var list in recordedData)

            {

                Console.WriteLine(list.ProductID + "--------" + list.Count);


            }

        /// <summary>
        /// UC5
        /// <\summary>
        /// <param  name="listProductReview"></param>
        public void RetrievelLIstOfRecords(List<ProductId> listProductId)

        {

            var recordedData = listProductId.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });




            foreach (var list in recordedData)

            {

                Console.WriteLine(list.ProductID + "--------" + list.Count);


            }

        }
        /// <summary>
        /// UC6
        /// <\summary>
        /// <param  name="listProductReview"></param>
        public void RetrieveTopOf5Records(List<ProductReview> listProductReview)

        {

            var recordedData = listTopOf5Records.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });




            foreach (var list in recordedData)

            {

                Console.WriteLine(list.ProductTopOf5ID+ "--------" + list.Count);


            }


        }
}
