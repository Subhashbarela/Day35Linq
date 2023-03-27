using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35LinqOperation
{
    public class LinqToDataTable
    {
        public void AddDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("isLike");

            dt.Rows.Add("1","1","5", "good", true);
            dt.Rows.Add("2", "1", "5", "good", true);
            dt.Rows.Add("3", "1", "6", "bad", true);
            dt.Rows.Add("4", "2", "5", "good", false);

            DisplayProduct(dt);
        }
        public void DisplayProduct(DataTable dt)
        {
            var productName = from product in dt.AsEnumerable() select product.Field<string>("productName");
            Console.WriteLine("productName");
            foreach(string item in productName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
