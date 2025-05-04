using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    // Property to track if the recipe requires cooking
    internal class FoodRecipe : Recipe
    {
        public bool RequiresCooking {  get; set; }

        // Constructor for the FoodRecipe
        public FoodRecipe(string name, string category, int prepTime, string ingredients, string submittedBy, bool requiresCooking)
            : base(name, category, prepTime, ingredients, submittedBy)

        { RequiresCooking = requiresCooking; }

        public override string Display()
        {
            // Print out the parent display details and add a requires cooking value
            return base.Display() + " - Requires Cooking: " + RequiresCooking.ToString();
        }

        public override string Display(int num)
        {
            if (num == 2)
            {
                return Name + "(" + Category + ")";
            }
            else
            {
                return Name + " - Requires Cooking: " + RequiresCooking.ToString();
            }
        }
    }
}
