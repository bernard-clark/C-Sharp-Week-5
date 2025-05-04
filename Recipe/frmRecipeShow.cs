using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Recipe
{
    public partial class frmRecipeShow : Form
    {
        public frmRecipeShow()
        {
            InitializeComponent();
        }

        private void frmRecipeShow_Load(object sender, EventArgs e)
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
            }
        }
    }
}