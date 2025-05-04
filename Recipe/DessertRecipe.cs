using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class DessertRecipe : Recipe
    {
        // Property to track if the recipe requires baking
        public bool RequiresBaking { get; set; }

        // Constructor for the DesertRecipe
        public DessertRecipe(string name, string category, int prepTime, string ingredients, string submittedBy, bool requiresBaking)
            : base(name, category, prepTime, ingredients, submittedBy)
        
            { RequiresBaking = requiresBaking; }


        public override string Display()
        {
            // Print out the parent display details and add a requires baking value
            return base.Display() + " - Requires Baking: " + RequiresBaking.ToString();
        }

        public override string Display(int num)
        { 
            if(num == 2) 
            {
                return Name + "(" + Category + ")";
            }
            else
            {
                return Name + " - Requires Baking: " + RequiresBaking.ToString();
            }
        }
    }
}
