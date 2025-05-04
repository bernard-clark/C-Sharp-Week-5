using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class Recipe
    {
        // PrepTimeMinutes property
        private int prepTimeMinutes;
        // Name property
        public string Name { get; set; }
        // Category property
        public string Category { get; set; }
        // PrepTime property
        public int PrepTime
        {
            get { return prepTimeMinutes; }
            set
            {
                // If a positive number is assigned to the property, then change the value
                if (value > 0)
                {
                    prepTimeMinutes = value;
                }
                // If 0 or a negative number is assigned to the property, then use a default value of 1
                else
                {
                    prepTimeMinutes = 1;
                }
            }
        }
        // Ingredients property
        public string Ingredients { get; set; }
        // SubmittedBy property
        public string SubmittedBy { get; set; }

        // Constructor to Create a new Recipe Product
        public Recipe(string name, string category, int prepTime, string ingredients, string submittedBy)
        {
            Name = name;
            Category = category;
            PrepTime = prepTime;
            Ingredients = ingredients;
            SubmittedBy = submittedBy;
        }

        public virtual string Display()
        { 
            // Return recipe details
            // TODO: work on formatting
            return Name + "(" + Category + ")";
        }

        public virtual string Display(int num)
        {
            // Return recipe details
            // TODO: work on formatting
            if (num == 2)
            {
                return Name + "(" + Category + ")";
            }
            else
            {
                return Name;
            }
        }

        public void UpdatePrepTime(int newTime) 
        {
            // TODO: add more logic or get rid of this method
            PrepTime = newTime;
        }
    }
}
