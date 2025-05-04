using Microsoft.Data.SqlClient;
using System.Data;

namespace Recipe
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
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
                    dgvShow.DataSource = table;
                }
            }
        }
    }
}