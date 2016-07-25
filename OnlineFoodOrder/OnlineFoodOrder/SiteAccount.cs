using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVegeFoodOrder
{
    /// <summary>
    /// This class defines Site Account 
    /// </summary>
    public class SiteAccount
    {
        #region Properties
        /// <summary>
        /// Account Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account Email Address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Real Address
        /// </summary>
        public string Address { get; set; }
        #endregion

        #region Methods
        public void AddFoodItem(string foodName, string flavor, string[] ingredients)
        {
            var foodItem = new FoodItem { FoodName = foodName, Flavor = flavor, Ingredients = ingredients };


        }
        #endregion
    }
}
