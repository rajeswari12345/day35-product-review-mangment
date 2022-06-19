// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
namespace ProductReviewMangementWithLinq
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Welcome to product review managment problems statement");
                List<ProductReview> productReviewList = new List<ProductReview>()

            {

                new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",isLike=true},

                new ProductReview(){ProducID=2,UserID=1,Rating=4,Review="Good",isLike=true},

                new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",isLike=true},

                new ProductReview(){ProducID=4,UserID=1,Rating=6,Review="Good",isLike=false},

                new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="nice",isLike=true},

                new ProductReview(){ProducID=6,UserID=1,Rating=1,Review="bas",isLike=true},

                new ProductReview(){ProducID=8,UserID=1,Rating=10,Review="Good",isLike=false},

                new ProductReview(){ProducID=8,UserID=1,Rating=9,Review="nice",isLike=true},

                new ProductReview(){ProducID=2,UserID=1,Rating=10,Review="nice",isLike=true},

                new ProductReview(){ProducID=10,UserID=1,Rating=8,Review="nice",isLike=true}
                };

             foreach (var list in productReviewList)

            {

                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID

                  + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
            //UC2

            Management management = new Management();

            management.TopRecords(productReviewList);



            //UC3

            management.SelectedRecords(productReviewList);


            //UC4

            management.RetrieveCountOfRecords(productReviewList);

            Console.ReadKey();
            //UC5

            management.RetrieveListOfRecords(productReviewList);

            Console.ReadKey();
            //UC6

            management.RetrieveTopOf5Records(productReviewList);

            Console.ReadKey();


        }

    }
}