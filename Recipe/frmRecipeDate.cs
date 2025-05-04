using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe
{
    public partial class frmRecipeDate : Form
    {
        public frmRecipeDate()
        {
            InitializeComponent();
        }

        private void btnAddRecipes_Click(object sender, EventArgs e)
        {
            // Create a Recipe class
            // TODO: make sure that a name has been entered
            Recipe newRecipe = new Recipe(txtName.Text, txtCategory.Text, (int)numPrepTime.Value, txtIngredients.Text, txtSubmittedBy.Text);

            lbRecipes.Items.Add(newRecipe.Name + " " + newRecipe.Category);

            // Add a dessert recipe
            // TODO: add a dropdownlist to the form to determine recipe type
            DessertRecipe newDessertRecipe = new DessertRecipe(txtName.Text, txtCategory.Text, (int)numPrepTime.Value, txtIngredients.Text, txtSubmittedBy.Text, true);

            // Display the dessert items
            lbRecipes.Items.Add(newDessertRecipe.Display());

            // Add a food recipe
            // TODO: add a dropdownList to the form to determine recipe type
            FoodRecipe newFoodRecipe = new FoodRecipe(txtName.Text, txtCategory.Text, (int)numPrepTime.Value, txtIngredients.Text, txtSubmittedBy.Text, true);

            // Display the food items
            lbRecipes.Items.Add(newFoodRecipe.Display());

            // Insert the recipe into the database
            InsertRecipes(newRecipe.Name, newRecipe.Category, newRecipe.PrepTime, newRecipe.Ingredients, Convert.ToInt32(newRecipe.SubmittedBy));
        }

        private void InsertRecipes(string strRecipeName, string strCategory, int intPrepTime, string strIngredients, int intSubmittedBy)
        {
            // This is our connection string to our mdr database in our project
            string strConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Users\berna\source\repos\Recipe\Recipes.mdf;Integrated security=True;Connect Timeout=30;";

            // This SQL code will insert a new record into the database
            string strQuery = @"INSERT INTO tblRecipe
                                (recipe_name, prep_time, ingredients, fk_user, category)
                                VALUES(@recipe_name, @prep_time, @ingredients, @fk_user, @category)";
            // Open a connection to our database
            using (SqlConnection connection = new SqlConnection(strConnString))
            // Set up the code so that we can run the query with the resources managed for us
            using (SqlCommand cmd = new SqlCommand(strQuery, connection))
            {
                // Commands for adding the parameters to the insert query
                // Make sure the @parameter_name matches the @parameter_name in the query string exactly
                cmd.Parameters.AddWithValue("@recipe_name", strRecipeName);
                cmd.Parameters.AddWithValue("@prep_time", intPrepTime);
                cmd.Parameters.AddWithValue("@ingredients", strIngredients);
                cmd.Parameters.AddWithValue("@fk_user", intSubmittedBy);
                cmd.Parameters.AddWithValue("@category", strCategory);
                // Open the database connection
                connection.Open();
                // Add the record into the database
                cmd.ExecuteNonQuery();

                // Close the connection to our database
                connection.Close();
            }
        }

        private void LoadRecipes(object sender, EventArgs e)
        {
            // This is our connection string to our mdr database in our project
            string strConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Users\berna\source\repos\Recipe\Recipes.mdf;Integrated security=True;Connect Timeout=30;";

            // Simple query to return all rows
            string strQuery = "SELECT * FROM tblRecipe";

            // Open a connection to our database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                connection.Open();

                // Set up the code so that we can run the query with the resources managed for us
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Data adapter so the data can be used in our data grid view
                    SqlDataAdapter adapter = new SqlDataAdapter(strQuery, strConnString);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvRecipes.DataSource = table;

                }
                // Close connection to our database
                connection.Close();
            }
        } 
    }
}