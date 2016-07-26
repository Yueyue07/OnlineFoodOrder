using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVegeFoodOrder
{
    public class FoodItem
    {
        #region Properties
        /// <summary>
        /// Food Item Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of this food item
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// Flavor Of this Food
        /// </summary>
        public string Flavor { get; set; }
        /// <summary>
        /// Ingredients of this food
        /// </summary>
       // public string[] Ingredients { get; set; } // Check Array Properties in C#
        #endregion

        #region Static Variable
        private static int lastId = 0;
        #endregion

        /// <summary>
        /// Constructor of FoodItem to Generate Id for createc food item
        /// </summary>
        #region Constructor
        public FoodItem()
        {
            Id = ++lastId;
        }
        #endregion
    }
}
