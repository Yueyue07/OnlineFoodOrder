using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVegeFoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new SiteAccount { Name = "Yue", Email = "yueyue.qin1007@gmail.com", Address = "Seattle,WA" };
            account.AddFoodItem("Rice Noodle", "Spicy");
            Console.WriteLine(account.FoodItemList);
            Console.ReadLine();
        }
    }
}