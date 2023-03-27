using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35LinqOperation
{
  public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem ");

            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductId =1, UserId=1, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=1, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =3, UserId=2, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =4, UserId=2, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =5, UserId=3, Rating=2, Review= "Bad", isLike=true},
                new ProductReview() {ProductId =6, UserId=4, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =7, UserId=3, Rating=6, Review= "Good", isLike=true},
                new ProductReview() {ProductId =8, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =9, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =10, UserId=10, Rating=2, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =11, UserId=10, Rating=3, Review= "Nice", isLike=true},
                new ProductReview() {ProductId =12, UserId=10, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =13, UserId=10, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =14, UserId=10, Rating=3, Review= "Nice", isLike=true}
            };

           

            Managment management = new Managment();
          
         //  management.SelectedRowRecordList(productReviews);
            management.RetriveRecordUsingEquals(productReviews);




        }
    }
}
