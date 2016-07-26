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
        /// <summary>
        /// Food Iterm List
        /// </summary>
        public List<FoodItem> FoodItemList = new List<FoodItem>(); // Check List Property

        #region Static Variable
        private static int lastID = 0;
        #endregion

        #region Constructor
        public SiteAccount() {
            Id = ++lastID;
        }
        #endregion

        #region Methods
        public void AddFoodItem(string foodName, string flavor)
        {
            var foodItem = new FoodItem { FoodName = foodName, Flavor = flavor};

            FoodItemList.Add(foodItem);
        }

        #endregion
    }
}
